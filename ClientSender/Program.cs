using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSender
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
            bool isCanCreateNew;
            using (var mutex = new Mutex(true, Application.ProductName, out isCanCreateNew))
            {
                if (isCanCreateNew)
                {
                    Application.Run(new Sender());
                }
                else
                {
                    MessageBox.Show(Application.ProductName + "程序已经在运行！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
