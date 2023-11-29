using Form.Page.ResDetail;
using HandyControl.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
using 餐厅管理系统.database;

namespace Form.Page.UserMain
{
    /// <summary>
    /// UserMainView.xaml 的交互逻辑
    /// </summary>
    public partial class UserMainView : UserControl
    {
        public UserMainView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string keyword = txtCtx.Text.Trim();
            string mod = cmbType.SelectionBoxItem as string;
            // 创建数据库上下文实例，并在Restaurant数据库中查询
            using (var context = new RestaurantDb())
            {
                switch (mod)
                {
                    case "综合":
                        break;
                    case "距离":
                        break;
                    case "星级":
                        var restaurants = context.Restaurants
                        .Where(r => r.Name.Trim().Contains(keyword))
                        .OrderByDescending(r => r.Rate).ToList();
                        // 将查询结果绑定到 UI 控件，比如 DataGridView
                        dgRes.ItemsSource = restaurants;
                        break;
                    default:
                        Growl.InfoGlobal("请选择搜索模式");
                        break;
                }
            }
        }

        private void Detail(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            new ResDetailView(btn.CommandParameter).ShowDialog();
        }

        private void Location(object sender, RoutedEventArgs e)
        {
            List<double> location = new List<double>();
            location = 餐厅管理系统.util.Location.GetLocationProperty();
            if (location != null)
            {
                double userLatitude = location[0];
                double userLongitude = location[1];
                Growl.InfoGlobal($"userLatitude is {userLatitude},userLatitude is {userLatitude}");
            }
            else
            {
                Growl.InfoGlobal("获取位置失败，请查看是否授权");
            }
        }
    }
}
