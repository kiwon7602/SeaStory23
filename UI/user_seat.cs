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

namespace SeaStory.UI
{
    public partial class user_seat : Form
    {
        //user_type = 0 회원 유저
        //user_type = 1 비회원 유저
        public user_seat(string ID,int user_type)
        {
            InitializeComponent();
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

            //잔여석 사용중 좌석 표시



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
            //2.유저 ID, 좌석의 번호를 main폼으로 넘긴다
            user_interface_main user_Interface_main = new user_interface_main();
            user_Interface_main.Show();
            //this.Close ();
        }
    }
}
