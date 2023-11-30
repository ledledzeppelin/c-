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

namespace 餐厅管理系统.winForm
{
    public partial class FormMain_sub1 : MetroForm
    {
        private static FormMain_sub1 _instance;
        public static FormMain_sub1 Instance
        {
            get
            {
                if( _instance == null )
                    _instance = new FormMain_sub1();
                return _instance;   
            }
        }
        public FormMain_sub1()
        {
            InitializeComponent();
        }

        private void FormMain_sub1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void FormMain_sub1_Load(object sender, EventArgs e)
        {

        }
    }
}
