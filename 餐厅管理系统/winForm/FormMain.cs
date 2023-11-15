using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Device.Location;
using 餐厅管理系统.util;
using System.Security.Cryptography;
using 餐厅管理系统.winForm;
using 餐厅管理系统.database;

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
    public partial class FormMain : Form
    {
        double userLatitude;
        double userLongitude;
        public FormMain()
        {
            InitializeComponent();
            InitializeDataGridView();
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
        }

        

        /**
         * 点击定位后，获取用户当前位置信息
         */
        private void panel_set_location_Click(object sender, EventArgs e)
        {
            
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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel_main.Visible = true;
            panel_mine.Visible = false;
        }

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

        private void 我的ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_main.Visible = false;
            panel_mine.Visible = true;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            string keyword = panelMain_textBox.Text.Trim();
            MessageBox.Show(keyword);
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
                        int count = restaurants.Count();
                        MessageBox.Show(count.ToString());
                        // 将查询结果绑定到 UI 控件，比如 DataGridView
                        dataGridView1.DataSource = restaurants;
                        break;
                    default:
                        MessageBox.Show("请选择搜索模式");
                        break;
                }
            }
        }
        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = true;

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "ResName";
            nameColumn.HeaderText = "餐厅名称";
            dataGridView1.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn rateColumn = new DataGridViewTextBoxColumn();
            rateColumn.DataPropertyName = "Rate";
            rateColumn.HeaderText = "星级";
            dataGridView1.Columns.Add(rateColumn);

            // 图片可能需要使用DataGridViewImageColumn，具体情况根据ResPicture的类型和存储方式来调整
           /* DataGridViewImageColumn pictureColumn = new DataGridViewImageColumn();
            pictureColumn.DataPropertyName = "ResPicture";
            pictureColumn.HeaderText = "图片";
            dataGridView1.Columns.Add(pictureColumn);*/
        }

    }
}
