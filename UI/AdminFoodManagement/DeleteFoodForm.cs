using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaStory.UI.AdminFoodManagement
{
    public partial class DeleteFoodForm : Form
    {
        // Dictionary to keep track of menu items and their respective CheckBoxes.
        private List<MenuItemControl> itemsToDelete = new List<MenuItemControl>();

        public DeleteFoodForm()
        {
            InitializeComponent();
            PopulateWithMenuItems();
        }

        public void PopulateWithMenuItems()
        {
            // get items from database

            // test : use fake data
            // test : create fake data
            var foodItemList = new List<(Image Image, string Name, decimal Price)>
            {
                (Image.FromFile("../../../assets/pizza.jpg"), "Pizza", 9.99m),
                (Image.FromFile("../../../assets/burger.jpg"), "Burger", 5.49m),
                (Image.FromFile("../../../assets/sushi.jpg"), "Sushi", 12.99m),
                (Image.FromFile("../../../assets/pasta.jpg"), "Pasta", 7.99m),
                (Image.FromFile("../../../assets/salad.jpg"), "Salad", 4.99m)
            };

            // PLEASE HELP
            foreach (var (Image, Name, Price) in foodItemList)
            {
                // Create an instance of your custom control that includes a CheckBox
                var menuItemControl = new MenuItemWithCheckboxControl(Image, Name, Price.ToString("C"));

                // Add the menuItemControl to the FlowLayoutPanel
                flowLayoutPanelMenuItems.Controls.Add(menuItemControl);

                // Associate the menuItemControl with its CheckBox in the dictionary for later retrieval
                itemsToDelete.Add(menuItemControl);
            }
        }

        private void DeleteFoodItemFromDatabase(MenuItemControl menuItemControl)
        {
            // Implement the logic to delete the menu item from your database.

        }

        private void buttonDeleteCheckedFood_Click(object sender, EventArgs e)
        {
            // This should find all the checked items in the flowpanel and delete all of them from the database
            var itemsToDeleteList = itemsToDelete.OfType<MenuItemWithCheckboxControl>()
                                                 .Where(control => control.IsChecked())
                                                 .ToList(); // We call ToList() here to avoid collection modification issues during enumeration.

            foreach (var menuItemControl in itemsToDeleteList)
            {
                // Implement your database deletion logic here.
                DeleteFoodItemFromDatabase(menuItemControl);

                // Remove the menuItemControl from the flowLayoutPanelMenuItems
                flowLayoutPanelMenuItems.Controls.Remove(menuItemControl);
                // Dispose the menuItemControl to free resources
                menuItemControl.Dispose();

                // Finally, remove the entry from the itemsToDelete list
                itemsToDelete.Remove(menuItemControl);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // this should leave the form without making any changes
            this.Close();
        }
    }
}
