using MetroFramework.Forms;
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
using 餐厅管理系统.data;
using 餐厅管理系统.database;
using 餐厅管理系统.util;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 餐厅管理系统.winForm
{
    public partial class FormAddDish : MetroForm
    {
        public FormAddDish(int resId,string resName,FormResMain formResMain)
        {
            InitializeComponent();
            this.formResMain = formResMain;
            this.resId = resId;
            this.resName = resName;
        }
        // 添加菜品或者编辑已有菜品 0-添加 1-编辑
        private FormResMain formResMain;
        private int resId;
        private string resName;
        // 标记是否上传了图片
        bool isUpLoadPicture;

        // 上传的图片的后缀名
        string empUpLoadPictureFormat;

        // OpenFileDialog 控件，用于选择上传的图片文件
        OpenFileDialog openFileDialog1 = new OpenFileDialog();

        // 数据库操作对象，用于将菜品信息保存到数据库
        RestaurantDb db = new RestaurantDb();

        private string imagePath;
        
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
                        empUpLoadPictureFormat = empImageData[empImageData.Length - 1]; // 上传的图片的后缀名
                        pictureBox1.Image = Image.FromFile(uploadpicture); // 将图片显示在 PictureBox 控件中
                        imagePath = openFileDialog1.FileName;
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

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // 设置菜品图片的名字:以餐厅名+菜品名+后缀名
                string dishImageName = resName + bunifuTextBox1.Text + "."+ empUpLoadPictureFormat;
                // 获取当前应用程序的上级目录，用于保存图片
                DirectoryInfo pname = new DirectoryInfo(Application.StartupPath);
                string filename = pname.Parent.Parent.FullName;

                // 将上传的图片复制到指定目录
                File.Copy(imagePath, filename + "\\image\\dishimage\\" + dishImageName);

                // 创建菜品对象并设置属性
                Dish dish = new Dish();
                dish.RestaurantId = resId;
                dish.DisPicture = dishImageName;
                dish.Price = double.Parse(bunifuTextBox2.Text);
                dish.Name = bunifuTextBox1.Text;

                db.AddDish(dish);


                // 显示菜品上传成功消息
                MessageBox.Show("菜品上传成功");
                // 更新菜品界面
                formResMain.RefreshDish(dish);
                Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show("请上传完整信息",ex.Message);
            }
        }
        private void Clear()
        {
            bunifuTextBox1.Text = null;
            bunifuTextBox2.Text = null;
            pictureBox1.Image = ResInfo.GetImage("用户默认头像.png", 3);
        }

        private void FormAddDish_Load(object sender, EventArgs e)
        {

        }
    }
}
