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
using 餐厅管理系统.data;
using Sunny.UI;
using static MetroFramework.Drawing.MetroPaint.BorderColor;
using Bunifu.UI.WinForms;
using 餐厅管理系统.database;
using Button = System.Windows.Forms.Button;

namespace 餐厅管理系统.winForm
{
    public partial class FormDishAdd : Form
    {
        public FormShadow shadow = null;
        // 标记是否上传了图片
        bool isUpLoadPicture;

        // 上传的图片的后缀名
        string empUpLoadPictureFormat;

        private string imagePath;
        public FormDishAdd()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            shadow = new FormShadow(this);

            if (!DesignMode)
            {
                //如果需要设置属性，可以用以下方法，不设置也行，类中已有默认值
                shadow.ShadowOpacity = 100;
                shadow.ShadowBlur = 0;
                shadow.ShadowSpread = 6;
                shadow.ShadowH = 0;
                shadow.ShadowV = 0;
                shadow.CornerRound = 4;
                shadow.ShadowColor = Color.Black;
            }
            var list = Program.DB.Restaurants.ToList();
            if(list.Count > 0)
            {
                this.cbxType.DataSource = list;
                this.cbxType.SelectedIndex = 0;
            }
            cbxType.DisplayMember = "Name";
        }


        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (!DesignMode)
            {
                RefreshShadow(true, true);
            }
        }

        #region 刷新显示影子窗体
        private void RefreshShadow(bool redraw, bool reLoaction)
        {
            if (!DesignMode)
            {
                if ((this != null) && (shadow != null))
                {
                    try
                    {
                        if (shadow.IsDisposed)
                        {
                            shadow = null;
                        }
                        shadow.Visible = (this.WindowState == FormWindowState.Normal) && (this.Visible);
                    }
                    catch { }

                    if (shadow.Visible)
                    {
                        shadow.RefreshShadow(redraw, reLoaction);
                    }
                }
            }
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var r = this.cbxType.SelectedItem as Restaurant;
                // 设置菜品图片的名字:以餐厅名+菜品名+后缀名
                string dishImageName = r.Name + txtName.Text + "." + empUpLoadPictureFormat;
                // 获取当前应用程序的上级目录，用于保存图片
                DirectoryInfo pname = new DirectoryInfo(Application.StartupPath);
                string filename = pname.Parent.Parent.FullName;

                // 将上传的图片复制到指定目录
                File.Copy(imagePath, filename + "\\image\\dishimage\\" + dishImageName);

                // 创建菜品对象并设置属性
                Dish dish = new Dish();
                dish.RestaurantId = r.RestaurantId;
                dish.DisPicture = dishImageName;
                dish.Price = double.Parse(txtPrice.Text);
                dish.Name = txtName.Text;
                Program.DB.Dishes.Add(dish);
                Program.DB.SaveChanges();
                // 显示菜品上传成功消息
                this.ShowMessageDialog("菜品上传成功","提示",false,UIStyle.Blue);
                this.Close();

            }
            catch (Exception ex)
            {
                this.ShowErrorDialog($"保存菜品信息时发生错误: {ex.Message}");
            }
        }

        private void btnSelectPic_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            // 创建 OpenFileDialog 对象
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // 设置文件对话框的属性
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Select an Image";

                // 显示文件对话框
                DialogResult result = openFileDialog.ShowDialog();

                // 如果用户选择了文件，则更新按钮的背景图片
                if (result == DialogResult.OK)
                {
                    string uploadpicture;
                    uploadpicture = openFileDialog.FileName; // 图片的物理路径
                    String[] empImageData = uploadpicture.Split('.'); // 获取文件类型
                    empUpLoadPictureFormat = empImageData[empImageData.Length - 1]; // 上传的图片的后缀名
                    imagePath = openFileDialog.FileName;
                    Image image = Image.FromFile(imagePath);
                    btn.BackgroundImage = image;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }
    }
}
