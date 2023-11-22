import asyncio
import json
import logging


logger = logging.getLogger(__name__)

class Seat:
    def __init__(self, seatNum, user, remaining_time, connection=None):
        self.seatNum = seatNum
        self.user = user
        self.connection = None

        self.remaining_time = int(remaining_time) if remaining_time is not None else remaining_time
        self.lock = asyncio.Lock()  # Add a lock for each seat

    def __repr__(self):
        connection_status = "Connected" if self.connection else "No Connection"
        return f"[{self.seatNum} : {self.user}, {self.remaining_time}]"

class UserManager:
    def __init__(self, db):
        self.db = db

    async def initialize(self):
        query = "SELECT SeatNumber, UserID, UsageTime FROM Seat ORDER BY SeatNumber"
        seat_records = await self.db.execute_query(query)
        self.seats = {seatNum: Seat(seatNum, user, status) for seatNum, user, status in seat_records}

    async def get_user(self, user_id):
        query = "SELECT * FROM Member WHERE ID = %s"
        result = await self.db.fetch_one(query, (user_id,))
        return result

    async def add_user(self, user_id, seat_num, connection):
        seat = self.seats[seat_num]
        async with seat.lock:
            if self.seats[seat_num].user != None and self.seats[seat_num].user != user_id:
                logger.warning(f"Seat {seat_num} is already occupied by another user.")
                # handle error here
                return

            user_data = await self.get_user(user_id)
            if user_data is not None:
                id, _, _, _, remaining_sec, usage_time, _, _ = user_data
                seat.user = user_id
                seat.remaining_time = remaining_sec
                seat.connection = connection

                query = "UPDATE Seat SET UsageTime = %s, UserID = %s WHERE SeatNumber = %s"
                params = (remaining_sec, user_id, seat_num)
                await self.db.execute_query(query, params, commit=True)

                logger.info(f'User {id} (ID: {user_id}) has been activated on seat {seat_num}.')
            else:
                logger.error(f'User {user_id} not found. Cannot assign to seat {seat_num}.')
                # handle error here

                return
        
    async def reserve_user(self, user_id, seat_num, connection):
        seat = self.seats[seat_num]
        async with seat.lock:
            if seat.user is not None:
                logger.warning(f"Seat {seat_num} is already occupied by another user.")
                return

            user_data = await self.get_user(user_id)
            if user_data:
                id, _, _, _, _, _, _, _ = user_data
                seat.user = user_id
                seat.remaining_time = -1
                seat.connection = connection
                
                query = "UPDATE Seat SET UsageTime = %s, UserID = %s WHERE SeatNumber = %s"
                params = (-1, user_id, seat_num)
                await self.db.execute_query(query, params, commit=True)

                logger.info(f'User {id} (ID: {user_id}) has been reserved on seat {seat_num}.')
            else:
                logger.error(f'User {user_id} not found. Cannot assign to seat {seat_num}.')
                # handle error here

                return


    async def remove_user(self, user_id, seat_num, websocket):
        seat = self.seats.get(seat_num)
        if not seat:
            logger.error(f"Invalid seat number: {seat_num}. Removal operation aborted.")
            return

        async with seat.lock:
            if seat.user == user_id:
                seat.user = None
                seat.remaining_time = 0

                query = "UPDATE Seat SET UsageTime = %s, UserID = %s WHERE SeatNumber = %s"
                params = (None, None, seat_num)
                await self.db.execute_query(query, params, commit=True)


                logger.info(f'User {user_id} has been deactivated from seat {seat_num}.')
            else:
                logger.warning(f'User {user_id} not found in active users on seat {seat_num}.')
                # handle error

    async def update_member_table(self, seat):
        query = "UPDATE Member SET RemainingTime = %s, UsageTime = UsageTime+1 WHERE ID = %s"
        params = (seat.remaining_time, seat.user)
        await self.db.execute_query(query, params, commit=True)
        
    async def update_seat_table(self, seat):
        query = "UPDATE Seat SET UsageTime = %s WHERE UserID = %s"
        params = (seat.remaining_time, seat.user)
        await self.db.execute_query(query, params, commit=True)
        
    async def get_remaining_hours(self, user_id):
        query = "SELECT RemainingTime FROM Member WHERE ID = %s"
        result = await self.db.fetch_one(query, (user_id,))
        return result[0] if result else None

    
    async def decrement_time(self, seat):
        async with seat.lock:
            # Decrement the remaining time
            seat.remaining_time -= 1

            await self.update_seat_table(seat)
            await self.update_member_table(seat)

        if seat.remaining_time < 0:
            if seat.connection:
                try:
                    # await seat.connection.send("Your remaining time is 0. Please vacate the seat.")
                    message = self.build_json({"command": "logout"})
                    await self.send_json(message, seat.connection)
                    # close connection and remove user from seat
                except Exception as e:
                    logger.error(f"Error sending message to client: {e}")
                finally:
                    pass
                    # This is a bit odd because ideally I think you would want to remove the user here
                    # But instead, we're delegating the duty to the client so that it invokes the remove_user function
                    # seat.user = None
                    # seat.remaining_time = None
                    # Optionally, you can close the connection here if needed
                    # await seat.connection.close()
            
            await self.remove_user(seat.user, seat.seatNum, seat.connection)

    def build_json(self, data):
        try:
            return json.dumps(data)
        except TypeError as e:
            logger.error(f"Error in building JSON: {e}")
            return None

    async def send_json(self, json_string, connection):
        if not json_string or not connection:
            logger.warning("Invalid input for sending JSON")
            return

        try:
            await connection.send(json_string)
        except Exception as e:
            logger.error(f"Error sending JSON to client: {e}")

    async def decrement_all_seats(self):
        for seat in self.seats.values():
            if seat.user is not None and seat.remaining_time is not None and seat.remaining_time >= 0:
                await self.decrement_time(seat)
