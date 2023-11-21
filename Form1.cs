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
            listView1.Columns.Add("Name", 150);
            listView1.Columns.Add("FoodCode", 100);
            listView1.Columns.Add("Price", 80);
            listView1.Columns.Add("URL", 200);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int v = Model.DatabaseAut.UserCheck("admin", "1234");
            label1.Text = v.ToString();

            // Get the list of foods
            List<Food> foods = DatabaseNonAut.GetFoods();

            // Clear existing items in the ListView
            listView1.Items.Clear();

            // Iterate through the list of Food objects and add them to the ListView
            foreach (Food food in foods)
            {
                ListViewItem item = new ListViewItem(food.FoodName);
                item.SubItems.Add(food.FoodCode);
                item.SubItems.Add(food.FoodPrice.ToString());
                item.SubItems.Add(food.ImageURL);

                listView1.Items.Add(item);
            }
        }
    }
}
