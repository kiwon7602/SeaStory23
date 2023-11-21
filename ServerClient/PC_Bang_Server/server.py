import asyncio
import websockets
from datetime import datetime
import json
from user_manager import *
from database import Database

# Database Configuration
db_config = {
    'user': 'story',
    'password': 'sea@#21',
    'host': 'webp.flykorea.kr',
    'db': 'storyDB',
    'port': 13306
}

async def initialize():
    # Initialize Database and Managers
    db = Database(asyncio.get_event_loop(), db_config)
    try:
        await db.connect()
    except Exception as e:
        print(f"Database connection failed: {e}")
        return None, None
    user_manager = UserManager(db)
    try:
        await user_manager.initialize()
    except Exception as e:
        print(f"User manager initialization failed: {e}")
        return None, None
    
    return db, user_manager

async def decrement_seats_periodically(user_manager):
    while True:
        try:
            await user_manager.decrement_all_seats()
            print("Seats decremented")
        except Exception as e:
            print(f"Error in decrement_seats_periodically: {e}")
        await asyncio.sleep(1)

async def main():
    db, user_manager = await initialize()

    if db is None or user_manager is None:
        print("Initialization failed, exiting.")
        return

    # Print the seats for testing purposes
    for seat in user_manager.seats.values():
        print(seat)

    # Command handlers dictionary
    command_handlers = {
        "add": user_manager.add_user,
        "delete": user_manager.remove_user,
        "reserve": user_manager.reserve_user,
    }

    async def interact(websocket, path):
        print(f"New connection opened at {datetime.now()}")
        try:
            async for message in websocket:
                data = json.loads(message)
                command = data["command"]
                user_id = data["user_id"]
                seat_num = data["seat_num"]

                handler = command_handlers.get(command)
                if handler:
                    await handler(user_id, seat_num, websocket)
                else:
                    print("Unknown command")

                # await websocket.send("Response or acknowledgment message")
                # I really should keep this up but... 
                # maybe later if I get the jsons sorted out for send messages back
        except websockets.exceptions.ConnectionClosedOK:
            print(f"Connection with client closed normally")
        except websockets.exceptions.ConnectionClosedError as e:
            print(f"Connection with client closed with error: {e}")
        finally:
            # Perform any cleanup here if needed
            pass

    # Start the periodic decrement task
    decrement_task = asyncio.create_task(decrement_seats_periodically(user_manager))

    start_server = websockets.serve(interact, "0.0.0.0", 8765)
    await start_server
    try:
        await asyncio.Future()  # Run forever
    finally:
        decrement_task.cancel()  # Cancel the background task on shutdown

asyncio.run(main())