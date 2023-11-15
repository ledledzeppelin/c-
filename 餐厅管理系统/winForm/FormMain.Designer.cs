namespace 餐厅管理系统
{
    partial class FormMain
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
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.我的ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_mine = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchMod = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.Button();
            this.panelMain_textBox = new System.Windows.Forms.TextBox();
            this.panel_set_location = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.panel_mine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(75, 38);
            this.toolStripMenuItem2.Text = "主页";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.我的ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1292, 42);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "文件";
            // 
            // 我的ToolStripMenuItem
            // 
            this.我的ToolStripMenuItem.Name = "我的ToolStripMenuItem";
            this.我的ToolStripMenuItem.Size = new System.Drawing.Size(75, 38);
            this.我的ToolStripMenuItem.Text = "我的";
            this.我的ToolStripMenuItem.Click += new System.EventHandler(this.我的ToolStripMenuItem_Click);
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_mine);
            this.panel_main.Controls.Add(this.panel_set_location);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 42);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1292, 750);
            this.panel_main.TabIndex = 3;
            // 
            // panel_mine
            // 
            this.panel_mine.Controls.Add(this.dataGridView1);
            this.panel_mine.Controls.Add(this.SearchMod);
            this.panel_mine.Controls.Add(this.Search);
            this.panel_mine.Controls.Add(this.panelMain_textBox);
            this.panel_mine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_mine.Location = new System.Drawing.Point(0, 0);
            this.panel_mine.Name = "panel_mine";
            this.panel_mine.Size = new System.Drawing.Size(1292, 750);
            this.panel_mine.TabIndex = 2;
            this.panel_mine.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(111, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 446);
            this.dataGridView1.TabIndex = 3;
            // 
            // SearchMod
            // 
            this.SearchMod.FormattingEnabled = true;
            this.SearchMod.Items.AddRange(new object[] {
            "综合",
            "距离",
            "星级"});
            this.SearchMod.Location = new System.Drawing.Point(90, 89);
            this.SearchMod.Name = "SearchMod";
            this.SearchMod.Size = new System.Drawing.Size(121, 29);
            this.SearchMod.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.Location = new System.Drawing.Point(931, 82);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(131, 40);
            this.Search.TabIndex = 1;
            this.Search.Text = "搜索商家";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // panelMain_textBox
            // 
            this.panelMain_textBox.Location = new System.Drawing.Point(254, 89);
            this.panelMain_textBox.Name = "panelMain_textBox";
            this.panelMain_textBox.Size = new System.Drawing.Size(600, 31);
            this.panelMain_textBox.TabIndex = 0;
            // 
            // panel_set_location
            // 
            this.panel_set_location.Location = new System.Drawing.Point(1096, 40);
            this.panel_set_location.Name = "panel_set_location";
            this.panel_set_location.Size = new System.Drawing.Size(101, 38);
            this.panel_set_location.TabIndex = 1;
            this.panel_set_location.Text = "定位";
            this.panel_set_location.UseVisualStyleBackColor = true;
            this.panel_set_location.Click += new System.EventHandler(this.panel_set_location_Click_1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 792);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_mine.ResumeLayout(false);
            this.panel_mine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.ToolStripMenuItem 我的ToolStripMenuItem;
        private System.Windows.Forms.Button panel_set_location;
        private System.Windows.Forms.Panel panel_mine;
        private System.Windows.Forms.TextBox panelMain_textBox;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ComboBox SearchMod;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}