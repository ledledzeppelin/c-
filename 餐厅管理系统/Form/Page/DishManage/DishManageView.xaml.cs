using Form.Config;
using Form.Page.AddDishWindow;
using Form.Page.DishDetail;
using HandyControl.Controls;
using Microsoft.EntityFrameworkCore;
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
using 餐厅管理系统.data;
using 餐厅管理系统.database;

namespace Form.Page.DishManage
{
    /// <summary>
    /// DishManageView.xaml 的交互逻辑
    /// </summary>
    public partial class DishManageView : UserControl
    {
        public DishManageView()
        {
            InitializeComponent();
            LoadDishMenu();
        }
        public async void LoadDishMenu()
        {
            var res = (from p in Boot.DB.Dishes
                       join q in Boot.DB.Restaurants on p.RestaurantId equals q.RestaurantId into pq
                       from r in pq.DefaultIfEmpty()
                       select new
                       {
                           Id = p == null ? 0 : p.DishId,
                           Name = p == null ? "" : p.Name,
                           DisPicture = p == null ? "" : p.DisPicture,
                           Price = p == null ? 0 : p.Price,
                           ResName = r == null ? "" : r.Name,
                       }).ToList();
            dgdDishMenu.ItemsSource = res;
        }
        private void Add(object sender, RoutedEventArgs e)
        {
            new AddDishWndView().ShowDialog();
            LoadDishMenu();
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var ds = btn.CommandParameter as dynamic;
            int id = Convert.ToInt32(ds.Id);
            Boot.DB.Dishes.Remove(new Dish { DishId = id });
            Boot.DB.SaveChanges();
            LoadDishMenu();
        }

        private void Detail(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            new DishDetailView(btn.CommandParameter).ShowDialog();
        }
    }
}
