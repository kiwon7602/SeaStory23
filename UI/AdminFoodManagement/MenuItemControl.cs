using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaStory.manage_menu_branch
{
    public partial class MenuItemControl : UserControl
    {
        public string FoodName { get; private set; }
        public Image FoodImage { get; private set; }
        public string FoodPrice { get; private set; }

        // You could use a custom constructor or properties to pass in the image, name, and price.
        public MenuItemControl(Image foodImage, string foodName, string foodPrice)
        {
            InitializeComponent();

            this.pictureBoxFood.Image = foodImage;
            this.labelFoodName.Text = foodName;
            this.labelPrice.Text = foodPrice;

            // Wire up click events to a common handler that calls the OnClick method.
            this.Click += MenuItemControl_Click;
            this.pictureBoxFood.Click += MenuItemControl_Click;
            this.labelFoodName.Click += MenuItemControl_Click;
            this.labelPrice.Click += MenuItemControl_Click;
        }

        private void MenuItemControl_Click(object sender, EventArgs e)
        {
            this.OnClick(e); // This ensures the UserControl itself is clickable.
                             // Optionally, you could invoke a custom event here if you need to pass more data.
        }

        private void MenuItemControl_Load(object sender, EventArgs e)
        {

        }

        private void labelFoodName_Click(object sender, EventArgs e)
        {

        }

        private void labelFoodName_Click_1(object sender, EventArgs e)
        {

        }

        private void labelPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
