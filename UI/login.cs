﻿using SeaStory.ui;
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
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox2.BorderStyle = BorderStyle.FixedSingle;

            // KeyDown 이벤트 등록
            this.AcceptButton = button1;
        }

        //회원가입 버튼 클릭
        private void register_Click(object sender, EventArgs e)
        {
            //회원 가입 폼 열기
            user_interface user_Interface = new user_interface();
            user_Interface.ShowDialog();
        }

        // 로그인 버튼 클릭 또는 Enter 키 누를 때 실행되는 이벤트
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
                        this.Close();
                    }
                    else
                    {
                        //자리 선택 폼으로 이동
                        user_seat user_Seat = new user_seat(textBox1.Text, 0);
                        user_Seat.Show();
                        this.Close();
                    }
                }
                //로그인 실패
                else
                {
                    MessageBox.Show("로그인 정보가 잘못되었습니다!", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }


    }
}
