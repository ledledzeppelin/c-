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
using 餐厅管理系统.database;

namespace 餐厅管理系统.winForm
{
    public partial class FormMainMetro : MetroForm
    {
        public FormMainMetro(string userName)
        {
            InitializeComponent();
            mainPanel1.UserName = userName;
            mainPanel1.InitializeRes();
        }

        private void mainPanel1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
