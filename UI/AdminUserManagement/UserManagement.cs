using Microsoft.VisualBasic.ApplicationServices;
using SeaStory.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SeaStory.Model.DataCalss;

namespace SeaStory.UI.AdminFoodManagement
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
            list_Update();
        }

        //정보 수정 버튼 클릭시
        private void button1_Click(object sender, EventArgs e)
        {
            //listview1에서 선택된 유저를 업데이트 하는 기능
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string ID = selectedItem.SubItems[0].Text;
                string NAME = selectedItem.SubItems[1].Text;
                string PW = selectedItem.SubItems[2].Text;
                string PHONE = selectedItem.SubItems[3].Text;
                

                // 업데이트 메소드 호출
                UserManagement_update userManagement_update = new UserManagement_update(ID, NAME, PW, PHONE);
                userManagement_update.ShowDialog();

                list_Update();
            }
            
        }
        //회원 삭제 버튼 클릭 시
        private void button2_Click(object sender, EventArgs e)
        {
            //listview1에서 선택된 주문을 삭제하는 기능
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string ID = selectedItem.SubItems[0].Text;
                

                // DelOrders 메소드 호출
                DatabaseAut.DeleteMember(ID);
                list_Update();
            }
        }

        private void list_Update()
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("ID", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("유저명", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("PW", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("전화번호", 200, HorizontalAlignment.Center);
            listView1.Columns.Add("잔여 시간", 200, HorizontalAlignment.Center);
            listView1.Columns.Add("사용 시간", 200, HorizontalAlignment.Center);
            List<User2> Users = DatabaseAut.GetAllMembers();

            // listView1에 주문 목록 추가
            foreach (User2 user in Users)
            {
                if (!(user.ID == "admin"))
                {
                    ListViewItem item = new ListViewItem(user.ID);
                    item.SubItems.Add(user.Name);
                    item.SubItems.Add(user.PW);
                    item.SubItems.Add(user.PhoneNumber);
                    item.SubItems.Add(Time_fomat(user.RemainingTime));
                    item.SubItems.Add(Time_fomat(user.UsedTime));
                    listView1.Items.Add(item);
                }
            }
        }

        //시간 표시 양식 함수
        private string Time_fomat(int time)
        {
            int hours = time / 3600;
            int minutes = (time % 3600) / 60;
            int seconds = time % 60;

            // 시간을 00:00:00 형태의 문자열로 변환
            string formattedTime = $"{hours:D2}:{minutes:D2}:{seconds:D2}";

            return formattedTime;
        }
    }

}
