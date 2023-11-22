using MetroFramework.Controls;
using MetroFramework.Forms;
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
//using static System.Net.Mime.MediaTypeNames;

namespace 餐厅管理系统.winForm
{
    public partial class FormResDetailClient : MetroForm
    {
       
        public FormResDetailClient(int resId)
        {
            restaurantId = resId;
            //调试，添加一个菜品
            //ResInfo.AddDishForRestaurant(2, "2", "11.jpg", 648, 1);
            InitializeComponent();
            InitializeUI();
            InitializePanelDish();
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

                foreach (var dish in restaurant.Menu)
                {
                    // 获取菜品图片路径
                    string imagePath = ResInfo.GetImagePath(dish.DisPicture, 1);
                    // 创建 PictureBox 控件显示图片
                    PictureBox pictureBox = new PictureBox
                    {
                        Image = Image.FromFile(imagePath),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Width = 100, // 根据需要设置宽度
                        Height = 100, // 根据需要设置高度
                    };

                    // 创建 Label 控件显示菜品名
                    Label label = new Label
                    {
                        Text = dish.Name,
                        TextAlign = ContentAlignment.MiddleCenter,
                    };

                    // 创建 Panel 控件用于容纳图片和菜品名
                    Panel dishPanel = new Panel
                    {
                        Width = pictureBox.Width,
                        Height = pictureBox.Height + label.Height,
                    };

                    // 添加控件到 Panel 中
                    dishPanel.Controls.Add(pictureBox);
                    dishPanel.Controls.Add(label);

                    // 将 Panel 添加到你的主 Panel（用于显示所有菜品的 Panel）中
                    metroPanelDish.Controls.Add(dishPanel);
                
                
                }
            }
        }

        
    }
}
