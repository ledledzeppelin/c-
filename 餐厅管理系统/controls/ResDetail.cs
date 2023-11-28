using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 餐厅管理系统.database;
using 餐厅管理系统.util;
using 餐厅管理系统.winForm;

namespace 餐厅管理系统.controls
{
    public partial class ResDetail : UserControl
    {
        public ResDetail()
        {
            InitializeComponent();
        }
        // 餐厅图片 餐厅名字 餐厅地址 需要显示在控件上
        private Image _image;
        private string _title;
        private string _address;
        private float _rate;
        // 记录餐厅id，为跳转到商家详情做准备
        private int _restaurantId;
        private string _userName;

        public Image Image 
        { 
            get { return _image; } 
            set {  _image = value; pictureBox1.Image = value; } 
        }  
        public string Title
        {
            get { return _title; }
            set { _title = value; ControlResName.Text = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; ControlResAddress.Text = value; }
        }
        public float Rate
        {
            get { return _rate; }
            set 
            { 
                _rate = value; 
                ControlRate.Text = value.ToString();
                // 显示星级图片
                ResInfo.SetRatePicture(ControlRateImage, value);
            }
        }
        public int RestaurantId
        {
            set { _restaurantId = value; }
        }
        public string UserName
        {
            set { _userName = value; }
        }


        // 双击控件跳转到商家详情界面
        public event EventHandler ResDetailDoubleClick;
        private void ResDetail_DoubleClick(object sender, EventArgs e)
        {
            //ResDetailDoubleClick?.Invoke(this, EventArgs.Empty);
            FormResDetailClient myform = new FormResDetailClient(_restaurantId, _userName,_rate);   // 调用带参的构造函数
            
            this.ParentForm.Hide();
            myform.ShowDialog();
            this.ParentForm.Dispose();

        }
    }
}
