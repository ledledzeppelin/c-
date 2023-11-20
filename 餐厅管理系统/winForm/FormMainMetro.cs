using MetroFramework.Controls;
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
    public partial class FormMainMetro : MetroForm
    {
        public FormMainMetro()
        {
            InitializeComponent();
            metroPanelMain.Visible = true;
            metroPanelMine.Visible = false;
            metroPanelMain.Controls.Add(panelMain_textBox);
            metroPanelMain.Controls.Add(Search);
            /**metroPanelMain.Controls.Add(panel_set_location);
            metroPanelMain.Controls.Add(SearchMod);
            metroPanelMain.Controls.Add(dataGridView1);*/
        }

        
    }
}
