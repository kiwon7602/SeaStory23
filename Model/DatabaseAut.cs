using MySql.Data.MySqlClient;
using System;
using static SeaStory.Model.DataCalss;

namespace SeaStory.Model
{

    class DatabaseAut
    {

        private static string connStr = "server=webp.flykorea.kr;user=story;database=storyDB;port=13306;password=sea@#21;";
        MySqlConnection conn = new MySqlConnection(connStr);

        //회원 가입된 유저인지 확인하는 메소드, 있으면 1 없으면 -1을 반환한다.
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

        //일치하는 아이디의 회원정보를 모두 반환한다. 
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
                        user.Name = reader["Username"].ToString();
                        user.PhoneNumber = reader["PhoneNumber"].ToString();
                        user.Time = reader["RemainingHours"].ToString();
                        user.UsedTime = reader["UsageHours"].ToString();
                        user.LoginType = reader["LoginType"].ToString();
                        user.UserType = Convert.ToBoolean(reader["IsAdmin"]);
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

        // 이메일 인증 구글 api부분추가 예정
        // 사용자의 현재시간을 반환하는 메소드


        //어드민 인증이 필요함 

        // 회원정보를 수정하는 메소드
        // 자리정보를 수정하는 메소드
        // 요금제 정보를 수정하는 메소드
        //음식정보를 수정하는 메소드
    }
}


