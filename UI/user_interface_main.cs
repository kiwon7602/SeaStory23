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

namespace SeaStory
{
    public partial class user_interface_main : Form
    {
        public user_interface_main(string ID, int user_type, string seat_number)
        {
            InitializeComponent();
            //회원 로그인
            if (user_type == 0)
            {
                //로그인 폼에서 받아온 ID 기반 유저 정보 넣기
                User user = Model.DatabaseAut.UserData(ID);

                //유저 정보 기반 유저명 호출 및 표시
                label3.Text = user.Name;
                //남은 시간
                label6.Text = user.Time;
            }
            if (user_type == 1)
            {
                //비회원 로그인
            }
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

        //요리 주문 버튼 클릭 시
        private void button10_Click(object sender, EventArgs e)
        {
            //요리 주문폼으로 showdialog 보내줄 정보는 회원id, 좌석 번호

        }
        //사용 종료 버튼 클릭 시
        private void button11_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }
    }
}
