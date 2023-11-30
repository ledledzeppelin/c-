using Form.Config;
using Form.Page.AddDishWindow;
using Form.Page.DishDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using 餐厅管理系统;
using 餐厅管理系统.data;

namespace Form.Page.UserManage
{
    /// <summary>
    /// UserManageView.xaml 的交互逻辑
    /// </summary>
    public partial class UserManageView : UserControl
    {
        public UserManageView()
        {
            InitializeComponent();
            LoadUserhMenu();
        }
        public async void LoadUserhMenu()
        {
            var res = Boot.DB.Users.ToList();
            dgdMenu.ItemsSource = res;
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var ds = btn.CommandParameter as User;
            Boot.DB.Users.Remove(ds);
            Boot.DB.SaveChanges();
            LoadUserhMenu();
        }
    }
}
