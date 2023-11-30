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
using 餐厅管理系统.controls;
using 餐厅管理系统.data;
using 餐厅管理系统.database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 餐厅管理系统.winForm
{
    public partial class FormEditDish : MetroForm
    {
        public FormEditDish(int dishId, string resName,string originPicName, Image image,string dishName,string dishPrice, FormResMain formResMain)
        {
            InitializeComponent();
            this.resName = resName;
            this.formResMain = formResMain;
            originalPicName = originPicName;
            // 初始显示菜品原本信息
            pictureBox1.Image = image;
            bunifuTextBox1.Text = dishName;
            originalDishName = dishName;
            bunifuTextBox2.Text = dishPrice;
            this.dishId = dishId;
        }
        private string originalDishName;
        private string originalPicName;
        private int dishId;
        private string resName;
        // 记录修改后的菜品名、价格、图片
        private string editedDishName;
        private double editedPrice;
        private Image editedImage;


        private FormResMain formResMain;
        private int resId;
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
            // 获取当前应用程序的上级目录，用于保存图片
            DirectoryInfo pname = new DirectoryInfo(Application.StartupPath);
            // 当前工作路径
            string filename = pname.Parent.Parent.FullName;
            // 新图片名称
            string dishImageName = resName + bunifuTextBox1.Text + "." + empUpLoadPictureFormat;

            if (isUpLoadPicture)
            { // 已知文件路径
                string parentDirectory = Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName;
                string originImagePath = Path.Combine(parentDirectory, "image", "dishimage", originalPicName);
                formResMain.ClearPictureResources();
                try
                {
                    // 删除旧文件
                    File.Delete(originImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"发生错误：{ex.Message}");
                }
                // 将上传的图片复制到指定目录
                if (openFileDialog1.FileName != null)
                {
                    File.Copy(imagePath, filename + "\\image\\dishimage\\" + dishImageName, true);
                }

                var dish = db.Dishes.Find(dishId);
                if (dish != null)
                { // 显示菜品上传成功消息
                    dish.Price = double.Parse(bunifuTextBox2.Text);
                    dish.Name = bunifuTextBox1.Text;
                    dish.DisPicture = dishImageName;
                    db.SaveChanges();
                    formResMain.LoadDish();
                } 
            }
        }

        private void FormEditDish_Load(object sender, EventArgs e)
        {

        }
    }
}
