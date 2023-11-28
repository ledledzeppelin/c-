using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 餐厅管理系统.controls
{
    public partial class IconAndDiscription : UserControl
    {
        public IconAndDiscription()
        {
            InitializeComponent();
        }
        private Image _image;
        private string _label;
        public string Label
        {
            get { return _label; }
            set { _label = value; bunifuLabel1.Text = value; }
        }
        public Image Image
        {
            get { return _image; }
            set { _image = value; pictureBox1.Image = value; }
        }
    }
}
