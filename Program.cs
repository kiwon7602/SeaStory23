using SeaStory.ui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaStory
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //시작점과 동시에 폼 생성이 아닌
            //폼 생성 후 시작점으로하면 폼조작이 유연하게 됨
            //ex)폼에서 폼 이동간에 부모 폼을 지우고 자식폼만 남기려는 경우(로그인->자리선택)
            //(new login()).Show();
            Application.Run(new login());
        }
    }
}
