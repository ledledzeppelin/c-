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
using System.Runtime.Remoting.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Drawing2D;

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
            LoadData();
            dataGridView1.CellDoubleClick += DataGridView_CellDoubleClick;
        }

        private void LoadData()
        {
            using (var context = new RestaurantDb())
            {

                var restaurantWithMenu = db.Restaurants
                         .Include(r => r.Menu)
                         .FirstOrDefault(r => r.RestaurantId == res.RestaurantId);

                if (restaurantWithMenu != null)
                {
                    var menuItems = restaurantWithMenu.Menu.ToList();





                    //将id设置为隐藏列
                    DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
                    idColumn.Name = "DishId";
                    idColumn.Visible = false;
                    idColumn.DataPropertyName = "DishId";
                    dataGridView1.Columns.Add(idColumn);

                    // 将图片列设置为DataGridViewImageColumn
                    DataGridViewColumn existingColumn = dataGridView1.Columns["DisPictureTrueImage"];

                    if (existingColumn == null)
                    {
                        // 如果不存在该列，则添加新的 DataGridViewImageColumn 列
                        DataGridViewImageColumn pictureColumn = new DataGridViewImageColumn();
                        pictureColumn.Name = "DisPictureTrueImage";
                        pictureColumn.HeaderText = "图片";
                        pictureColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

                        dataGridView1.Columns.Add(pictureColumn);
                    }

                    // 将文件名列设置为隐藏列
                    DataGridViewTextBoxColumn ResPicColumn = new DataGridViewTextBoxColumn();
                    ResPicColumn.Name = "DisPicture";
                    ResPicColumn.Visible = false;
                    ResPicColumn.DataPropertyName = "DisPicture";
                    dataGridView1.Columns.Add(ResPicColumn);






                    dataGridView1.DataSource = menuItems;

                    // 更改列的显示名称
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            // 判断是否是ResPictureTrueImage列，并且不是标题行
            if (dataGridView1.Columns[e.ColumnIndex].Name == "DisPictureTrueImage" && e.RowIndex >= 0)
            {
                // 获取ResPicture列的单元格值（文件名）
                string fileName = dataGridView1.Rows[e.RowIndex].Cells["DisPicture"].Value as string;
                if (!string.IsNullOrEmpty(fileName))
                {

                    // 文件路径往上退两级
                    string parentDirectory = Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName;

                    // 获取图片的完整路径
                    string imagePath = parentDirectory + "\\image\\dishimage\\" + fileName;
                    // 检查图片文件是否存在
                    if (File.Exists(imagePath))
                    {
                        // 从文件加载图片
                        Image image = Image.FromFile(imagePath);

                        // 调整图片大小以适应单元格，按比例缩放
                        int cellWidth = dataGridView1.Columns[e.ColumnIndex].Width;
                        int cellHeight = dataGridView1.Rows[e.RowIndex].Height;
                        if (image.Width > cellWidth || image.Height > cellHeight)
                        {
                            double ratioX = (double)cellWidth / image.Width;
                            double ratioY = (double)cellHeight / image.Height;
                            double ratio = Math.Min(ratioX, ratioY);

                            int newWidth = (int)(image.Width * ratio);
                            int newHeight = (int)(image.Height * ratio);

                            // 将调整后的图片显示在ResPictureTrueImage列中
                            e.Value = ResizeImage(image, newWidth, newHeight);
                        }
                        else
                        {
                            e.Value = image;
                        }
                    }
                }
            }
        }

        private Image ResizeImage(Image imgToResize, int width, int height)
        {
            Bitmap b = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage((Image)b))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(imgToResize, 0, 0, width, height);
            }
            return (Image)b;
        }

        private void FormResEdit_Load(object sender, EventArgs e)
        {
            // 在窗体加载时执行的代码（可留空）
        }

        // 加载数据到 DataGridView 控件
        string imagePath;
        int a = 100;
        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // 处理双击事件
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                // 获取被双击的单元格或行的信息，然后在这里执行你的操作
                MessageBox.Show("请修改相关菜品信息");

                textBox1.Text = selectedRow.Cells["Price"].Value.ToString();
                textBox2.Text = selectedRow.Cells["Name"].Value.ToString();
                a = (int)selectedRow.Cells["DishId"].Value;
                string parentDirectory = Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName;
                string i = selectedRow.Cells["DisPicture"].Value.ToString();
                // 获取图片的完整路径
                imagePath = parentDirectory + "\\image\\dishimage\\" + i;

                pictureBox1.Image = Image.FromFile(imagePath);
                button1.Text = "更新菜品信息";
                isUpLoadPicture = true;
            }
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
                if (a == 100)
                {
                    // 设置菜品图片的名字:以餐厅名+菜品名+后缀名
                    string dishImageName = res.Name + textBox2.Text + empUpLoadPictureFormat;

                    // 将上传的图片复制到指定目录
                    File.Copy(imagePath, filename + "\\image\\dishimage\\" + dishImageName);

                    // 创建菜品对象并设置属性
                    Dish dish = new Dish();
                    dish.RestaurantId = res.RestaurantId;
                    dish.DisPicture = dishImageName;
                    dish.Price = double.Parse(textBox1.Text);
                    dish.Name = textBox2.Text;

                    db.AddDish(dish);


                    // 显示菜品上传成功消息
                    MessageBox.Show("菜品上传成功");

                    LoadData();
                    // 将菜单数据转换为列表
                }
                else
                {
                    string dishImageName = res.Name + textBox2.Text + empUpLoadPictureFormat;

                    // 将上传的图片复制到指定目录
                    if (openFileDialog1.FileName != null)
                    {
                        File.Copy(imagePath, filename + "\\image\\dishimage\\" + dishImageName, true);
                    }
                    var dish = db.Dishes.Find(a);
                    if (dish != null)
                    { // 显示菜品上传成功消息
                        dish.Price = double.Parse(textBox1.Text);
                        dish.Name = textBox2.Text;
                        dish.DisPicture = dishImageName;
                        db.SaveChanges();
                        MessageBox.Show("修改成功");
                        a = 100;
                        button1.Text = "增添菜品";
                        pictureBox1.Image = null;
                        textBox1.Text = null;
                        textBox2.Text = null;
                    }

                    LoadData();
                }
            }

        }

        // 返回登录界面按钮点击事件
        private void button2_Click(object sender, EventArgs e)
        {
            // 隐藏当前窗体并显示登录窗体
            FormLogin form = new FormLogin();
            this.Hide();
            form.Show();
            this.Dispose();
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

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
            if (panel1.Visible)
            {
                label5.Text = "餐厅名:" + res.Name;
                label6.Text = "餐厅账户：" + res.Account;

                label8.Text = "餐厅地址" + res.Address;
                DirectoryInfo pname = new DirectoryInfo(Application.StartupPath);
                string filename = pname.Parent.Parent.FullName;
                string picturefile = filename + "\\image\\restaurantimage\\" + res.ResPicture;
                pictureBox2.Image = Image.FromFile(picturefile);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
