using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleAppForKurabo
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IMainTopController controller = new MainTopController();
            IMainTopView view = new MainTop();
            IMainTopModel model = new MainTopModel();

            controller.View = view;
            controller.Model = model;

            view.SetEventHandler(controller);     
            
            Application.Run((Form)view);
        }
    }
}
