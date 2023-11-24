using Bunifu.UI.WinForms;
using MetroFramework.Controls;
using MetroFramework.Forms;
using MetroFramework.Drawing;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 餐厅管理系统.data;
using 餐厅管理系统.database;
using 餐厅管理系统.util;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using 餐厅管理系统.controls;
using System.IO;
using System.Net.PeerToPeer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Contexts;
//using static System.Net.Mime.MediaTypeNames;


namespace 餐厅管理系统.winForm
{
    public partial class FormResDetailClient : MetroForm
    {
        // 用户账号
        private string userName;
        // 用户昵称
        private string nickName;
        public FormResDetailClient(int resId,string userName)
        {

            this.userName = userName;
            //this.AutoScroll = true;
            restaurantId = resId;
            InitializeComponent();
            InitializeUI();
            InitializePanelDish();
            InitializeReview(restaurantId, commentPanel1);
            //commentPanel1.Controls.Add(bunifuButtonSubmit);
        }

        private int restaurantId;
        private string resName;
        private float rate;
        private string address;
         private void InitializeUI()
         {
            //显示餐厅名
            resName = ResInfo.GetResName(restaurantId);
            MetroResName.Text = resName;
            //显示星级
            rate = ResInfo.GetResRate(restaurantId);
            ResInfo.DisplayStarRating(rate, pictureBoxRate);
            metroLabelRate.Text = rate.ToString();
            //显示地址
            address = ResInfo.GetAddress(restaurantId);
            metroLabelAddress.Text = address;

            //显示餐厅评论
            //ResInfo.LoadUserReviews(restaurantId);
        }
        // 初始化显示菜品的panel
        private void InitializePanelDish()
        {
            
            using (var context = new RestaurantDb())
            {   
                 // 获取某一餐厅的所有菜品
                var restaurant = context.Restaurants
                .Include(r => r.Menu)
                 .FirstOrDefault(r => r.RestaurantId == restaurantId);
                //MessageBox.Show(restaurant.Menu.Count.ToString());

                foreach (var dish in restaurant.Menu)
                {
                    // 获取菜品图片路径
                    string imagePath = ResInfo.GetImagePath(dish.DisPicture, 1);
                    // 创建 PictureBox 控件显示图片
                    PictureBox pictureBox = new PictureBox
                    {
                        //Name = dish.DishId;
                        Image = Image.FromFile(imagePath),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Width = 100, // 根据需要设置宽度
                        Height = 100, // 根据需要设置高度
                        Tag = dish, // 将菜品对象保存在 Tag 属性中
                    };

                    // 创建 Label 控件显示菜品名
                    Label label = new Label
                    {
                        Text = dish.Name,
                        TextAlign = ContentAlignment.MiddleCenter,
                        AutoSize = true, // 让 Label 自适应文本内容
                    };

                    // 创建 Panel 控件用于容纳图片和菜品名
                    Panel dishPanel = new Panel
                    {
                        Width = pictureBox.Width,
                        Height = pictureBox.Height + label.Height,
                    };
                    // 将 Label 显示在图片的正下方
                    label.Location = new Point((pictureBox.Width - label.Width) / 2, pictureBox.Height);

                    // 添加点击事件处理程序
                    pictureBox.Click += (sender, e) => OpenDishDetailsForm((Dish)((PictureBox)sender).Tag);
                    
                    // 添加鼠标进入事件处理程序
                    pictureBox.MouseEnter += (sender, e) => pictureBox.Cursor = Cursors.Hand;

                    // 添加鼠标离开事件处理程序
                    pictureBox.MouseLeave += (sender, e) => pictureBox.Cursor = Cursors.Default;

                    // 添加控件到 Panel 中
                    dishPanel.Controls.Add(pictureBox);
                    dishPanel.Controls.Add(label);

                    flowLayoutPanel2.Controls.Add(dishPanel);

                }
            }
        }
        // 跳转到菜品详情页面的方法
        private void OpenDishDetailsForm(Dish selectedDish)
        {
            // 在这里编写打开菜品详情页面的逻辑，可以使用 selectedDish 对象
            MessageBox.Show($"点击了菜品：{selectedDish.Name}");
            // 例如，打开新窗体：
            // DishDetailsForm dishDetailsForm = new DishDetailsForm(selectedDish);
            // dishDetailsForm.Show();
        }
        // 初始化评论板块
        private void InitializeReview(int restaurantId, CommentPanel commentPanel)
        {
            //初始化用户头像和昵称
            InitializeUser(commentPanel);
            using (var context = new RestaurantDb())
            {
                //获取review信息
                var reviews = context.Reviews
                    .Where(r => r.RestaurantId == restaurantId)
                    .ToList();
                // 将 reviews 加载到控件中
                DisplayReviews(reviews, commentPanel);
            }
        }
        private void InitializeUser(CommentPanel commentPanel)
        {
            using (var context = new UserDb())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == userName);
                string imagePath = ResInfo.GetImagePath(user.ProfilePicture, 2);
                //加载用户头像、昵称
                Image image = Image.FromFile(imagePath);
                string nickName = user.Nickname;
                commentPanel.Image = image;
                commentPanel.NickName = nickName;
                commentPanel.UserName = userName;
                commentPanel.RestaurantId = restaurantId;
            }
        }
        // 在这里编辑用户评价的控件
        private void DisplayReviews(List<Review> reviews, CommentPanel commentPanel)
        {
            using (var context = new UserDb())
            {
                string parentDirectory = Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName;
                string defaultImagePath = Path.Combine(parentDirectory, "resources", "用户默认头像.png");
                Image image = Image.FromFile(defaultImagePath);

                foreach (var review in reviews)
                {
                    // 获取用户头像图片名称
                    var userPic = context.Users
                        .Where(u => u.Username == review.UserId)
                        .Select(u => u.ProfilePicture)
                        .FirstOrDefault();
                    // 获取用户头像
                    if (userPic != null)
                    {
                        string imagePath = ResInfo.GetImagePath(userPic, 2);
                        image = Image.FromFile(imagePath);
                    }
                    // 获取用户昵称
                    var userNickName = context.Users
                        .Where(u => u.Username == (review.UserId))
                        .Select(u => u.Nickname)
                        .FirstOrDefault();
                    // 获取评分
                    int rate = review.Rating;
                    //获取评论
                    string comment = review.Comment;
                    //添加评论
                    commentPanel.AddComment(userNickName, comment, rate, image);
                }
            }
        }
        /**
        // 提交自己的评论(并发？)
        private void bunifuButtonSubmit_Click(object sender, EventArgs e)
        {
            
            //提交自己的评论到数据库
            string myComment = commentPanel1.Comment;
            int myRate = 5;
            int userId;
            using (var context = new UserDb())
            {
                var UserId = context.Users
                        .Where(u => u.Username == userName)
                        .Select(u => u.Id)
                        .FirstOrDefault();
                userId = UserId;
            }

            using (var context = new RestaurantDb())
            {
                Review myReview = new Review
                {
                    UserId = userName,
                    RestaurantId = restaurantId,
                    Comment = myComment,
                    Rating = myRate
                };
                // 调用 AddComment 方法将评论添加到数据库
                ResInfo.AddCommentToDb(myReview);
            }

            // 更新评论区控件的内容 (并发？)
            string nickName = ResInfo.GetUserNicknameByUserName(userName);
            //设置默认头像
            string parentDirectory = Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName;
            string defaultImagePath = Path.Combine(parentDirectory, "resources", "用户默认头像.png");
            Image image = Image.FromFile(defaultImagePath);
            using (var context = new UserDb())
            {
                var userPic = context.Users
                        .Where(u => u.Username == userName)
                        .Select(u => u.ProfilePicture)
                        .FirstOrDefault();
                if (userPic != null)
                {
                    string imagePath = ResInfo.GetImagePath(userPic, 2);
                    image = Image.FromFile(imagePath);
                }
            }
            commentPanel1.AddComment(nickName,myComment,myRate,image);
            
        }*/
    }
}
