using SeaStory.UI.AdminFoodManagement;
using SeaStory.UI.TimeManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaStory.ui
{
    public partial class admin_inter_main : Form
    {
        public admin_inter_main()
        {
            InitializeComponent();
        }

        //요금제 관리 버튼 클릭 시
        private void button24_Click(object sender, EventArgs e)
        {
            ManageTimeAdmin manageTimeAdmin = new ManageTimeAdmin();
            manageTimeAdmin.ShowDialog();
        }

        //음식 관리 버튼 클릭 시
        private void button25_Click(object sender, EventArgs e)
        {

            ManageFoodChildAdmin manageFoodChildAdmin = new ManageFoodChildAdmin();
            manageFoodChildAdmin.ShowDialog();
        }
    }
}
