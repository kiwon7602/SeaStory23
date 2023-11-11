using Org.BouncyCastle.Crypto;
using SeaStory.Model;
using SeaStory.UI.AdminFoodManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaStory.UI.AdminFoodManagement
{
    public partial class ManageFoodParent : Form
    {
        private DatabaseNonAut db = new DatabaseNonAut();

        public ManageFoodParent()
        {
            InitializeComponent();
            CreateMenuItemsAsync().ConfigureAwait(false); // Call the new async method
        }

        protected async Task CreateMenuItemsAsync()
        {
            // Clear existing items
            flowLayoutPanelMenuItems.Controls.Clear();

            // get menu from database here
            var foodItemList = db.GetFoods();


            // test : create fake data
            /*
            var foodItemList = new List<(Image Image, string Name, decimal Price)>
            {
                // (Image.FromFile("../../../assets/pizza.jpg"), "Pizza", 9.99m),
                // (Image.FromFile("../../../assets/burger.jpg"), "Burger", 5.49m),
                // (Image.FromFile("../../../assets/sushi.jpg"), "Sushi", 12.99m),
                // (Image.FromFile("../../../assets/pasta.jpg"), "Pasta", 7.99m),
                // (Image.FromFile("../../../assets/salad.jpg"), "Salad", 4.99m)
            };
            */

            foreach (var foodItem in foodItemList)
            {
                Image foodImage = await ImageDownloader.LoadImageAsync(foodItem.ImageURL);
                var menuItemControl = new MenuItemControl(foodImage, foodItem.FoodName, foodItem.FoodPrice.ToString("C", new CultureInfo("ko-KR")));

                flowLayoutPanelMenuItems.Controls.Add(menuItemControl); 
            }

        }

    }
}
