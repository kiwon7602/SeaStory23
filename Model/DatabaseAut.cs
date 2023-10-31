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
                string sql = "SELECT COUNT(*) FROM Member WHERE ID = @Id AND Password = @Pw";
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
            finally
            {
                conn.Close();
            }
            return -1;
        }

        public User UserData(string Id)
        {
            User user = null;

            try
            {
                conn.Open();
                string sql = "SELECT * FROM Member WHERE ID = @Id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", Id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    user = new User();

                    if (reader.Read())
                    {
                        user.name = reader["Username"].ToString();
                        user.phoneNumber = reader["PhoneNumber"].ToString();
                        user.time = reader["RemainingHours"].ToString();
                        user.usedTime = reader["UsageHours"].ToString();
                        user.loginType = reader["LoginType"].ToString();
                        user.userType = Convert.ToBoolean(reader["IsAdmin"]);
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

        // 이메일 인증 구글 api를 사용하여서 해라?
        //디비 수정 시작
    }
}


