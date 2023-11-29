using System;
using Stylet;
using StyletIoC;
using Form.Page.Login;
using Form.Page.MainMenu;
using 餐厅管理系统.database;

namespace Form.Config
{
    public class Boot : Bootstrapper<LoginViewModel>
    {
        public static IWindowManager Manager;
        public static IContainer IOC;
        public static MainDb DB;
        protected override void ConfigureIoC(IStyletIoCBuilder builder)
        {
            // Configure the IoC container in here
        }

        protected override void Configure()
        {
            // Perform any other configuration before the application starts
            IOC = this.Container;
            Manager = IOC.Get<IWindowManager>();
            DB = new MainDb();
        }
    }
}
