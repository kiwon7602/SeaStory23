using SeaStory.Model;
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
            DatabaseAut database = new DatabaseAut();
            DatabaseNonAut databaseNonAut = new DatabaseNonAut();
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 어스부분에서 체크할때
            int v = Model.DatabaseAut.UserCheck("admin", "1234");
            label1.Text = v.ToString();
            // 리스트 받아쓸떄
            List<Food> foods = DatabaseNonAut.GetFoods();
        }
    }
}
