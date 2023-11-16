using Microsoft.VisualBasic.ApplicationServices;
using SeaStory.UI.AdminFoodManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SeaStory.Model.DataCalss;
using User = SeaStory.Model.DataCalss.User;

// 시간이 변경되는 동작이 있는 경우 좌석 테이블의 좌석코드와 업데이트 이후의 시간을 넣어 업데이트 해주는 함수 필요

namespace SeaStory
{
    public partial class user_interface_main : Form
    {
        private Timer timer;
        private string userID; // userID 추가
        private int userType; // userType 추가
        private string seatNumber; // seat_number 추가

        public user_interface_main(string ID, int user_type, string seat_number)
        {
            InitializeComponent();
            //타이머 작동 함수
            InitializeTimer();
            userID = ID;
            userType = user_type;
            seatNumber = seat_number;
            //회원 로그인
            if (user_type == 0)
            {
                //로그인 폼에서 받아온 ID 기반 유저 정보 넣기
                User user = Model.DatabaseAut.UserData(ID);
                label1.Text = "회원 요금제";
                //유저 정보 기반 유저명 호출 및 표시
                label3.Text = user.Name;
                //남은 시간
                //label6.Text = user.Time;
            }
            if (user_type == 1)
            {
                //비회원 로그인
                label1.Text = "비회원 요금제";
            }
            //자리 번호
            label8.Text = seat_number;

            //타이머관련 함수 설계
            //1. 타이머 이벤트 생성 (5초 단위) 아래 내용 전부 넣기
            //2. GetUesrTime를 통해 유저의 잔여 시간 체크
            //3. 잔여시간이 0 이 아니라면 SpendTime( DB 유저 잔여시간 5초 감소 사용시간 5초 증가)
            //4. GetUesrTime를 통해 유저의 갱신된 잔여시간 받아와서 받아온 값을 기준으로 잔여시간 표시 (DB 2번 접근으로 인해 속도 문제 발생 가능성 야기)
            //4-2. 처음에 받아온 데이터에 5를 감소한 값을 잔여 시간으로 표시


            //요금제 버튼 동적 할당 설계
            //1. 회원 비회원 유저 타입에 따른 요금제 라벨 수정
            //2. DB에서 유저 타입에 맞게 회원 요금제 비회원 요금제를 리스트로 가져옴
            //3. 리스트 내용을 기반으로 foreach 버튼 동적 생성
            //4. 버튼 동적 생성될 때 이벤트도 달아주기
            //5. 이벤트는 결제 폼열기 (유저 ID(카드번호), 선택한 요금제 코드)

        }
        //타이머 함수
        private void InitializeTimer()
        {
            // 타이머 생성
            timer = new Timer();

            // 타이머 간격 설정 (5초 = 5000밀리초)
            timer.Interval = 1000;

            // 타이머 이벤트 핸들러 등록
            timer.Tick += Timer_Tick;

            // 타이머 시작
            timer.Start();
        }

        //타이머 이벤트 핸들러
        private void Timer_Tick(object sender, EventArgs e)
        {
            // 시간 업데이트 메서드 호출
            UpdateTime(userID, userType, seatNumber);
        }
        //시간 업데이트 함수
        private void UpdateTime(string userID, int userType, string seatNumber)
        {
            //시간 변경 함수 들어가야됨

            if (!(Model.DatabaseAut.GetUesrTime(userID) == 0))
            {
                Model.DatabaseAut.SpendTime(userID);
            }
            // GetUesrTime을 통해 남은 시간을 초 단위로 받아옴
            int remainingTimeInSeconds = Model.DatabaseAut.GetUesrTime(userID);

            // 남은 시간을 시, 분, 초로 변환
            int hours = remainingTimeInSeconds / 3600;
            int minutes = (remainingTimeInSeconds % 3600) / 60;
            int seconds = remainingTimeInSeconds % 60;

            // 시간을 00:00:00 형태의 문자열로 변환
            string formattedTime = $"{hours:D2}:{minutes:D2}:{seconds:D2}";

            // label6에 남은 시간 표시
            label6.Text = formattedTime;
        }

        //요리 주문 버튼 클릭 시
        private void button10_Click(object sender, EventArgs e)
        {
            //요리 주문폼으로 showdialog 보내줄 정보는 회원id, 좌석 번호
            ManageFoodChildUser manageFoodChildUser = new ManageFoodChildUser();
            manageFoodChildUser.ShowDialog();
        }
        //사용 종료 버튼 클릭 시
        private void button11_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }


        // 폼이 닫힐 때 타이머 정리
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
            }
        }

        //프로그램 종료 추가 기능
        private void appCloseButton1_Load(object sender, EventArgs e)
        {
            //자리 테이블 자리코드 받고 네임 잔여시간 null
            //요리 주문 목록테이블에도 자리 코드 맞는거 다 지워줘야됨
        }
    }
}
