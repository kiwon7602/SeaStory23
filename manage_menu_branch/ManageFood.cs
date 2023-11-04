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

        }

        private void buttonDeleteFood_Click(object sender, EventArgs e)
        {
            // Delete Menu When clicked
            // open a new window and ask users to select which menus to delete
        }
    }
}
