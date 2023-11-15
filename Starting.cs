using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//미사용 폼
//부모폼으로 설정하고 시작점으로 두는 경우 사용
namespace SeaStory
{
    public partial class Starting : Form
    {
        public Starting()
        {
            InitializeComponent();
            //처음 시작할 폼 여기 설정
            login login = new login();
            login.Show();
            //폼 화면 최소화
            this.WindowState = FormWindowState.Minimized;
            //작업표시줄에서 지우기
            this.ShowInTaskbar = false;

        }
    }
}
