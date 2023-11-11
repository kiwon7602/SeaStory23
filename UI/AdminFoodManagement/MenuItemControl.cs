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

namespace SeaStory.UI.AdminFoodManagement
{
    public partial class MenuItemControl : UserControl
    {
        public string FoodName { get; private set; }
        public Image FoodImage { get; private set; }
        public int FoodPrice { get; private set; }

        // You could use a custom constructor or properties to pass in the image, name, and price.

        public MenuItemControl()
        {
            InitializeComponent();
        }

        public MenuItemControl(Image foodImage, string foodName, int foodPrice)
        {
            InitializeComponent();

            this.FoodImage = foodImage;
            this.FoodName = foodName;
            this.FoodPrice = foodPrice; 

            this.pictureBoxFood.Image = foodImage;
            this.labelFoodName.Text = foodName;
            this.labelPrice.Text = FoodPrice.ToString("C", new CultureInfo("ko-KR"));
        }
    }
}
