using SeaStory.manage_menu_branch;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private Dictionary<MenuItemControl, CheckBox> itemsToDelete = new Dictionary<MenuItemControl, CheckBox>();

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

            foreach (var (Image, Name, Price) in foodItemList)
            {
                var menuItemControl = new MenuItemControl(Image, Name, Price.ToString("C"));
                var checkBox = new CheckBox
                {
                    Dock = DockStyle.Right,
                    Margin = new Padding(0, 0, menuItemControl.Width, 0),
                    AutoSize = true
                };

                var panel = new Panel
                {
                    Width = flowLayoutPanelMenuItems.Width,
                    Height = menuItemControl.Height,
                    Dock = DockStyle.Top
                };

                panel.Controls.Add(menuItemControl);
                panel.Controls.Add(checkBox);
                flowLayoutPanelMenuItems.Controls.Add(panel);

                itemsToDelete.Add(menuItemControl, checkBox);
            }

        }

        private void DeleteFoodItemFromDatabase(MenuItemControl menuItemControl)
        {
            // Implement the logic to delete the menu item from your database.

        }

        private void buttonDeleteCheckedFood_Click(object sender, EventArgs e)
        {
            // This should find all the checked items in the flowpanel and delete all of them from the database
            var checkedItems = itemsToDelete.Where(kvp => kvp.Value.Checked).Select(kvp => kvp.Key).ToList();
            foreach (var item in checkedItems)
            {
                // Implement your database deletion logic here.
                DeleteFoodItemFromDatabase(item);

                // Remove the panel from the flowLayoutPanel as well as the entry from the dictionary.
                flowLayoutPanelMenuItems.Controls.Remove(itemsToDelete[item].Parent);
                itemsToDelete.Remove(item);


            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // this should leave the form without making any changes
            this.Close();
        }
    }
}
