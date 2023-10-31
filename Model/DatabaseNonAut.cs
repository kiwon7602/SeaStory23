using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;



namespace SeaStory.Model
{
    public class NonMember
    {
        public string CardNumber;
        public int RemainingHours; //비회원이 가지고 있는 남은 시간(사용 가능 시간).
        public bool IsActive; //비회원의 계정 활성 여부를 나타내는 부울 값.
    }
    public class Food
    {
        public string FoodName; //: 음식 이름.
        public string FoodCode; //: 음식의 고유 코드.
        public int FoodPrice; //: 음식의 가격.
        public string ImageURL; //: 음식 이미지의 URL.
    }
    public class DatabaseNonAut
    {
        private static string connStr = "server=webp.flykorea.kr;user=story;database=storyDB;port=13306;password=sea@#21;";
        MySqlConnection conn = new MySqlConnection(connStr);

        public List<NonMember> GetNonMembers()
        {
            List<NonMember> nonMembers = new List<NonMember>();

            try
            {
                conn.Open();
                string sql = "SELECT * FROM NonMember";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NonMember nonMember = new NonMember();
                        nonMember.CardNumber = reader["CardNumber"].ToString();
                        nonMember.RemainingHours = Convert.ToInt32(reader["RemainingHours"]);
                        nonMember.IsActive = Convert.ToBoolean(reader["IsActive"]);

                        nonMembers.Add(nonMember);
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

            return nonMembers;
        }

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
    }

}
