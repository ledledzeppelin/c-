using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 餐厅管理系统.data;
using static 餐厅管理系统.winForm.FormShadow;

namespace 餐厅管理系统.winForm
{
    public partial class FormAdmin : Form
    {
        #region 初始化样式
        public FormShadow shadow = null;
        public FormAdmin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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

            dgdRes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgdRes.AutoGenerateColumns = false;
            dgdRes.RowsDefaultCellStyle.Font = new Font("微软雅黑", 9);
            dgdRes.ColumnHeadersDefaultCellStyle.Font = new Font("微软雅黑", 10);
            DataGridViewButtonColumn btn3 = new DataGridViewButtonColumn();
            btn3.Name = "Detail";
            btn3.HeaderText = "详情";
            btn3.DefaultCellStyle.NullValue = "详情";
            dgdRes.Columns.Add(btn3);
            DataGridViewButtonColumn btn4 = new DataGridViewButtonColumn();
            btn4.Name = "Delete";
            btn4.HeaderText = "删除";
            btn4.DefaultCellStyle.NullValue = "删除";
            dgdRes.Columns.Add(btn4);

            dgdUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgdUser.AutoGenerateColumns = false;
            dgdUser.RowsDefaultCellStyle.Font = new Font("微软雅黑", 9);
            dgdUser.ColumnHeadersDefaultCellStyle.Font = new Font("微软雅黑", 10);
            DataGridViewButtonColumn btn5 = new DataGridViewButtonColumn();
            btn5.Name = "Detail";
            btn5.HeaderText = "详情";
            btn5.DefaultCellStyle.NullValue = "详情";
            dgdUser.Columns.Add(btn5);
            DataGridViewButtonColumn btn6 = new DataGridViewButtonColumn();
            btn6.Name = "Delete";
            btn6.HeaderText = "删除";
            btn6.DefaultCellStyle.NullValue = "删除";
            dgdUser.Columns.Add(btn6);


            dgdRate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgdRate.AutoGenerateColumns = false;
            dgdRate.RowsDefaultCellStyle.Font = new Font("微软雅黑", 9);
            dgdRate.ColumnHeadersDefaultCellStyle.Font = new Font("微软雅黑", 10);

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
            SelectMenu(lbl1, null);

        }


        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (!DesignMode)
            {
                RefreshShadow(true, true);
            }
        }

        
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

        #region 菜单
        private void SelectMenu(object sender, MouseEventArgs e)
        {
            var lbl = sender as UILabel;
            lbl1.BackColor = Color.Transparent;
            lbl2.BackColor = Color.Transparent;
            lbl3.BackColor = Color.Transparent;
            lbl4.BackColor = Color.Transparent;
            pnlDish.Visible = false;
            pnlRes.Visible = false;
            pnlComment.Visible = false;
            pnlUser.Visible = false;
            if (lbl.Text == "菜品管理")
            {
                lbl1.BackColor = Color.FromArgb(22, 54, 105);
                DishInit();
                pnlDish.Visible = true;
            }
            else if(lbl.Text == "餐厅管理")
            {
                lbl2.BackColor = Color.FromArgb(22, 54, 105);
                ResInit();
                pnlRes.Visible = true;
            }
            else if (lbl.Text == "评价管理")
            {
                lbl3.BackColor = Color.FromArgb(22, 54, 105);
                CommentInit();
                pnlComment.Visible = true;
            }
            else if (lbl.Text == "用户管理")
            {
                lbl4.BackColor = Color.FromArgb(22, 54, 105);
                UserInit();
                pnlUser.Visible = true;
            }
        }

        #endregion

        #region 菜品管理
        public void DishInit()


        {
            LoadDishMenu();
        }
        public async void LoadDishMenu()
        {
            var res = (from p in Program.DB.Dishes
                       join q in Program.DB.Restaurants on p.RestaurantId equals q.RestaurantId into pq
                       from r in pq.DefaultIfEmpty()
                       select new
                       {
                           Id = p == null ? 0 : p.DishId,
                           Name = p == null ? "" : p.Name,
                           DisPicture = p == null ? "" : p.DisPicture,
                           Price = p == null ? 0 : p.Price,
                           ResName = r == null ? "" : r.Name,
                       }).ToList();
            dgvData.DataSource = res;
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            int index = dgv.SelectedCells[0].RowIndex;
            if (dgv.CurrentCell is DataGridViewButtonCell dgc)
            {
                var dish = dgv.Rows[index].DataBoundItem as dynamic;
                if (dgc.FormattedValue == "详情")
                {
                    FormDishDetail formDishDetail = new FormDishDetail(dish);
                    formDishDetail.ShowDialog();
                }
                else if (dgc.FormattedValue == "删除")
                {
                    int id = Convert.ToInt32(dish.Id);
                    var dishEntity = Program.DB.Dishes.Where(x => x.DishId == id).FirstOrDefault();
                    Program.DB.Dishes.Remove(dishEntity);
                    Program.DB.SaveChanges();
                    LoadDishMenu();
                    this.ShowMessageDialog("删除成功!","提示",false,UIStyle.Inherited);
                }
            }
        }
        #endregion

        #region 餐厅管理
        public void ResInit()
        {
            LoadResMenu();
        }
        public async void LoadResMenu()
        {
            var res = Program.DB.Restaurants.ToList();
            dgdRes.DataSource = res;
        }

        private void dgdRes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            int index = dgv.SelectedCells[0].RowIndex;
            if (dgv.CurrentCell is DataGridViewButtonCell dgc)
            {
                var item = dgv.Rows[index].DataBoundItem as Restaurant;
                if (dgc.FormattedValue == "详情")
                {
                    FormResDetail form = new FormResDetail(item);
                    form.ShowDialog();
                }
                else if (dgc.FormattedValue == "删除")
                {
                    Program.DB.Restaurants.Remove(item);
                    Program.DB.SaveChanges();
                    LoadResMenu();
                    this.ShowMessageDialog("删除成功!", "提示", false, UIStyle.Inherited);
                }
            }
        }
        #endregion

        #region 评价管理
        public void CommentInit()
        {

        }
        #endregion 

        #region 用户管理
        public void UserInit()
        {
            LoadUserhMenu();
        }

        public async void LoadUserhMenu()
        {
            var res = Program.DB.Users.ToList();
            dgdUser.DataSource = res;
        }


        private void dgdUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            int index = dgv.SelectedCells[0].RowIndex;
            if (dgv.CurrentCell is DataGridViewButtonCell dgc)
            {
                var item = dgv.Rows[index].DataBoundItem as User;
                if (dgc.FormattedValue == "详情")
                {
                    FormUserDetail formUserDetail = new FormUserDetail(item);
                    formUserDetail.ShowDialog();
                }
                else if (dgc.FormattedValue == "删除")
                {
                    int id = Convert.ToInt32(item.Id);
                    var itemEntity = Program.DB.Users.Where(x => x.Id == id).FirstOrDefault();
                    Program.DB.Users.Remove(itemEntity);
                    Program.DB.SaveChanges();
                    LoadUserhMenu();
                    this.ShowMessageDialog("删除成功!", "提示", false, UIStyle.Inherited);
                }
            }
        }

        #endregion

        private void uiButton2_Click(object sender, EventArgs e)
        {
            new FormDishAdd().ShowDialog();
            this.LoadDishMenu();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
