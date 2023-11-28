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

namespace SeaStory.UI.TimeManagement
{
    public partial class AddTime : Form
    {
        public AddTime()
        {
            DatabaseAut database = new DatabaseAut();
            InitializeComponent();
        }

        private void buttonAddTime_Click(object sender, EventArgs e)
        {
            // Grab the data from the controls
            int time = (int)numericUpDownTime.Value;
            int price = (int)numericUpDownPrice.Value;
            string name = textBoxName.Text;

            DatabaseAut.UpdateSubscription(name, price, time.ToString());
            // Optionally close the form if needed after adding
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Simply close the form
            this.Close();
        }

        // Placeholder method for database interaction
        private void SendDataToDatabase(int time, int price, string name)
        {
            // Your database code would go here
            // Example:
            // var db = new DatabaseConnection();
            // db.AddNewSubscription(time, price, name);

            Console.WriteLine($"Data to be sent to DB: Time: {time}, Price: {price}, Name: {name}");
        }

    }


}
