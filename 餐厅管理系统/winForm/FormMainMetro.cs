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

namespace 餐厅管理系统.winForm
{
    public partial class FormMainMetro : MetroForm
    {
        public FormMainMetro()
        {
            InitializeComponent();
            metroPanelMain.Visible = true;
            metroPanelMine.Visible = false;
            LoadData();
            //设置模式选择默认为星级排序
            SearchMod.SelectedIndex = 0;
            //metroPanelMain.Controls.Add(panelMain_textBox);
            //metroPanelMain.Controls.Add(Search);
            /**metroPanelMain.Controls.Add(panel_set_location);
            metroPanelMain.Controls.Add(SearchMod);
            metroPanelMain.Controls.Add(dataGridView1);*/
        }
        //初始化datagridview
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

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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

        // 设置 datagridview 背景为半透明
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // 仅处理数据单元格
            /**if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // 设置单元格的背景为半透明颜色
                using (Brush backColorBrush = new SolidBrush(Color.FromArgb(100, 255, 255, 255)))
                {
                    e.Graphics.FillRectangle(backColorBrush, e.CellBounds);
                }

                // 绘制单元格的文本内容
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }*/
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
                    string imagePath = Path.Combine(parentDirectory, "image", "restaurantimage", fileName);
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

                // 在这里处理导航到详细页面的逻辑，使用上面获取的属性值
                FormResDetailClient myform = new FormResDetailClient(restaurantId);   // 调用带参的构造函数
                this.Hide();
                myform.ShowDialog();
                this.Dispose();
            }
        }
        // 跳转到商家详情
        private void OpenRestaurantDetailsForm(int restaurantId)
        {
            // 创建详细页面的窗体实例，并传递完整的餐厅对象
            FormResDetailClient detailsForm = new FormResDetailClient(restaurantId);

            // 显示详细页面的窗体
            //detailsForm.Show();
        }
    }
}
