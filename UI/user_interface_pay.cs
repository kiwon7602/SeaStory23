using SeaStory.Model;
using System;
using System.Globalization;
using System.Windows.Forms;
using System.Media;
namespace SeaStory.ui
{
    public partial class UserInterFacePayment : Form
    {
        private string SeatID;
        public UserInterFacePayment(string seat)
        {
            SeatID = seat;
            InitializeComponent();
        }

        public void SetPrice(int n)
        {
            labelPrice.Text = n.ToString("C", new CultureInfo("ko-KR"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Administrator\Desktop\깃허브\SeaStory23\UI\tts\신용카드.wav");
            simpleSound.Play();
            ProcessPayment();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Administrator\Desktop\깃허브\SeaStory23\UI\tts\페이코.wav");
            simpleSound.Play();
            ProcessPayment();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Administrator\Desktop\깃허브\SeaStory23\UI\tts\현금.wav");
            simpleSound.Play();
            ProcessPayment();
        }

        private void ProcessPayment()
        {
            MessageBox.Show("결제되었습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        //주문취소 버튼 클릭 시
        private void button4_Click(object sender, EventArgs e)
        {
            //해당 좌석의 주문을 주문목록에서 지움
            DatabaseAut.DeleteOrder(SeatID);
            MessageBox.Show("주문이 취소되었습니다.", "주문 취소", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
    }
}
