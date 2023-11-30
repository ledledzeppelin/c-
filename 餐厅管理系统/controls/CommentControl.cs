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

namespace 餐厅管理系统
{
    public partial class CommentControl : UserControl
    {
        public CommentControl()
        {
            InitializeComponent();
        }

        private string _nickName;
        private string _comment;
        private Image _image;
        private int _rate;
        public int Rate
        {
            set 
            { 
                _rate = value; 
                ResInfo.SetRatePicture(ControlRate, value); 
            }
        }

        public string NickName
        {
            get { return _nickName; }
            set { _nickName = value; userNickName.Text = value; }
        }

        public string Comment
        {
            get { return _comment; }
            set { _comment = value; labelComment.Text = value; }
        }

        public Image Image
        {
            get { return _image; }
            set { _image = value; pictureBox1.Image = value; }
        }

        
    }
}
