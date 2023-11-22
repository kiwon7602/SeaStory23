using System;
using System.Globalization;
using System.Windows.Forms;

namespace SeaStory.ui
{
    public partial class UserInterFacePayment : Form
    {
        public UserInterFacePayment()
        {
            InitializeComponent();
        }

        public void SetPrice(int n)
        {
            labelPrice.Text = n.ToString("C", new CultureInfo("ko-KR"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessPayment();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessPayment();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProcessPayment();
        }

        private void ProcessPayment()
        {
            MessageBox.Show("결제되었습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
