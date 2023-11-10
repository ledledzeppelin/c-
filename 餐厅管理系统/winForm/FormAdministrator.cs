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

namespace 餐厅管理系统
{
   
    public partial class FormAdministrator : Form
    {
        public FormAdministrator()
        {
            InitializeComponent();
            //初始化数据库

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }

        

        
        RestaurantDb restaurantDb = new RestaurantDb();
        ReviewDb reviewDb = new ReviewDb();
        UserDb userDb = new UserDb();
        ApplyDb ApplyDb = new ApplyDb();

        private void dataGridViewload<T>(List<T> itemList)
        {
            dataGridView1.DataSource = itemList;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)   //下拉选项框，用于显示数据表
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    //已提交待审核的餐厅申请
                    var apply = ApplyDb.Resapplys.ToList(); ;   
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
                    var reviews = reviewDb.Reviews.ToList();
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


        //删除申请并添加餐厅，完成对餐厅的审核
        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0)
            {
               
                var selectedDish = dataGridView1.SelectedRows[0].DataBoundItem as Restaurant;  //获取对象，selectDish即为对象
                int id = selectedDish.RestaurantId;
                ApplyDb.DeleteResapply(id);
                restaurantDb.AddRestaurant(selectedDish);
            }
        }





        private void button2_Click(object sender, EventArgs e)   //删除按钮，用于删除已选选项
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        var selectedDish = dataGridView1.SelectedRows[0].DataBoundItem as Restaurant;  //获取对象，selectDish即为对象
                        int id = selectedDish.RestaurantId;
                        ApplyDb.DeleteResapply(id);  //删除对象
                    }
                    else { MessageBox.Show("请选择相应的菜"); }
                    break;
                case 1:
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        var selectedDish = dataGridView1.SelectedRows[0].DataBoundItem as Restaurant;
                        int id = selectedDish.RestaurantId;
                        restaurantDb.DeleteRestaurant(id);
                    }
                    else { MessageBox.Show("请选择相应的菜"); }
                    break;
                case 2:
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        var selectedDish = dataGridView1.SelectedRows[0].DataBoundItem as Review;
                        int id = selectedDish.ReviewId;
                        reviewDb.DeleteReview(id);
                    }
                    else
                    {
                        MessageBox.Show("请选择相应的菜");
                    }
                        break;
                case 3:
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        var selectedDish = dataGridView1.SelectedRows[0].DataBoundItem as User;
                        int id = selectedDish.Id;
                        userDb.DeleteUser(id);
                    }
                    else { MessageBox.Show("请选择相应的菜"); }
                    break;
            }
        }

        private void FormAdministrator_Load(object sender, EventArgs e)
        {

        }

        
    }

    
}