using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Design;
using Sunny.UI;
using 餐厅管理系统.database;
using 餐厅管理系统.winForm;

namespace 餐厅管理系统
{
    internal static class Program
    {
        public static MainDb DB = null;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            DB = new MainDb();
            //Application.Run(new FormLogin());
            Application.Run(new FormMultLogin());
        }
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = e.ExceptionObject as Exception;
            new Form().ShowErrorDialog(ex.Message);
        }
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            new Form().ShowErrorDialog(e.Exception.Message);
        }
    }
}
