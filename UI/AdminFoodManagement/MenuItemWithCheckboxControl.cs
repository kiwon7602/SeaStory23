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
    public partial class MenuItemWithCheckboxControl : MenuItemControl
    {
        public MenuItemWithCheckboxControl() { }
        public MenuItemWithCheckboxControl(Image foodImage, string foodName, int foodPrice, string foodCode)
            : base(foodImage, foodName, foodPrice, foodCode)
        {
            InitializeComponent();
        }
        public bool IsChecked()
        {
            return CheckBoxControl.Checked;
        }
    }
}
