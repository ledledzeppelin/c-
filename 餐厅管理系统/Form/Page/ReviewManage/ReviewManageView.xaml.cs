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
using 餐厅管理系统.data;

namespace Form.Page.ReviewManage
{
    /// <summary>
    /// ReviewManageView.xaml 的交互逻辑
    /// </summary>
    public partial class ReviewManageView : UserControl
    {
        public ReviewManageView()
        {
            InitializeComponent();
            LoadReviewhMenu();
        }
        public async void LoadReviewhMenu()
        {

        }

        private void Delete(object sender, RoutedEventArgs e)
        {

            LoadReviewhMenu();
        }

    }
}
