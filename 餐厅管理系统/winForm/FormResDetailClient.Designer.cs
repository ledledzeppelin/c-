using System.Drawing;

namespace 餐厅管理系统.winForm
{
    partial class FormResDetailClient
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabelAddress = new MetroFramework.Controls.MetroLabel();
            this.pictureBoxRate = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelRate = new MetroFramework.Controls.MetroLabel();
            this.MetroResName = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.commentPanel1 = new 餐厅管理系统.controls.CommentPanel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRate)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel1.Controls.Add(this.metroLabelAddress);
            this.metroPanel1.Controls.Add(this.pictureBoxRate);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroLabelRate);
            this.metroPanel1.Controls.Add(this.MetroResName);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 132);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1381, 199);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabelAddress
            // 
            this.metroLabelAddress.AutoSize = true;
            this.metroLabelAddress.Location = new System.Drawing.Point(77, 104);
            this.metroLabelAddress.Name = "metroLabelAddress";
            this.metroLabelAddress.Size = new System.Drawing.Size(83, 19);
            this.metroLabelAddress.TabIndex = 6;
            this.metroLabelAddress.Text = "metroLabel2";
            // 
            // pictureBoxRate
            // 
            this.pictureBoxRate.Location = new System.Drawing.Point(20, 51);
            this.pictureBoxRate.Name = "pictureBoxRate";
            this.pictureBoxRate.Size = new System.Drawing.Size(175, 25);
            this.pictureBoxRate.TabIndex = 3;
            this.pictureBoxRate.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 104);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "地址：";
            // 
            // metroLabelRate
            // 
            this.metroLabelRate.AutoSize = true;
            this.metroLabelRate.Location = new System.Drawing.Point(250, 57);
            this.metroLabelRate.Name = "metroLabelRate";
            this.metroLabelRate.Size = new System.Drawing.Size(81, 19);
            this.metroLabelRate.TabIndex = 4;
            this.metroLabelRate.Text = "metroLabel1";
            // 
            // MetroResName
            // 
            this.MetroResName.AutoSize = true;
            this.MetroResName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MetroResName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.MetroResName.Location = new System.Drawing.Point(20, 10);
            this.MetroResName.Name = "MetroResName";
            this.MetroResName.Size = new System.Drawing.Size(118, 25);
            this.MetroResName.TabIndex = 2;
            this.MetroResName.Text = "metroLabel1";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(20, 385);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1384, 215);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(23, 358);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 24);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "推荐菜";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // commentPanel1
            // 
            this.commentPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commentPanel1.Comment = null;
            this.commentPanel1.Image = null;
            this.commentPanel1.Location = new System.Drawing.Point(20, 623);
            this.commentPanel1.Name = "commentPanel1";
            this.commentPanel1.NickName = null;
            this.commentPanel1.Rate = 5;
            this.commentPanel1.Size = new System.Drawing.Size(1384, 690);
            this.commentPanel1.TabIndex = 5;
            // 
            // FormResDetailClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 1349);
            this.Controls.Add(this.commentPanel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FormResDetailClient";
            this.RightToLeftLayout = true;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel MetroResName;
        private System.Windows.Forms.PictureBox pictureBoxRate;
        private MetroFramework.Controls.MetroLabel metroLabelRate;
        private MetroFramework.Controls.MetroLabel metroLabelAddress;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private controls.CommentPanel commentPanel1;
    }
}