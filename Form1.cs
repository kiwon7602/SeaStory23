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

    public partial class Form1 : Form
    {


        public Form1()
        {
            User a = new User();
            int v = Model.DatabaseAut.UserCheck("hello", "world");

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ss = Model.DatabaseAut.UserCheck("hello","world");
            if (ss == 1)
            {
                label1.Text = "로그인 성공!";
            }
            else
            {
                label1.Text = "로그인 실패. 아이디 또는 비밀번호를 확인하세요.";
            }
        }
    }
}
