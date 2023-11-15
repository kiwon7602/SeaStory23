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

namespace SeaStory.UI
{
    public partial class user_seat : Form
    {
        //user_type = 0 회원 유저
        //user_type = 1 비회원 유저

        private string userID;
        private int userType;
        private string selectedSeat;

        public user_seat(string ID, int user_type)
        {
            InitializeComponent();
            userID = ID;
            userType = user_type;
            //회원 로그인
            if (user_type == 0)
            {
                //로그인 폼에서 받아온 ID 기반 유저 정보 넣기
                User user = Model.DatabaseAut.UserData(ID);

                //유저 정보 기반 유저명 호출 및 표시
                label3.Text = user.Name;
            }
            //비회원 로그인
            if (user_type == 1)
            {
                //카드 번호 출력
                label3.Text = ID;
            }

            //리스트 형태로 좌석 정보 받아오기
            List<Seat> seats = DatabaseNonAut.GetSeats();

            //잔여석 사용중 좌석 표시
            
            //사용석 갯수
            int use_seats = 0;
            
            //사용석 갯수 구하는 함수
            foreach (Seat seat in seats)
            {
                if (!string.IsNullOrEmpty(seat.UserID)) use_seats++;
            }
            //잔여석 갯수
            int seatsCount = seats.Count - use_seats;
            //잔여석
            label1.Text = seatsCount.ToString();
            //사용석
            label2.Text = use_seats.ToString();
            


            //버튼에 대한 정보 초기화 부분
            //DB에서 리스트 형태로 좌석 정보 받음
            //1. 빈자리인 경우 - 버튼 텍스트에 좌석 이름만 받음
            //2. 사용중 좌석이면서 사용 시간이 null인 경우 - 버튼 텍스트에 좌석 이름 \r\n 사용자명 , 버튼 상태 enable -false
            //3. 사용중 좌석이면서 사용 시간이 있는 경우 - 버튼 텍스트에 좌석 이름  \r\n 사용자명  \r\n 잔여 시간 , 버튼 상태 enable -false


        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }

        //1번 좌석 클릭
        //추후 좌석 버튼을 오브젝트화해서 따로 제작할 예정
        //테스트를 위해 제작
        private void button1_Click(object sender, EventArgs e)
        {
            //1.해당 좌석에 ID기반으로 DB에 사용 유저와 적립 시간을 넣는다
            //2.유저 ID, 회원 비회원 토글 ,좌석의 번호를 main폼으로 넘긴다
            //임의로 seat = "01" 로 생성해서 테스트
            string seat = "01";
            user_interface_main user_Interface_main = new user_interface_main(userID, userType, seat);
            user_Interface_main.Show();
            this.Close();
        }
    }
}
