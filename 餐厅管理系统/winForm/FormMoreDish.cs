using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 餐厅管理系统.controls;
using 餐厅管理系统.data;

namespace 餐厅管理系统.winForm
{
    // 在用户查看餐厅信息时，点击更多菜品后跳转到此页面，显示餐厅的所有菜品
    public partial class FormMoreDish : MetroForm
    {
        public FormMoreDish(List<Dish> dishList)
        {
            InitializeComponent();
            this.dishList = dishList;
            //MessageBox.Show(this.dishList.Count.ToString());
            InitializeDishPanel(dishList);
        }
        private List<Dish> dishList;

        //初始化菜单
        private void InitializeDishPanel(List<Dish> dishList) 
        { 
            foreach (Dish dish in dishList)
            {
                DishDetail dishDetail = new DishDetail();
                dishDetail.ImageName = dish.DisPicture;
                dishDetail.DishName = dish.Name;
                dishDetail.Price = dish.Price;
                flowLayoutPanel1.Controls.Add(dishDetail);
            }
        }

        private void FormMoreDish_Load(object sender, EventArgs e)
        {

        }
    }
}
