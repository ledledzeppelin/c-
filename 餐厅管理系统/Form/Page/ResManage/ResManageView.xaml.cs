using Form.Config;
using Form.Page.AddDishWindow;
using Form.Page.DishDetail;
using Form.Page.ResDetail;
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

namespace Form.Page.ResManage
{
    /// <summary>
    /// ResManageView.xaml 的交互逻辑
    /// </summary>
    public partial class ResManageView : UserControl
    {
        public ResManageView()
        {
            InitializeComponent();
            LoadResMenu();
        }
        public async void LoadResMenu()
        {
            var res = Boot.DB.Restaurants.ToList();
            dgdMenu.ItemsSource = res;
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var ds = btn.CommandParameter as Restaurant;
            Boot.DB.Restaurants.Remove(ds);
            Boot.DB.SaveChanges();
            LoadResMenu();
        }

        private void Detail(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            new ResDetailView(btn.CommandParameter).ShowDialog();
        }
    }
}
