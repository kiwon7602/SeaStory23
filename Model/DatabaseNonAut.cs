using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using static SeaStory.Model.DataCalss;


namespace SeaStory.Model
{
  

      class DatabaseNonAut
    {
        private static string connStr = "server=webp.flykorea.kr;user=story;database=storyDB;port=13306;password=sea@#21;";
        static MySqlConnection conn = new MySqlConnection(connStr);

        //리스트형태로 음식정보를 반환하는 메소드
        public List<Food> GetFoods()
        {
            List<Food> foods = new List<Food>();

            try
            {
                conn.Open();
                string sql = "SELECT * FROM Food";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Food food = new Food();
                        food.FoodName = reader["FoodName"].ToString();
                        food.FoodCode = reader["FoodCode"].ToString();
                        food.FoodPrice = Convert.ToInt32(reader["FoodPrice"]);
                        food.ImageURL = reader["ImageURL"].ToString();

                        foods.Add(food);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return foods;
        }

        // 리스트형태로 요금제 정보를 반환하는 메소드
        public List<SubscriptionTable> GetSubscriptions()
        {
            List<SubscriptionTable> subscriptions = new List<SubscriptionTable>();

            try
            {
                conn.Open();
                string sql = "SELECT * FROM Subscription";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SubscriptionTable subscription = new SubscriptionTable();
                        subscription.SubscriptionKey = reader["SubscriptionKey"].ToString();
                        subscription.SubscriptionName = reader["SubscriptionName"].ToString();
                        subscription.SubscriptionAmount = Convert.ToInt32(reader["SubscriptionAmount"]);
                        subscription.SubscriptionHours = Convert.ToInt32(reader["SubscriptionHours"]);

                        subscriptions.Add(subscription);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return subscriptions;
        }
        //리스트 형태로 주문정보를 반환하는 메소드
        public List<OrderTable> GetOrders()
        {
            List<OrderTable> orders = new List<OrderTable>();

            try
            {
                conn.Open();
                string sql = "SELECT * FROM OrderTable";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        OrderTable order = new OrderTable();
                        order.FoodCode = reader["FoodCode"].ToString();
                        order.OrderTime = Convert.ToInt32(reader["OrderTime"]);
                        order.OrderSeat = reader["OrderSeat"].ToString();

                        orders.Add(order);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return orders;
        }

        // 리스트 형태로 자리정보를 반환하는 메소드
        public List<Seat> GetSeats()
        {
            List<Seat> seats = new List<Seat>();

            try
            {
                conn.Open();
                string sql = "SELECT * FROM Seat";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Seat seat = new Seat();
                        seat.SeatNumber = Convert.ToInt32(reader["SeatNumber"]);
                        seat.UserID = reader["UserID"].ToString();
                        seat.UsageTime = reader["UsageTime"].ToString();

                        seats.Add(seat);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return seats;
        }

    }
}
