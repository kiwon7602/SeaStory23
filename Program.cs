using SeaStory.Model;
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
        static void Main(string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Synchronously initialize ClientWrapper
            // var clientWrapper = ClientWrapper.Instance.GetAwaiter().GetResult();

            //시작점과 동시에 폼 생성이 아닌
            //폼 생성 후 시작점으로하면 폼조작이 유연하게 됨
            //ex)폼에서 폼 이동간에 부모 폼을 지우고 자식폼만 남기려는 경우(로그인->자리선택)
            // (new login()).Show();
            // Application.Run();
            //부모폼을 생성하고 숨기는 경우의 동작
            //동작 방식은 다르지만 결과는 같으므로 주석처리함
            Application.Run(new login());
        }
    }
}
