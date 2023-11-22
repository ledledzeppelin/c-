using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Device.Location;
using 餐厅管理系统.util;
using System.Security.Cryptography;
using 餐厅管理系统.winForm;
using 餐厅管理系统.database;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Drawing.Drawing2D;
using MetroFramework.Forms;
//using static System.Net.Mime.MediaTypeNames;
//using static System.Net.Mime.MediaTypeNames.Image;



/**
 * 此窗口为用户交互的主要窗口，使用MDI窗体：
 * MDI（Multiple Document Interface，多文档界面）是一种在主
 * 窗体中打开和管理多个子窗体的方式。在MDI窗体中，可以通过菜单、工
 * 具栏或者其他方式切换不同的子窗体。使用MDI窗体可以实现类似于Tab页签的效果
 * 
 * 主要有两个窗口：
 * 首页（包括搜索、推荐商家两大功能）
 * 我的（编辑个人资料）
 */
namespace 餐厅管理系统
{
    public partial class FormMain : MetroForm
    {
        double userLatitude;
        double userLongitude;
        public FormMain()
        {
            InitializeComponent();
            // 初始显示主界面，并绑定各个控件到各自的panel上
            panel_main.Visible = true;
            panel_mine.Visible = false;
            panel_main.Controls.Add(panelMain_textBox);
            panel_main.Controls.Add(panel_set_location);
            panel_main.Controls.Add(Search);
            panel_main.Controls.Add(SearchMod);
            panel_main.Controls.Add(dataGridView1);

            //设置模式选择默认为综合排序
            SearchMod.SelectedIndex = 0;
            // 初始在datagridview里按照餐厅星级从大到小显示餐厅
            LoadData();



        }

        private void LoadData()
        {
            using (var context = new RestaurantDb())
            {
                var restaurants = context.Restaurants
                    .OrderByDescending(r => r.Rate)
                    .Select(r => new
                    {
                        RestaurantId = r.RestaurantId, // Assuming Id is the property for the ID
                        ResPicture = r.ResPicture,
                        ResName = r.Name,
                        Rate = r.Rate
                    })
                    .ToList();


                
                //将id设置为隐藏列
                DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
                idColumn.Name = "RestaurantId";
                idColumn.Visible = false;
                idColumn.DataPropertyName = "RestaurantId";
                dataGridView1.Columns.Add(idColumn);

                // 将图片列设置为DataGridViewImageColumn
                DataGridViewImageColumn pictureColumn = new DataGridViewImageColumn();
                pictureColumn.Name = "ResPictureTrueImage";
                pictureColumn.HeaderText = "图片";
                // 设置ImageLayout为Zoom，确保图片完整地显示在单元格中，同时维持其宽高比
                pictureColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; 
                dataGridView1.Columns.Add(pictureColumn);

                // 将文件名列设置为隐藏列
                DataGridViewTextBoxColumn ResPicColumn = new DataGridViewTextBoxColumn();
                ResPicColumn.Name = "ResPicture";
                ResPicColumn.Visible = false;
                ResPicColumn.DataPropertyName = "ResPicture";
                dataGridView1.Columns.Add(ResPicColumn);


                dataGridView1.DataSource = restaurants;
                
                // 更改列的显示名称
                dataGridView1.Columns["ResName"].HeaderText = "餐厅名称";
                dataGridView1.Columns["Rate"].HeaderText = "星级";
                //dataGridView1.Columns["ResPicture"].HeaderText = "图片"; // 如果有 ResPicture 列的话
                dataGridView1.ClearSelection();
            }
        }

        

        private void ShowForm(Form frm)
        {
            frm.MdiParent = this;
            frm.Show();
            frm.Activate();
        }
        private void dormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(FormMain_sub1.Instance);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        
        private void panel_set_location_Click(object sender, EventArgs e)
        {

        }
        //显示主页
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel_main.Visible = true;
            panel_mine.Visible = false;
        }
        /**
         * 点击定位后，获取用户当前位置信息
         */
        private void panel_set_location_Click_1(object sender, EventArgs e)
        {
            List<double> location = new List<double>();
            location = util.Location.GetLocationProperty();
            if (location != null)
            {
                userLatitude = location[0];
                userLongitude = location[1];
                MessageBox.Show("userLatitude is", userLatitude.ToString());
                MessageBox.Show("userLatitude is", userLatitude.ToString());
            }
            else
            {
                MessageBox.Show("获取位置失败，请查看是否授权");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //显示我的
        private void 我的ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_main.Visible = false;
            panel_mine.Visible = true;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        /**
         * 按键功能：根据查询模式、关键字在数据库中搜索餐厅，并将结果显示在DataGridView中
         */
        private void Search_Click(object sender, EventArgs e)
        {
            string keyword = panelMain_textBox.Text.Trim();
            string mod = SearchMod.Text.Trim();
            // 创建数据库上下文实例，并在Restaurant数据库中查询
            using (var context = new RestaurantDb())
            {
                switch (mod)
                {
                    case "综合":
                        break;
                    case "距离":
                        break;
                    case "星级":
                        var restaurants = context.Restaurants.ToList()
                        .Where(r => r.Name.Trim().Contains(keyword))
                        .OrderByDescending(r => r.Rate)
                        .Select(r => new
                        {
                            ResName = r.Name,
                            Rate = r.Rate,
                            //ResPicture = r.ResPicture
                        })
                        .ToList();
                        // 将查询结果绑定到 UI 控件，比如 DataGridView
                        dataGridView1.DataSource = restaurants;
                        break;
                    default:
                        MessageBox.Show("请选择搜索模式");
                        break;
                }
            }
        }

        /** 
         * 令datagridview显示商家图片
         */
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            // 判断是否是ResPictureTrueImage列，并且不是标题行
            if (dataGridView1.Columns[e.ColumnIndex].Name == "ResPictureTrueImage" && e.RowIndex >= 0)
            {
                // 获取ResPicture列的单元格值（文件名）
                string fileName = dataGridView1.Rows[e.RowIndex].Cells["ResPicture"].Value as string;
                if (!string.IsNullOrEmpty(fileName))
                {
                    
                    // 文件路径往上退两级
                    string parentDirectory = Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName;

                    // 获取图片的完整路径
                    string imagePath = ResInfo.GetImagePath(fileName, 0);
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
            dataGridView1.ClearSelection();
        }
        // 调整图片大小的辅助函数
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

        // 跳转到商家详情
        private void OpenRestaurantDetailsForm(int restaurantId)
        {
            // 创建详细页面的窗体实例，并传递完整的餐厅对象
            FormResDetailClient detailsForm = new FormResDetailClient(restaurantId);

            // 显示详细页面的窗体
            //detailsForm.Show();
        }

        // 双击某一行后跳转到商家详情界面
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                int restaurantId = Convert.ToInt32(selectedRow.Cells["RestaurantId"].Value);
                string resName = selectedRow.Cells["ResName"].Value?.ToString();
                int rate = Convert.ToInt32(selectedRow.Cells["Rate"].Value);
                string resPicture = selectedRow.Cells["ResPicture"].Value?.ToString();

                OpenRestaurantDetailsForm(restaurantId);
                // 在这里处理导航到详细页面的逻辑，使用上面获取的属性值
                FormResDetailClient myform = new FormResDetailClient(restaurantId);   // 调用带参的构造函数
                this.Hide();
                myform.ShowDialog();
                this.Dispose();
            }
        }
    }
}
