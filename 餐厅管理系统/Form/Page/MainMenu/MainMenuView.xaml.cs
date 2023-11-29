using Form.Control;
using Form.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Form.Page.MainMenu
{
    /// <summary>
    /// TestView.xaml 的交互逻辑
    /// </summary>
    public partial class MainMenuView: Window
    {
        public MainMenuView()
        {
            InitializeComponent();
        }

        public void InitMenu(List<MenuItemModel> menuItemModels)
        {
            menuItemModels.ForEach(x =>
            {
                stkMenu.Children.Add(new MenuItem
                {
                    Text = x.Name,
                    Click = () =>
                    {
                        foreach(MenuItem mi in stkMenu.Children)
                        {
                            mi.IsSelect = false;
                        }
                        x.Click();
                    },
                    IsSelect = x.IsSelect
                });
            });
        }

    }
}