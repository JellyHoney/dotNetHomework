using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 登录游戏大厅
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            login lg = new login();
            lg.ShowDialog();
            if(lg.id==0)
            {
                lg.Dispose();
                return;
            }
            else
            {
                int id = lg.id;
                lg.Dispose();
                Application.Run(new GameCenter(id));
            }
        }
    }
}
