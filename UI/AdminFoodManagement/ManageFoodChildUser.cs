using SeaStory.Model;
using SeaStory.ui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace SeaStory.UI.AdminFoodManagement
{
    public partial class ManageFoodChildUser : ManageFoodParent
    {
        public ManageFoodChildUser()
        {
            InitializeComponent();
        }

        protected override async Task CreateMenuItemsAsync()
        {
            // Clear existing items
            flowLayoutPanelMenuItems.Controls.Clear();

            // get menu from database 
            var foodItemList = DatabaseNonAut.GetFoods();

            foreach (var foodItem in foodItemList)
            {
                Image foodImage = await ImageDownloader.LoadImageAsync(foodItem.ImageURL);
                var menuItemControl = new MenuItemWithCheckboxControl(foodImage, foodItem.FoodName, foodItem.FoodPrice);

                flowLayoutPanelMenuItems.Controls.Add(menuItemControl);
            }

        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetInfoButton_Click(object sender, EventArgs e)
        {
            var checkedItemsInfo = new List<string>();
            decimal total_price = 0m;

            foreach (Control control in flowLayoutPanelMenuItems.Controls)
            {
                if (control is MenuItemWithCheckboxControl item && item.IsChecked())
                {
                    string info = $"Name: {item.FoodName}, Price: {item.FoodPrice}";
                    checkedItemsInfo.Add(info);

                    total_price += item.FoodPrice;
                    checkedItemsInfo.Add(info);
                }
            }

            Console.WriteLine("Hi mom");
            foreach (var item in checkedItemsInfo)
            {
                Console.WriteLine(item); // Or display in a UI element
            }

            
            using (UserInterFacePayment payment = new UserInterFacePayment())
            {
                payment.SetPrice((int)total_price);
                payment.ShowDialog(); // If you need to show the payment form
            }

        }

    }
}
