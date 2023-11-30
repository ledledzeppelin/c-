namespace 餐厅管理系统
{
    partial class CommentControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentControl));
            this.userNickName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelComment = new System.Windows.Forms.Label();
            this.ControlRate = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlRate)).BeginInit();
            this.SuspendLayout();
            // 
            // userNickName
            // 
            this.userNickName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userNickName.AutoEllipsis = true;
            this.userNickName.Font = new System.Drawing.Font("微软雅黑", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userNickName.Location = new System.Drawing.Point(3, 177);
            this.userNickName.Name = "userNickName";
            this.userNickName.Size = new System.Drawing.Size(180, 57);
            this.userNickName.TabIndex = 0;
            this.userNickName.Text = "昵称";
            this.userNickName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 174);
            this.panel1.TabIndex = 3;
            // 
            // labelComment
            // 
            this.labelComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelComment.AutoEllipsis = true;
            this.labelComment.Location = new System.Drawing.Point(219, 65);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(755, 155);
            this.labelComment.TabIndex = 2;
            this.labelComment.Text = "一些评论";
            // 
            // ControlRate
            // 
            this.ControlRate.BackColor = System.Drawing.Color.Transparent;
            this.ControlRate.Location = new System.Drawing.Point(219, 4);
            this.ControlRate.Name = "ControlRate";
            this.ControlRate.Size = new System.Drawing.Size(234, 44);
            this.ControlRate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ControlRate.TabIndex = 4;
            this.ControlRate.TabStop = false;
            // 
            // CommentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ControlRate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.userNickName);
            this.Name = "CommentControl";
            this.Size = new System.Drawing.Size(1002, 234);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ControlRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label userNickName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.PictureBox ControlRate;
    }
}
