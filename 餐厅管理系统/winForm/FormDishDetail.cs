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

namespace 餐厅管理系统.winForm
{
    public partial class FormDishDetail : Form
    {
        public FormShadow shadow = null;
        public Dish DishEntity = null;
        public FormDishDetail(dynamic dish, Dish dishEntity = null)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txtDishName.Text = Convert.ToString(dish.Name);
            txtDishPrice.Text = Convert.ToString(dish.Price);
            DishEntity = dishEntity;
            if (DishEntity == null)
            {
                txtResName.Text = Convert.ToString(dish.ResName);
            }
            else
            {
                txtResName.Text = DishEntity.Name;
            }
            string parentDirectory = Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName;
            string imgPath = Path.Combine(parentDirectory, "image", "dishimage", Convert.ToString(dish.DisPicture));
            pbxPic.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxPic.ImageLocation = imgPath;
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
    }
}
