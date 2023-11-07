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
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
