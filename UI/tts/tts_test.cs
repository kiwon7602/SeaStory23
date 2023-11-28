using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace SeaStory.UI.tts
{
    public partial class tts_test : Form
    {
        public tts_test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\admin\Documents\GitHub\SeaStory23\UI\tts\audio_0_번_좌석을_선택하셨습니다_.wav");
            simpleSound.Play();
        }
    }
}
