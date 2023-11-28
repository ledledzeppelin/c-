using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 餐厅管理系统.controls
{
    public partial class RecommendDish : UserControl
    {
        public RecommendDish()
        {
            InitializeComponent();
        }
        public void AddDish(Panel dishPanel)
        {
            flowLayoutPanel1.Controls.Add(dishPanel);
        }

        
        public event EventHandler ButtonDoubleClick;
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            // 在按钮被点击时引发事件
            ButtonDoubleClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
