using System.Drawing;
using System.Windows.Forms;

namespace 餐厅管理系统.winForm
{
    partial class FormMainMetro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTabControlMain = new MetroFramework.Controls.MetroTabControl();
            this.PageMain = new MetroFramework.Controls.MetroTabPage();
            this.metroPanelMain = new MetroFramework.Controls.MetroPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchMod = new MetroFramework.Controls.MetroComboBox();
            this.Search = new MetroFramework.Controls.MetroButton();
            this.panelMain_textBox = new MetroFramework.Controls.MetroTextBox();
            this.PageMine = new MetroFramework.Controls.MetroTabPage();
            this.metroPanelMine = new MetroFramework.Controls.MetroPanel();
            this.metroTabControlMain.SuspendLayout();
            this.PageMain.SuspendLayout();
            this.metroPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PageMine.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControlMain
            // 
            this.metroTabControlMain.Controls.Add(this.PageMain);
            this.metroTabControlMain.Controls.Add(this.PageMine);
            this.metroTabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControlMain.Location = new System.Drawing.Point(20, 60);
            this.metroTabControlMain.Name = "metroTabControlMain";
            this.metroTabControlMain.SelectedIndex = 0;
            this.metroTabControlMain.Size = new System.Drawing.Size(1181, 732);
            this.metroTabControlMain.TabIndex = 0;
            // 
            // PageMain
            // 
            this.PageMain.Controls.Add(this.metroPanelMain);
            this.PageMain.HorizontalScrollbarBarColor = true;
            this.PageMain.Location = new System.Drawing.Point(4, 40);
            this.PageMain.Name = "PageMain";
            this.PageMain.Size = new System.Drawing.Size(1173, 688);
            this.PageMain.TabIndex = 0;
            this.PageMain.Text = "主页";
            this.PageMain.VerticalScrollbarBarColor = true;
            // 
            // metroPanelMain
            // 
            this.metroPanelMain.Controls.Add(this.dataGridView1);
            this.metroPanelMain.Controls.Add(this.SearchMod);
            this.metroPanelMain.Controls.Add(this.Search);
            this.metroPanelMain.Controls.Add(this.panelMain_textBox);
            this.metroPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelMain.HorizontalScrollbarBarColor = true;
            this.metroPanelMain.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelMain.HorizontalScrollbarSize = 10;
            this.metroPanelMain.Location = new System.Drawing.Point(0, 0);
            this.metroPanelMain.Name = "metroPanelMain";
            this.metroPanelMain.Size = new System.Drawing.Size(1173, 688);
            this.metroPanelMain.TabIndex = 2;
            this.metroPanelMain.VerticalScrollbarBarColor = true;
            this.metroPanelMain.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelMain.VerticalScrollbarSize = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1039, 444);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // SearchMod
            // 
            this.SearchMod.FormattingEnabled = true;
            this.SearchMod.ItemHeight = 23;
            this.SearchMod.Items.AddRange(new object[] {
            "距离",
            "星级",
            "综合"});
            this.SearchMod.Location = new System.Drawing.Point(60, 39);
            this.SearchMod.Name = "SearchMod";
            this.SearchMod.Size = new System.Drawing.Size(121, 29);
            this.SearchMod.TabIndex = 4;
            this.SearchMod.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(1008, 39);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(91, 50);
            this.Search.TabIndex = 3;
            this.Search.Text = "搜索";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // panelMain_textBox
            // 
            this.panelMain_textBox.Location = new System.Drawing.Point(206, 39);
            this.panelMain_textBox.Name = "panelMain_textBox";
            this.panelMain_textBox.Size = new System.Drawing.Size(750, 50);
            this.panelMain_textBox.TabIndex = 2;
            // 
            // PageMine
            // 
            this.PageMine.Controls.Add(this.metroPanelMine);
            this.PageMine.HorizontalScrollbarBarColor = true;
            this.PageMine.Location = new System.Drawing.Point(4, 40);
            this.PageMine.Name = "PageMine";
            this.PageMine.Size = new System.Drawing.Size(1173, 688);
            this.PageMine.TabIndex = 1;
            this.PageMine.Text = "我的";
            this.PageMine.VerticalScrollbarBarColor = true;
            // 
            // metroPanelMine
            // 
            this.metroPanelMine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelMine.HorizontalScrollbarBarColor = true;
            this.metroPanelMine.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelMine.HorizontalScrollbarSize = 10;
            this.metroPanelMine.Location = new System.Drawing.Point(0, 0);
            this.metroPanelMine.Name = "metroPanelMine";
            this.metroPanelMine.Size = new System.Drawing.Size(1173, 688);
            this.metroPanelMine.TabIndex = 2;
            this.metroPanelMine.VerticalScrollbarBarColor = true;
            this.metroPanelMine.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelMine.VerticalScrollbarSize = 10;
            // 
            // FormMainMetro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 812);
            this.Controls.Add(this.metroTabControlMain);
            this.Name = "FormMainMetro";
            this.metroTabControlMain.ResumeLayout(false);
            this.PageMain.ResumeLayout(false);
            this.metroPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PageMine.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControlMain;
        private MetroFramework.Controls.MetroTabPage PageMain;
        private MetroFramework.Controls.MetroTabPage PageMine;
        private MetroFramework.Controls.MetroPanel metroPanelMain;
        private MetroFramework.Controls.MetroPanel metroPanelMine;
        private MetroFramework.Controls.MetroTextBox panelMain_textBox;
        private MetroFramework.Controls.MetroButton Search;
        private MetroFramework.Controls.MetroComboBox SearchMod;
        private DataGridView dataGridView1;
    }
}