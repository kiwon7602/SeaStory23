using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static SeaStory.Model.DataCalss;
using User = SeaStory.Model.DataCalss.User;
using SeaStory.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Media;
namespace SeaStory.UI
{
    public partial class user_seat : Form
    {
        //user_type = 0 회원 유저


        private string userID;
        private int userType;
        private string selectedSeat;

        public user_seat(string ID, int user_type)
        {
            InitializeComponent();
            SoundPlayer simpleSound = new SoundPlayer(@"..\..\..\UI\tts\login.wav");
            simpleSound.Play();
            userID = ID;
            userType = user_type;

            InitializeUser();
            InitializeSeats();

        }
        private void InitializeUser()
        {
            //회원 로그인
            if (userType == 0)
            {
                //로그인 폼에서 받아온 ID 기반 유저 정보 넣기
                User user = Model.DatabaseAut.UserData(userID);

                //유저 정보 기반 유저명 호출 및 표시
                labelUserName.Text = user.Name;
            }

        }
        private void InitializeSeats()
        {
            //리스트 형태로 좌석 정보 받아오기
            List<Seat> seats = DatabaseNonAut.GetSeats();

            //잔여석 사용중 좌석 표시
            //사용석 갯수 구하는 함수
            int usedSeatsCount = seats.Count(seat => !string.IsNullOrEmpty(seat.UserID));
            int availableSeatsCount = seats.Count - usedSeatsCount;

            labelAvailableSeatCount.Text = availableSeatsCount.ToString();
            labelUsedSeatCount.Text = usedSeatsCount.ToString();

            seatPanel1.SetSeatClickHandler(button1_Click);


        }



        private void Back_Button_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }


        private void button1_Click(string userId, int userType, string seat)
        {
            user_interface_main user_Interface_main = new user_interface_main(userID, userType, seat);
            user_Interface_main.Show();
            this.Close();
        }

    }
}
