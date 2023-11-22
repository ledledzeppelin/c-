using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using 餐厅管理系统.database;
using 餐厅管理系统.data;
using MetroFramework.Forms;
using Microsoft.EntityFrameworkCore;

namespace 餐厅管理系统
{

    internal partial class FormResEdit : Form
    {
        // 餐厅对象
        Restaurant res;

        public FormResEdit(Restaurant res)
        {
            InitializeComponent();
            this.res = res;


        }

        private void FormResEdit_Load(object sender, EventArgs e)
        {
            // 在窗体加载时执行的代码（可留空）
        }

        // 加载数据到 DataGridView 控件
        private void dataGridViewload<T>(List<T> itemList)
        {
            dataGridView1.DataSource = itemList;
        }

        // 标记是否上传了图片
        bool isUpLoadPicture;

        // 上传的图片的后缀名
        string empUpLoadPictureFormat;

        // OpenFileDialog 控件，用于选择上传的图片文件
        OpenFileDialog openFileDialog1 = new OpenFileDialog();

        // 数据库操作对象，用于将菜品信息保存到数据库
        RestaurantDb db = new RestaurantDb();

        // 上传图片按钮点击事件
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                // 设置文件过滤器，只允许选择特定格式的图片
                openFileDialog1.Filter = "*.jpg|*.jpg|*.png|*.png|*.bmp|*.bmp|*.tiff|*.tiff";

                // 如果用户点击了"确定"按钮
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    isUpLoadPicture = true; // 记录已上传图片，用于保存操作
                    try
                    {
                        string uploadpicture;
                        uploadpicture = openFileDialog1.FileName; // 图片的物理路径
                        String[] empImageData = uploadpicture.Split('.'); // 获取文件类型
                        int count = empImageData.Length;
                        empUpLoadPictureFormat = empImageData[count-1]; // 上传的图片的后缀名
                        pictureBox1.Image = Image.FromFile(uploadpicture); // 将图片显示在 PictureBox 控件中
                    }
                    catch
                    {
                        MessageBox.Show("您选择的图片不能被读取或文件类型不对！", "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("上传相片出错: " + ex.Message);
            }
        }

        // 保存按钮点击事件，用于保存菜品信息到数据库
        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            // 获取当前应用程序的上级目录，用于保存图片
            DirectoryInfo pname = new DirectoryInfo(Application.StartupPath);
            string filename = pname.Parent.Parent.FullName;

            // 如果上传了图片
            if (isUpLoadPicture)
            {
                // 设置菜品图片的名字:以餐厅名+菜品名+后缀名
                string dishImageName = res.Name + textBox2.Text + "."+ empUpLoadPictureFormat;

                // 将上传的图片复制到指定目录
                File.Copy(openFileDialog1.FileName, filename + "\\image\\dishimage\\" + dishImageName);

                // 创建菜品对象并设置属性
                Dish dish = new Dish();
                dish.RestaurantId = res.RestaurantId;
                dish.DisPicture = dishImageName;
                dish.Price = decimal.Parse(textBox1.Text);
                dish.Name = textBox2.Text;

                db.AddDish(dish);


                // 显示菜品上传成功消息
                MessageBox.Show("菜品上传成功");
                var restaurantWithMenu = db.Restaurants
                          .Include(r => r.Menu)
                          .FirstOrDefault(r => r.RestaurantId == res.RestaurantId);

                if (restaurantWithMenu != null)
                {
                    var menuItems = restaurantWithMenu.Menu.ToList();
                    dataGridViewload(menuItems);
                    // 将菜单数据转换为列表
                }
          // 刷新 DataGridView 显示最新的菜单
          ;
            }

        }

        // 返回登录界面按钮点击事件
        private void button2_Click(object sender, EventArgs e)
        {
            // 隐藏当前窗体并显示登录窗体
            this.Hide();
            FormLogin form = new FormLogin();
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 单元格内容点击事件（可留空）
        }

        private void FormResEdit_Load_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}

      