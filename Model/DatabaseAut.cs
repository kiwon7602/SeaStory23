using MySql.Data.MySqlClient;
using System;



namespace SeaStory.Model
{

    class DatabaseAut
    {
        public class User
        {
            public string name;
            public string phoneNumber;
            public string time;
            public string usedTime;
            public string loginType;
            public bool userType;
        }


        private static string connStr = "server=webp.flykorea.kr;user=story;database=storyDB;port=13306;password=sea@#21;";
        MySqlConnection conn = new MySqlConnection(connStr);

        public int UserCheck(string Id, string Pw)
        {
            try
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM 테이블명 WHERE Id = @Id AND Pw = @Pw";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Pw", Pw);

                object count = cmd.ExecuteScalar();

                if (count != null && Convert.ToInt32(count) > 0)
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return -1;

        }

        public User UserData(string Id)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            User user = null;

            try
            {
                conn.Open();
                string sql = "SELECT * FROM 테이블명 WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", Id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    user = new User();

                    if (reader.Read())
                    {
                        user.name = reader["name"].ToString();
                        user.phoneNumber = reader["phoneNumber"].ToString();
                        user.time = reader["time"].ToString();
                        user.usedTime = reader["usedTime"].ToString();
                        user.loginType = reader["loginType"].ToString();
                        user.userType = Convert.ToBoolean(reader["userType"]);
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

            return user;
        }




    }
}


