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
using System.Windows.Shapes;
using 餐厅管理系统.database;

namespace Form.Page.ResDetail
{
    /// <summary>
    /// ResDetailView.xaml 的交互逻辑
    /// </summary>
    public partial class ResDetailView : Window
    {
        dynamic ResDetail;
        public ResDetailView(dynamic dc)
        {
            InitializeComponent();
            ResDetail = dc;
            this.txtName.Text = Convert.ToString(dc.Name);
            this.txtRate.Text = string.Format("{0:N2}", dc.Rate);
            this.igv.ImageSource = BitmapFrame.Create(new Uri(Convert.ToString(dc.ResPicture)));
            LoadDishMenu();
        }
        public void LoadDishMenu()
        {
            using (DishDb db = new DishDb())
            {
                int id = ResDetail.RestaurantId;
                dgdDishMenu.ItemsSource = db.Dishes.Where(x => x.RestaurantId == id).ToList();
            }
        }
        private void Detail(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            new DishDetailView(btn.CommandParameter).ShowDialog();
        }
    }
}
