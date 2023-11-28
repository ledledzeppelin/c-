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
    public partial class DishDetailEditable : UserControl
    {
        public DishDetailEditable(FormResMain formResMain)
        {
            InitializeComponent();
            _formResMain = formResMain;
        }
        private int _dishId;
        private string _resName;
        private string _imageName;
        private Image _image;
        private string _dishName;
        private double _price;
        private FormResMain _formResMain;
        public void ReleaseResources()
        {
            // 在这里释放 PictureBox 的图片资源
            pictureBox1?.Image?.Dispose();
        }
        public int DishId
        {
            set { _dishId = value; }
        }

        public string ResName
        {
            set { _resName = value; }
        }
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

        // 编辑菜品
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // 弹出编辑菜品的窗口
            FormEditDish formEditDish = new FormEditDish(_dishId,_resName, _imageName, _image, _dishName, _price.ToString(),_formResMain);
            formEditDish.ShowDialog();
        }
    }
}
