using SeaStory.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using static SeaStory.Model.DataCalss;
using User = SeaStory.Model.DataCalss.User;

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

            InitializeUser();
            InitializeSeats(); 

            //버튼에 대한 정보 초기화 부분
            //DB에서 리스트 형태로 좌석 정보 받음
            //1. 빈자리인 경우 - 버튼 텍스트에 좌석 이름만 받음
            //2. 사용중 좌석이면서 사용 시간이 null인 경우 - 버튼 텍스트에 좌석 이름 \r\n 사용자명 , 버튼 상태 enable -false
            //3. 사용중 좌석이면서 사용 시간이 있는 경우 - 버튼 텍스트에 좌석 이름  \r\n 사용자명  \r\n 잔여 시간 , 버튼 상태 enable -false
        }
        private void InitializeUser()
        {
            //회원 로그인
            if (userType == 0)
            {
                //로그인 폼에서 받아온 ID 기반 유저 정보 넣기
                User user = Model.DatabaseAut.UserData(userID);

                //유저 정보 기반 유저명 호출 및 표시
                label3.Text = user.Name;
            }
            //비회원 로그인
            if (userType == 1)
            {
                //카드 번호 출력
                label3.Text = userID;
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

            label1.Text = availableSeatsCount.ToString();
            label2.Text = usedSeatsCount.ToString();

            seatPanel1.SetSeatClickHandler(button1_Click);
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
        private void button1_Click(string userId, int userType, string seat)
        {
            //1.해당 좌석에 ID기반으로 DB에 사용 유저와 적립 시간을 넣는다
            //2.유저 ID, 회원 비회원 토글 ,좌석의 번호를 main폼으로 넘긴다
            //임의로 seat = "01" 로 생성해서 테스트

            //좌석 번호와 ID를 넘겼을 때 DB에서 좌석 테이블에 해당 좌석 번호에 사용자 이름과 남은 시간이 등록되도록 하는 함수
            // string seat = "01";
            PlayAudioForSeat(int.Parse(seat));
            user_interface_main user_Interface_main = new user_interface_main(userID, userType, seat);
            user_Interface_main.Show();
            this.Close();
        }

        public void PlayAudioForSeat(int seatNumber)
        {
            // 재생할 음성 파일 경로
            string basePath = @"C:\Users\admin\Documents\GitHub\SeaStory23\UI\tts\seattts"; // 적절한 상대 경로로 수정
            string audioFileName = $"audio_{seatNumber}.wav"; // 예시 파일명, 필요에 따라 수정

            string audioFilePath = Path.Combine(basePath, audioFileName);

            // 음성 파일이 존재하는지 확인 후 재생
            if (File.Exists(audioFilePath))
            {
                try
                {
                    SoundPlayer soundPlayer = new SoundPlayer(audioFilePath);
                    soundPlayer.Play();
                }
                catch (Exception ex)
                {
                    // 재생 중 오류가 발생한 경우 처리
                    Console.WriteLine("음성 파일을 재생하는 중 오류가 발생했습니다: " + ex.Message);
                }
            }
            else
            {
                // 파일이 존재하지 않을 경우 처리
                Console.WriteLine("음성 파일이 존재하지 않습니다: " + audioFilePath);
            }
        }

    }
}
