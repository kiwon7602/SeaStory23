using SeaStory.UI.AdminFoodManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaStory.manage_menu_branch
{
    public partial class ManageFood : Form
    {
        public ManageFood()
        {
            InitializeComponent();
            CreateMenuItems();
        }

        private void CreateMenuItems()
        {
            // get menu from database here

            // test : create fake data
            var foodItemList = new List<(Image Image, string Name, decimal Price)>
            {
                (Image.FromFile("../../../assets/pizza.jpg"), "Pizza", 9.99m),
                (Image.FromFile("../../../assets/burger.jpg"), "Burger", 5.49m),
                (Image.FromFile("../../../assets/sushi.jpg"), "Sushi", 12.99m),
                (Image.FromFile("../../../assets/pasta.jpg"), "Pasta", 7.99m),
                (Image.FromFile("../../../assets/salad.jpg"), "Salad", 4.99m)
            };


            foreach (var foodItem in foodItemList)
            {
                var menuItemControl = new MenuItemControl(foodItem.Image, foodItem.Name, foodItem.Price.ToString("C"));
                menuItemControl.Click += MenuItemControl_Click; // Subscribing to the click event.

                flowLayoutPanelMenuItems.Controls.Add(menuItemControl); // Assuming you have a FlowLayoutPanel.
            }

        }
        private void MenuItemControl_Click(object sender, EventArgs e)
        {
            var menuItemControl = sender as MenuItemControl;
            if (menuItemControl != null)
            {
                // Perform actions when a menu item is clicked.
                // Send to cart or ordering pate


            }
        }

        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            // Add Menu When clicked
            // Open a new form

            using (AddFoodForm addFoodForm = new AddFoodForm())
            {
                if (addFoodForm.ShowDialog() == DialogResult.OK && addFoodForm.Confirm)
                {
                    // Now you have the data from the AddFoodForm stored in its properties.
                    // You can access it like this:
                    Image foodImage = addFoodForm.FoodImage;
                    string foodName = addFoodForm.FoodName;
                    decimal foodPrice = addFoodForm.FoodPrice;

                    // Here you can add the new food item to the database
                    AddFoodItemToDatabase(foodImage, foodName, foodPrice);

                    // If you want to immediately display the new item in the menu:
                    var menuItemControl = new MenuItemControl(foodImage, foodName, foodPrice.ToString("C"));
                    flowLayoutPanelMenuItems.Controls.Add(menuItemControl);
                }
            }
        }

        private void AddFoodItemToDatabase(Image image, string name, decimal price)
        {
            // Implement your database logic here.
        }


        private void buttonDeleteFood_Click(object sender, EventArgs e)
        {
            // Delete Menu When clicked
            // open a new window and ask users to select which menus to delete
            using (DeleteFoodForm deleteFoodForm = new DeleteFoodForm())
            {
                if (deleteFoodForm.ShowDialog() == DialogResult.OK)
                {
                    // Refresh the FlowLayoutPanel or other UI elements if necessary

                }
            }
        }

        private void DeleteFoodItemFromDatabase(MenuItemControl menuItemControl)
        {
            // Implement the logic to delete the menu item from your database.
            // This will typically involve using the item's identifier or name to remove it from the database.
        }
    }
}
