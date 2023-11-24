namespace 餐厅管理系统.controls
{
    partial class ResDetail
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResDetail));
            this.ControlResName = new Bunifu.UI.WinForms.BunifuLabel();
            this.ControlResAddress = new Bunifu.UI.WinForms.BunifuLabel();
            this.ControlRate = new Bunifu.UI.WinForms.BunifuLabel();
            this.ControlRateImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ControlRateImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlResName
            // 
            this.ControlResName.AllowParentOverrides = false;
            this.ControlResName.AutoEllipsis = true;
            this.ControlResName.AutoSize = false;
            this.ControlResName.Cursor = System.Windows.Forms.Cursors.Default;
            this.ControlResName.CursorType = System.Windows.Forms.Cursors.Default;
            this.ControlResName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlResName.Location = new System.Drawing.Point(273, 14);
            this.ControlResName.Name = "ControlResName";
            this.ControlResName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ControlResName.Size = new System.Drawing.Size(315, 43);
            this.ControlResName.TabIndex = 1;
            this.ControlResName.Text = "bunifuLabel1";
            this.ControlResName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.ControlResName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ControlResAddress
            // 
            this.ControlResAddress.AllowParentOverrides = false;
            this.ControlResAddress.AutoEllipsis = true;
            this.ControlResAddress.AutoSize = false;
            this.ControlResAddress.Cursor = System.Windows.Forms.Cursors.Default;
            this.ControlResAddress.CursorType = System.Windows.Forms.Cursors.Default;
            this.ControlResAddress.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlResAddress.Location = new System.Drawing.Point(273, 63);
            this.ControlResAddress.Name = "ControlResAddress";
            this.ControlResAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ControlResAddress.Size = new System.Drawing.Size(274, 37);
            this.ControlResAddress.TabIndex = 2;
            this.ControlResAddress.Text = "bunifuLabel2";
            this.ControlResAddress.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.ControlResAddress.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ControlRate
            // 
            this.ControlRate.AllowParentOverrides = false;
            this.ControlRate.AutoEllipsis = true;
            this.ControlRate.AutoSize = false;
            this.ControlRate.Cursor = System.Windows.Forms.Cursors.Default;
            this.ControlRate.CursorType = System.Windows.Forms.Cursors.Default;
            this.ControlRate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlRate.Location = new System.Drawing.Point(453, 106);
            this.ControlRate.Name = "ControlRate";
            this.ControlRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ControlRate.Size = new System.Drawing.Size(135, 33);
            this.ControlRate.TabIndex = 4;
            this.ControlRate.Text = "bunifuLabel1";
            this.ControlRate.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.ControlRate.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ControlRateImage
            // 
            this.ControlRateImage.Location = new System.Drawing.Point(273, 106);
            this.ControlRateImage.Name = "ControlRateImage";
            this.ControlRateImage.Size = new System.Drawing.Size(162, 33);
            this.ControlRateImage.TabIndex = 3;
            this.ControlRateImage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ResDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ControlRate);
            this.Controls.Add(this.ControlRateImage);
            this.Controls.Add(this.ControlResAddress);
            this.Controls.Add(this.ControlResName);
            this.Name = "ResDetail";
            this.Size = new System.Drawing.Size(957, 244);
            this.DoubleClick += new System.EventHandler(this.ResDetail_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.ControlRateImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel ControlResName;
        private Bunifu.UI.WinForms.BunifuLabel ControlResAddress;
        private System.Windows.Forms.PictureBox ControlRateImage;
        private Bunifu.UI.WinForms.BunifuLabel ControlRate;
    }
}
