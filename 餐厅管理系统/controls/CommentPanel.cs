using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 餐厅管理系统.database;
using 餐厅管理系统.util;

namespace 餐厅管理系统.controls
{
    public partial class CommentPanel : UserControl
    {
        public CommentPanel()
        {
            InitializeComponent();
        }
        /**
         * 等待用户输入的属性
         */
        private string _comment;
        private int _rate;
        /**
        * 初始化该控件时需要提供以下参数
        * 账号
        * 餐厅ID
        * 昵称
        * 头像
        * 评分
        */
        private string _userName;
        private int _restaurantId;
        private string _nickName;
        private Image _image;
        

        public string Comment
        {
            get {return _comment; }
            set { _comment = value; ControlMyComment.Text = value; }
        }

        public string NickName
        {
            get { return _nickName; }
            set { _nickName = value; ControlNickName.Text = value; }
        }
        public Image Image 
        { 
            get { return _image; }
            set { _image = value; ControlImage.Image = value; }
        }

        public int Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }
        public string UserName
        {
            set { _userName = value; }
        }
        public int RestaurantId
        {
            set { _restaurantId = value; }
        }

        public void AddComment(string nickName,string comment,int rate,Image image)
        {
            CommentControl commentControl = new CommentControl();
            commentControl.Image = image;
            commentControl.NickName = nickName;
            commentControl.Comment = comment;
            commentControl.Rate = rate;

            flowLayoutPanel1.Controls.Add(commentControl);
        }

        private void ControlMyComment_MouseEnter(object sender, EventArgs e)
        {

        }

        private void ControlMyComment_MouseClick(object sender, MouseEventArgs e)
        {
            bunifuTextBox1.Visible = true;
            ControlMyComment.Visible = false;
        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            ControlMyComment.Text = bunifuTextBox1.Text;
            _comment = bunifuTextBox1.Text;
        }

        private void ControlSubmit_Click(object sender, EventArgs e)
        {
            //提交自己的评论到数据库

            if(bunifuTextBox1.Text == "")
            {
                MessageBox.Show("请添加评论后再点击提交");
            }
            else
            {
                using (var context = new RestaurantDb())
                {
                    Review myReview = new Review
                    {
                        UserId = _userName,
                        RestaurantId = _restaurantId,
                        Comment = _comment,
                        Rating = _rate
                    };
                    // 调用 AddComment 方法将评论添加到数据库
                    ResInfo.AddCommentToDb(myReview);
                    //bunifuTextBox1.Text = "";
                    //LabelRate.Text = "";
                }
            }
            AddComment(_nickName, _comment, _rate, _image);
            
        }
        // 设置评分
        private void LabelRate_TextChange(object sender, EventArgs e)
        {
            _rate = int.Parse(LabelRate.Text);
        }
    }
}
