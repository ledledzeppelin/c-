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
        public string UserName
        {
            set { _userName = value; }
        }

        private List<Restaurant> _restaurants;

        private void bunifuButtonMine_Click(object sender, EventArgs e)
        {
            bunifuPanelMain.Visible = false;
            panelMine.Visible = true;
        }

        private void bunifuButtonMain_Click(object sender, EventArgs e)
        {
            bunifuPanelMain.Visible = true;
            panelMine.Visible = false;
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
            string filePath = ResInfo.GetImagePath(imageFile, 0);
            Image image = Image.FromFile(filePath);
            resDetail.Image = image;
            flowLayoutPanel1.Controls.Add(resDetail);
        }
    }
}
