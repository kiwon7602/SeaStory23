using SeaStory.Model;
using SeaStory.ui;
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
using System.Xml.Schema;

namespace SeaStory.UI.AdminFoodManagement
{
    public partial class ManageFoodChildUser : ManageFoodParent
    {
        private string SeatID;

        public ManageFoodChildUser(string seat)
        {
            DatabaseAut database = new DatabaseAut();
            SeatID = seat;
            InitializeComponent();
        }

        protected override async Task CreateMenuItemsAsync()
        {
            // Clear existing items
            flowLayoutPanelMenuItems.Controls.Clear();

            // get menu from database 
            var foodItemList = DatabaseNonAut.GetFoods();

            foreach (var foodItem in foodItemList)
            {
                Image foodImage = await ImageDownloader.LoadImageAsync(foodItem.ImageURL);
                var menuItemControl = new MenuItemWithCheckboxControl(foodImage, foodItem.FoodName, foodItem.FoodPrice, foodItem.FoodCode);

                flowLayoutPanelMenuItems.Controls.Add(menuItemControl);
            }

        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetInfoButton_Click(object sender, EventArgs e)
        {
            var selectedItems = new List<MenuItemWithCheckboxControl>();
            decimal totalPrice = 0m;

            foreach (Control control in flowLayoutPanelMenuItems.Controls)
            {
                if (control is MenuItemWithCheckboxControl item && item.IsChecked())
                {
                    selectedItems.Add(item);

                    // 가격 누적
                    totalPrice += item.FoodPrice;
                }
            }

            Console.WriteLine("Selected items:");
            foreach (var item in selectedItems)
            {
                Console.WriteLine($"Name: {item.FoodName}, Price: {item.FoodPrice}");
            }

            Console.WriteLine($"Total Price: {totalPrice}");

            // SeatID 변수를 사용하여 주문 정보를 DB에 저장
            foreach (var item in selectedItems)
            {
                DatabaseAut.AddOrder(DatabaseAut.GetFoodCode(item.FoodName), SeatID); // SeatID 변수 사용
            }
            /*
            // Payment Form 열기 (필요에 따라 주석 처리하세요)
            using (UserInterFacePayment payment = new UserInterFacePayment())
            {
                payment.SetPrice((int)totalPrice);
                payment.ShowDialog();
            }
            */
            UserInterFacePayment userInterFacePayment = new UserInterFacePayment(SeatID);
            userInterFacePayment.ShowDialog();
            this.Close();
        }
    }
}
