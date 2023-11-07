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
    public partial class AddFoodForm : Form
    {
        public Image FoodImage { get; private set; }
        public string FoodName { get; private set; }
        public decimal FoodPrice { get; private set; }
        public bool Confirm { get; private set; }

        public AddFoodForm()
        {
            InitializeComponent();
            Confirm = false;

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxFoodImage.Image = Image.FromFile(ofd.FileName);
                    FoodImage = pictureBoxFoodImage.Image;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FoodName = txtBoxFoodName.Text;
            FoodPrice = numericUpDownFoodPrice.Value; // Assuming a NumericUpDown control for price input.
            Confirm = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxFoodImage.Image = Image.FromFile(ofd.FileName);
                    FoodImage = pictureBoxFoodImage.Image;
                }
            }
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            FoodName = txtBoxFoodName.Text;
            FoodPrice = numericUpDownFoodPrice.Value; // Assuming a NumericUpDown control for price input.
            Confirm = true;
            this.Close();

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
