using MySqlX.XDevAPI;
using SeaStory.manage_menu_branch;
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
                    AutoSize = true
                };

                // Create a container panel for the MenuItemControl and the CheckBox
                var panel = new Panel
                {
                    Width = flowLayoutPanelMenuItems.Width / 2 - 10, // Adjust for padding/margins
                    Height = menuItemControl.Height,
                    Padding = new Padding(4),
                    Margin = new Padding(0, 0, 4, 4)
                };

                // Use a FlowLayoutPanel for horizontal layout within the panel
                var itemLayout = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    FlowDirection = FlowDirection.LeftToRight
                };

                itemLayout.Controls.Add(checkBox); // Add the CheckBox first, so it appears on the left
                itemLayout.Controls.Add(menuItemControl); // Add the MenuItemControl next

                panel.Controls.Add(itemLayout); // Add the FlowLayoutPanel to the container panel

                // Add the container panel to the main FlowLayoutPanel
                flowLayoutPanelMenuItems.Controls.Add(panel);

                // Keep track of the MenuItemControl and its associated CheckBox
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
            var itemsToDeleteList = itemsToDelete.Where(kvp => kvp.Value.Checked).ToList(); // We call ToList() here to avoid collection modification issues during enumeration.
            foreach (var kvp in itemsToDeleteList)
            {
                var menuItemControl = kvp.Key;
                var checkBox = kvp.Value;

                // Implement your database deletion logic here.
                DeleteFoodItemFromDatabase(menuItemControl);

                // Get the parent container panel of the CheckBox, which is the FlowLayoutPanel
                var itemLayoutPanel = checkBox.Parent as FlowLayoutPanel;
                // The parent of the itemLayoutPanel is the container Panel which we want to remove
                var containerPanel = itemLayoutPanel?.Parent as Panel;

                if (containerPanel != null)
                {
                    // Remove the container Panel from the flowLayoutPanelMenuItems
                    flowLayoutPanelMenuItems.Controls.Remove(containerPanel);
                    // Dispose the container panel to free resources
                    containerPanel.Dispose();
                }

                // Finally, remove the entry from the dictionary
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
