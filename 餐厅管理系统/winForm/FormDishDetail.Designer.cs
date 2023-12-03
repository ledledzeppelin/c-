namespace 餐厅管理系统.winForm
{
    partial class FormDishDetail
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.txtDishName = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.txtResName = new Sunny.UI.UITextBox();
            this.txtDishPrice = new Sunny.UI.UITextBox();
            this.pbxPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPic)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.Black;
            this.uiLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel1.Location = new System.Drawing.Point(18, 12);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(112, 23);
            this.uiLabel1.TabIndex = 6;
            this.uiLabel1.Text = "菜品信息";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel9
            // 
            this.uiLabel9.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel9.Location = new System.Drawing.Point(22, 154);
            this.uiLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(90, 20);
            this.uiLabel9.TabIndex = 17;
            this.uiLabel9.Text = "菜品名称：";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDishName
            // 
            this.txtDishName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDishName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDishName.Location = new System.Drawing.Point(118, 154);
            this.txtDishName.MinimumSize = new System.Drawing.Size(1, 10);
            this.txtDishName.Name = "txtDishName";
            this.txtDishName.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.txtDishName.ShowText = false;
            this.txtDishName.Size = new System.Drawing.Size(113, 20);
            this.txtDishName.TabIndex = 16;
            this.txtDishName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDishName.Watermark = "";
            // 
            // uiLabel7
            // 
            this.uiLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel7.Location = new System.Drawing.Point(28, 210);
            this.uiLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(84, 20);
            this.uiLabel7.TabIndex = 15;
            this.uiLabel7.Text = "所属餐厅：";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel8
            // 
            this.uiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel8.Location = new System.Drawing.Point(25, 182);
            this.uiLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(87, 20);
            this.uiLabel8.TabIndex = 14;
            this.uiLabel8.Text = "菜品价格：";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResName
            // 
            this.txtResName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResName.DecimalPlaces = 4;
            this.txtResName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtResName.Location = new System.Drawing.Point(118, 210);
            this.txtResName.MinimumSize = new System.Drawing.Size(1, 10);
            this.txtResName.Name = "txtResName";
            this.txtResName.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.txtResName.ShowText = false;
            this.txtResName.Size = new System.Drawing.Size(113, 20);
            this.txtResName.TabIndex = 13;
            this.txtResName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtResName.Watermark = "";
            // 
            // txtDishPrice
            // 
            this.txtDishPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDishPrice.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDishPrice.Location = new System.Drawing.Point(118, 182);
            this.txtDishPrice.MinimumSize = new System.Drawing.Size(1, 10);
            this.txtDishPrice.Name = "txtDishPrice";
            this.txtDishPrice.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.txtDishPrice.ShowText = false;
            this.txtDishPrice.Size = new System.Drawing.Size(113, 20);
            this.txtDishPrice.TabIndex = 12;
            this.txtDishPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDishPrice.Watermark = "";
            // 
            // pbxPic
            // 
            this.pbxPic.Location = new System.Drawing.Point(250, 110);
            this.pbxPic.Margin = new System.Windows.Forms.Padding(2);
            this.pbxPic.Name = "pbxPic";
            this.pbxPic.Size = new System.Drawing.Size(223, 185);
            this.pbxPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPic.TabIndex = 18;
            this.pbxPic.TabStop = false;
            // 
            // FormDishDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 400);
            this.Controls.Add(this.pbxPic);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.txtDishName);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.txtResName);
            this.Controls.Add(this.txtDishPrice);
            this.Controls.Add(this.uiLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDishDetail";
            this.Text = "FormDishDetail";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UITextBox txtDishName;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UITextBox txtResName;
        private Sunny.UI.UITextBox txtDishPrice;
        private System.Windows.Forms.PictureBox pbxPic;
    }
}