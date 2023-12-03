using Sunny.UI;
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

namespace 餐厅管理系统.winForm
{
    public partial class FormResDetail : Form
    {
        public FormShadow shadow = null;
        public Restaurant Restaurant = null;
        public FormResDetail(Restaurant restaurant)
        {
            InitializeComponent();
            this.Restaurant = restaurant;
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
            this.txtAcc.Text = restaurant.Account;
            this.txtAdd.Text = restaurant.Address;
            this.txtName.Text = restaurant.Name;
            this.txtRate.Text = string.Format("{0:N2}", restaurant.Rate);
            dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.AutoGenerateColumns = false;
            dgvData.RowsDefaultCellStyle.Font = new Font("微软雅黑", 9);
            dgvData.ColumnHeadersDefaultCellStyle.Font = new Font("微软雅黑", 10);
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "Detail";
            btn.HeaderText = "详情";
            btn.DefaultCellStyle.NullValue = "详情";
            dgvData.Columns.Add(btn);
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            btn1.Name = "Delete";
            btn1.HeaderText = "删除";
            btn1.DefaultCellStyle.NullValue = "删除";
            dgvData.Columns.Add(btn1);
            string parentDirectory = Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName;
            string imgPath = Path.Combine(parentDirectory, "image", "restaurantimage", Convert.ToString(Restaurant.ResPicture));
            pbxPic.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxPic.ImageLocation = imgPath;
            LoadDishMenu();
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

        public void LoadDishMenu()
        {
            dgvData.DataSource = Program.DB.Dishes.Where(x => x.RestaurantId == Restaurant.RestaurantId).ToList();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            int index = dgv.SelectedCells[0].RowIndex;
            if (dgv.CurrentCell is DataGridViewButtonCell dgc)
            {
                var dish = dgv.Rows[index].DataBoundItem as Dish;
                if (dgc.FormattedValue == "详情")
                {
                    FormDishDetail formDishDetail = new FormDishDetail(dish, dish);
                    formDishDetail.ShowDialog();
                }
                else if (dgc.FormattedValue == "删除")
                {
                    Program.DB.Dishes.Remove(dish);
                    Program.DB.SaveChanges();
                    LoadDishMenu();
                    this.ShowMessageDialog("删除成功!", "提示", false, UIStyle.Inherited);
                }
            }
        }
    }
}
