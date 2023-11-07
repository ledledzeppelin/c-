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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            //初始化数据库

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        DishDb dishDb = new DishDb();
        RestaurantDb restaurantDb = new RestaurantDb();
        ReviewDb reviewDb = new ReviewDb();
        UserDb userDb = new UserDb();

        private void dataGridViewload<T>(List<T> itemList)
        {
            dataGridView1.DataSource = itemList;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)   //下拉选项框，用于显示数据表
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    //DishDb dishDb = new DishDb();
                    var dishes = dishDb.Dishes.ToList();
                    dataGridViewload(dishes);
                    break;
                case 1:
                    //RestaurantDb restaurantDb = new RestaurantDb();
                    var restaurants = restaurantDb.Restaurants.ToList();
                    dataGridViewload(restaurants);
                    break;
                case 2:
                    //ReviewDb reviewDb = new ReviewDb();
                    var reviews = reviewDb.Reviews.ToList();
                    dataGridViewload(reviews);
                    break;
                case 3:
                    //UserDb userDb = new UserDb();
                    var users = userDb.Users.ToList();
                    dataGridViewload(users);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)    //增添按钮，用于增添对象
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:

                    Dish newdish = new Dish();//创建对象
                    //前端输入对象的值



                    dishDb.AddUser(newdish);  //添加对象到数据库
                    break;
                case 1:
                    Restaurant newrestaurant = new Restaurant();




                    restaurantDb.AddUser(newrestaurant);
                    break;
                case 2:
                    Review newreview = new Review();




                    reviewDb.AddUser(newreview);
                    break;
                case 3:
                    User NEWuser = new User();




                    userDb.AddUser(NEWuser);
                    break;
            }
        }



      

        private void button2_Click(object sender, EventArgs e)   //删除按钮，用于删除已选选项
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        var selectedDish = dataGridView1.SelectedRows[0].DataBoundItem as Dish;  //获取对象，selectDish即为对象
                        int id = selectedDish.DishId;
                        dishDb.DeleteUser(id);  //删除对象
                    }
                    else { MessageBox.Show("请选择相应的菜"); }
                    break;
                case 1:
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        var selectedDish = dataGridView1.SelectedRows[0].DataBoundItem as Restaurant;
                        int id = selectedDish.RestaurantId;
                        restaurantDb.DeleteUser(id);
                    }
                    else { MessageBox.Show("请选择相应的菜"); }
                    break;
                case 2:
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        var selectedDish = dataGridView1.SelectedRows[0].DataBoundItem as Review;
                        int id = selectedDish.ReviewId;
                        reviewDb.DeleteUser(id);
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

        private void button3_Click(object sender, EventArgs e)    //更新按钮，用于更新对象
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        var selectedDish = dataGridView1.SelectedRows[0].DataBoundItem as Dish;  //获取对象
                        //更新操作





                        dishDb.UpdateUser(selectedDish); //更新对象
                    }
                    else { MessageBox.Show("请选择相应的菜"); }
                    break;
                case 1:
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        var selectedDish = dataGridView1.SelectedRows[0].DataBoundItem as Restaurant;
                        



                        restaurantDb.UpdateUser(selectedDish);
                    }
                    else { MessageBox.Show("请选择相应的菜"); }
                    break;
                case 2:
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        var selectedDish = dataGridView1.SelectedRows[0].DataBoundItem as Review;
                       //更新操作





                        reviewDb.UpdateUser(selectedDish);
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
                        //更新操作






                        userDb.UpdateUser(selectedDish);
                    }
                    else { MessageBox.Show("请选择相应的菜"); }
                    break;
            }
        }
    }
}