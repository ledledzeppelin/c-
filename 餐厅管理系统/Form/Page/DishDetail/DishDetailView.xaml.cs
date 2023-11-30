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

namespace Form.Page.DishDetail
{
    /// <summary>
    /// DishDetailView.xaml 的交互逻辑
    /// </summary>
    public partial class DishDetailView : Window
    {
        public DishDetailView(dynamic ds)
        {
            InitializeComponent();
            this.txtName.Text = Convert.ToString(ds.Name);
            this.txtPrice.Text = string.Format("{0:N2}", ds.Price);
            this.igv.ImageSource = BitmapFrame.Create(new Uri(Convert.ToString(ds.DisPicture)));
        }
    }
}
