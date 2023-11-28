using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 餐厅管理系统.util;
using 餐厅管理系统.winForm;

namespace 餐厅管理系统.controls
{
    public partial class DishDetail : UserControl
    {
        public DishDetail()
        {
            InitializeComponent();
        }

        private string _imageName;
        private Image _image;
        private string _dishName;
        private double _price;

        public string ImageName
        {
            set 
            { 
                _imageName = value;
                _image = ResInfo.GetImage(value, 1);
                pictureBox1.Image = _image;
            }
        }
        public void SetBarColor(Color color)
        {
            bunifuSeparator2.LineColor = color;
        }
        public string DishName
        {
            set { _dishName = value; ControlDishName.Text = value; }
        }
        public double Price
        {
            set { _price = value; ControlPrice.Text = value.ToString(); }
        }

    }
}
