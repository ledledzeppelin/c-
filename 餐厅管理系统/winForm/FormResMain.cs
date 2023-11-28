using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 餐厅管理系统.data;
using 餐厅管理系统.database;
using 餐厅管理系统.util;
using Microsoft.EntityFrameworkCore;
using 餐厅管理系统.controls;

namespace 餐厅管理系统.winForm
{
    // 商家登录后跳转到此页面，可以编辑基本信息，上传、删除、添加菜品
    public partial class FormResMain : MetroForm
    {
        public FormResMain(Restaurant res)
        {
            InitializeComponent();
            this.res = res;
            pictureBox1.Image = ResInfo.GetImage(res.ResPicture, 0);
            bunifuLabel3.Text = res.Name;
            bunifuLabel4.Text = res.Address;
            LoadDish();
        }
        // 释放图片资源
        public void ClearPictureResources()
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is DishDetailEditable dishDetailEditable)
                {
                    // 释放图片资源
                    dishDetailEditable.ReleaseResources();
                }
            }
        }
        // 加载菜品详情
        public void LoadDish()
        {
            flowLayoutPanel1.Controls.Clear();
            using (var context = new RestaurantDb())
            {

                var restaurantWithMenu = context.Restaurants
                         .Include(r => r.Menu)
                         .FirstOrDefault(r => r.RestaurantId == res.RestaurantId);
                if (restaurantWithMenu != null)
                {
                    var menuItems = restaurantWithMenu.Menu.ToList();
                    foreach (var menuItem in menuItems)
                    {
                        // 设置菜品名、图片、价格
                        DishDetailEditable detail = new DishDetailEditable(this);
                        detail.DishId = menuItem.DishId;
                        detail.ResName = res.Name.ToString();
                        detail.DishName = menuItem.Name;
                        detail.ImageName = menuItem.DisPicture;
                        detail.Price = menuItem.Price;
                        detail.SetBarColor(Color.Orange);
                        flowLayoutPanel1.Controls.Add(detail);
                    }
                }
            }
        }     
        // 添加完菜品后更新界面
        public void RefreshDish(Dish dish)
        {
            // 设置菜品名、图片、价格
            DishDetailEditable detail = new DishDetailEditable(this);
            detail.DishId = dish.DishId;
            detail.ResName= res.Name.ToString();    
            detail.DishName = dish.Name;
            detail.ImageName = dish.DisPicture;
            detail.Price = dish.Price;
            detail.SetBarColor(Color.Orange);
            flowLayoutPanel1.Controls.Add(detail);
        }
        // 餐厅对象
        private Restaurant res;

        // 退出登录
        private void lo1gOut1_Click(object sender, EventArgs e)
        {
            // 隐藏当前窗体并显示登录窗体
            //MessageBox.Show("11");
            FormLogin form = new FormLogin();
            this.Hide();
            form.Show();
            this.Dispose();
        }

        
        // 退出登录
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }
        // 当鼠标进入退出登录图片时，将鼠标形状设置为手掌
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        // 当鼠标离开退出登录图片时，将鼠标形状恢复为默认
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        // 删除菜品
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        // 添加菜品
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormAddDish formAddDish = new FormAddDish(res.RestaurantId,res.Name,this);
            formAddDish.Show();
        }
       
    }
}
