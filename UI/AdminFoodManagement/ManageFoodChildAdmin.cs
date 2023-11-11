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
    public partial class ManageFoodChildAdmin : ManageFoodParent
    {
        public ManageFoodChildAdmin()
        {
            InitializeComponent();
        }

        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            // Add Menu When clicked
            // Open a new form

            using (AddFoodForm addFoodForm = new AddFoodForm())
            {
                if (addFoodForm.ShowDialog() == DialogResult.OK && addFoodForm.Confirm)
                {
                    // Refresh the FlowLayoutPanel
                    CreateMenuItemsAsync().ConfigureAwait(false);
                }
            }
        }


        private void buttonDeleteFood_Click(object sender, EventArgs e)
        {
            // Delete Menu When clicked
            // open a new window and ask users to select which menus to delete
            using (DeleteFoodForm deleteFoodForm = new DeleteFoodForm())
            {
                if (deleteFoodForm.ShowDialog() == DialogResult.OK)
                {
                    // Refresh the FlowLayoutPanel
                    CreateMenuItemsAsync().ConfigureAwait(false);
                }
            }
        }

    }
}
