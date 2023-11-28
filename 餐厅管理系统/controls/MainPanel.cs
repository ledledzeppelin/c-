using Bunifu.UI.WinForms;
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

namespace 餐厅管理系统.controls
{
    public partial class MainPanel : UserControl
    {
        public MainPanel()
        {
            InitializeComponent();
        }
        private string _userName;
        private string _nickName;
        private Image _myProfileImage;
        private string _address;

        public string Address
        {
            set { _address = value; myInfo1.Address = value; }
        }

        public string UserName
        {
            set { _userName = value; }
        }
        public string NickName
        {
            set { _nickName = value; myInfo1.NickName = value; }
        }
        public Image MyProfileImage
        {
            get { return _myProfileImage; }
            set { _myProfileImage = value; myInfo1.Image = value; }
        }

        private void bunifuButtonMine_Click(object sender, EventArgs e)
        {
            bunifuPanelMain.Visible = false;
            myInfo1.Visible = true;
        }

        private void bunifuButtonMain_Click(object sender, EventArgs e)
        {
            bunifuPanelMain.Visible = true;
            myInfo1.Visible = false;
        }
        //初始化餐厅列表
        public void InitializeRes()
        {
            using (var context = new RestaurantDb())
            {
                var restaurants = context.Restaurants
                    .OrderByDescending(r => r.Rate)
                    .ToList();

                foreach (Restaurant restaurant in restaurants)
                {
                    AddRestaurantToFlowLayOut(restaurant);
                }
            }
        }

        // 显示搜索结果
        private void bunifuSearchButton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            string keyword = bunifuTextBox1.Text.Trim();
            using (var context = new RestaurantDb())
            {
                var restaurants = context.Restaurants.ToList()
                        .Where(r => r.Name.Trim().Contains(keyword))
                        .OrderByDescending(r => r.Rate)
                        .ToList();
                
                
                foreach(Restaurant restaurant in restaurants)
                {
                    AddRestaurantToFlowLayOut(restaurant);
                }
            }
        }
        // 向FlowLayOutPanel添加餐厅条目
        private void AddRestaurantToFlowLayOut(Restaurant restaurant)
        {
            ResDetail resDetail = new ResDetail();
            resDetail.Title = restaurant.Name;
            resDetail.Address = restaurant.Address;
            resDetail.Rate = restaurant.Rate;
            resDetail.RestaurantId = restaurant.RestaurantId;
            resDetail.UserName = _userName;
            string imageFile = restaurant.ResPicture;
            Image image = ResInfo.GetImage(imageFile, 0);
            resDetail.Image = image;
            flowLayoutPanel1.Controls.Add(resDetail);
        }
        // 初始化控件，显示“主页”隐藏“我的”
        private void MainPanel_Load(object sender, EventArgs e)
        {
            bunifuPanelMain.Visible = true;
            myInfo1.Visible = false;
        }
    }
}
