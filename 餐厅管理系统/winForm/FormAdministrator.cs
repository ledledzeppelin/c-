using MetroFramework.Forms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using 餐厅管理系统.data;
using 餐厅管理系统.database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace 餐厅管理系统
{
    
    public partial class FormAdministrator : MetroForm
    {
        public FormAdministrator()
        {
            InitializeComponent();
            // 初始化数据库

            // 设置 DataGridView 的选择模式
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // ...

        RestaurantDb restaurantDb = new RestaurantDb();

        UserDb userDb = new UserDb();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 下拉选项框，用于显示数据表
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    // 已提交待审核的餐厅申请
                    var apply = restaurantDb.ResApplys.ToList();
                    dataGridViewload(apply);
                    button1.Visible = true;
                    break;
                case 1:
                    // 显示餐厅数据
                    var restaurants = restaurantDb.Restaurants.ToList();
                    dataGridViewload(restaurants);
                    button1.Visible = false;
                    break;
                case 2:
                    // 显示评论数据
                    var reviews = restaurantDb.Reviews.ToList();
                    dataGridViewload(reviews);
                    button1.Visible = false;
                    break;
                case 3:
                    // 显示用户数据
                    var users = userDb.Users.ToList();
                    dataGridViewload(users);
                    button1.Visible = false;
                    break;
            }
        }


        private void dataGridViewload<T>(List<T> itemList)
        {
            dataGridView1.DataSource = itemList;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        // 获取选定的餐厅申请
                        var selectedDish = dataGridView1.SelectedRows[0].DataBoundItem as ResApply;
                        if (selectedDish != null)
                        {
                            int id = selectedDish.ResApplyId;
                            Restaurant re = new Restaurant();
                            re.Name = selectedDish.Name;
                            re.Address = selectedDish.Address;
                            re.Account = selectedDish.Account;
                            re.Password = selectedDish.Password;
                            re.ResPicture = selectedDish.ResPicture;
                            // 删除申请并添加餐厅
                            restaurantDb.DeleteResApply(id);
                            restaurantDb.AddRestaurant(re);
                        }
                    }
                    else
                    {
                        MessageBox.Show("请选择相应的菜");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"处理请求时出错: {ex.Message}");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        // 删除餐厅申请
                        if (dataGridView1.SelectedRows.Count > 0)
                        {
                            var selectedDish = dataGridView1.SelectedRows[0].DataBoundItem as Restaurant;
                            if (selectedDish != null)
                            {
                                using(RestaurantDb applyDb = new RestaurantDb())
                                {
                                    int id = selectedDish.RestaurantId;
                                    applyDb.DeleteResApply(id);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("请选择相应的菜");
                        }
                        break;
                    case 1:
                        // 删除餐厅
                        if (dataGridView1.SelectedRows.Count > 0)
                        {
                            var selectedDish = dataGridView1.SelectedRows[0].DataBoundItem as Restaurant;
                            if (selectedDish != null)
                            {
                                using (RestaurantDb restaurantDb = new RestaurantDb())
                                {
                                    int id = selectedDish.RestaurantId;
                                    restaurantDb.DeleteRestaurant(id);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("请选择相应的菜");
                        }
                        break;
                    case 2:
                        // 删除评论
                        if (dataGridView1.SelectedRows.Count > 0)
                        {
                            var selectedDish = dataGridView1.SelectedRows[0].DataBoundItem as Review;
                            if (selectedDish != null)
                            {
                                using (RestaurantDb reviewDb = new RestaurantDb())
                                {
                                    int id = selectedDish.ReviewId;
                                    reviewDb.DeleteReview(id);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("请选择相应的菜");
                        }
                        break;
                    case 3:
                        // 删除用户
                        if (dataGridView1.SelectedRows.Count > 0)
                        {
                            var selectedDish = dataGridView1.SelectedRows[0].DataBoundItem as User;
                            if (selectedDish != null)
                            {
                                using(UserDb userDb = new UserDb())
                                {
                                    int id = selectedDish.Id;
                                    userDb.DeleteUser(id);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("请选择相应的菜");
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"处理请求时出错: {ex.Message}");
            }
        }

        private void FormAdministrator_Load(object sender, EventArgs e)
        {

        }
    }
    
}