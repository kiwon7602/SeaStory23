using SeaStory.ui;
using SeaStory.UI;
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

namespace SeaStory
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            //초기값
            label1.Visible = true;
            textBox1.Visible = true;
            label2.Visible = true;
            textBox2.Visible = true;
            

        }

        //회원가입 버튼 클릭
        private void register_Click(object sender, EventArgs e)
        {
            //회원 가입 폼 열기
            user_interface user_Interface = new user_interface();
            user_Interface.ShowDialog();
        }

        //회원 라디오 버튼 값 변경 될 때
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            label2.Visible = true;
            textBox2.Visible = true;
            
        }
        //비회원 라디오 버튼 값 변경 될 때
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
            
        }

        //로그인 버튼 클릭
        private void button1_Click(object sender, EventArgs e)
        {
            //회원 로그인
            if (radioButton1.Checked)
            {
                //로그인 부분
                int login_check = Model.DatabaseAut.UserCheck(textBox1.Text, textBox2.Text);

                if (login_check == 1)
                {
                    //관리자 체크를 받아야 하기 때문에 유저 정보 받기
                    User user = Model.DatabaseAut.UserData(textBox1.Text);

                    //관리자 체크
                    if (user.UserType == true)
                    {
                        //관리자 폼 열기
                        admin_inter_main admin_Inter_Main = new admin_inter_main();
                        admin_Inter_Main.Show();
                        // this.Close();
                    }
                    else
                    {
                        //자리 선택 폼으로 이동
                        user_seat user_Seat = new user_seat(textBox1.Text, 0);
                        user_Seat.Show();
                        // this.Close();
                    }
                }
                //로그인 실패
                else
                {
                    MessageBox.Show("로그인 정보가 잘못되었습니다!", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            /*
            //비회원 로그인
            if (radioButton2.Checked)
            {
                //int login_check = Model.DatabaseAut.UserCheck(textBox3.Text);
                int login_check = 1;

                if (login_check == 1)
                {
                    user_seat user_Seat = new user_seat(textBox3.Text, 1);
                    user_Seat.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("로그인 정보가 잘못되었습니다!", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            */

        }
    }
}
