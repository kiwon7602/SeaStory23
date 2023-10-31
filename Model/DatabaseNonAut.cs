using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace SeaStory.Model
{
    public class NonMember
    {

    }
    public class Food
    {

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
