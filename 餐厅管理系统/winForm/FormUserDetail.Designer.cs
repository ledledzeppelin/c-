namespace 餐厅管理系统.winForm
{
    partial class FormUserDetail
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
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.txtAcc = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.txtAdd = new Sunny.UI.UITextBox();
            this.txtName = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.pbxPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPic)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLabel9
            // 
            this.uiLabel9.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel9.Location = new System.Drawing.Point(29, 112);
            this.uiLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(90, 20);
            this.uiLabel9.TabIndex = 25;
            this.uiLabel9.Text = "用户账号：";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAcc
            // 
            this.txtAcc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAcc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAcc.Location = new System.Drawing.Point(125, 112);
            this.txtAcc.MinimumSize = new System.Drawing.Size(1, 10);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Padding = new System.Windows.Forms.Padding(3);
            this.txtAcc.ShowText = false;
            this.txtAcc.Size = new System.Drawing.Size(113, 20);
            this.txtAcc.TabIndex = 24;
            this.txtAcc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAcc.Watermark = "";
            // 
            // uiLabel7
            // 
            this.uiLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel7.Location = new System.Drawing.Point(35, 168);
            this.uiLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(84, 20);
            this.uiLabel7.TabIndex = 23;
            this.uiLabel7.Text = "用户地址：";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel8
            // 
            this.uiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel8.Location = new System.Drawing.Point(32, 140);
            this.uiLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(87, 20);
            this.uiLabel8.TabIndex = 22;
            this.uiLabel8.Text = "用户名：";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAdd
            // 
            this.txtAdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdd.DecimalPlaces = 4;
            this.txtAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAdd.Location = new System.Drawing.Point(125, 168);
            this.txtAdd.MinimumSize = new System.Drawing.Size(1, 10);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Padding = new System.Windows.Forms.Padding(3);
            this.txtAdd.ShowText = false;
            this.txtAdd.Size = new System.Drawing.Size(113, 20);
            this.txtAdd.TabIndex = 21;
            this.txtAdd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAdd.Watermark = "";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(125, 140);
            this.txtName.MinimumSize = new System.Drawing.Size(1, 10);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(3);
            this.txtName.ShowText = false;
            this.txtName.Size = new System.Drawing.Size(113, 20);
            this.txtName.TabIndex = 20;
            this.txtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtName.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.Black;
            this.uiLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel1.Location = new System.Drawing.Point(11, 9);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(112, 23);
            this.uiLabel1.TabIndex = 19;
            this.uiLabel1.Text = "用户信息";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbxPic
            // 
            this.pbxPic.Location = new System.Drawing.Point(264, 65);
            this.pbxPic.Margin = new System.Windows.Forms.Padding(2);
            this.pbxPic.Name = "pbxPic";
            this.pbxPic.Size = new System.Drawing.Size(223, 185);
            this.pbxPic.TabIndex = 26;
            this.pbxPic.TabStop = false;
            // 
            // FormUserDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 300);
            this.Controls.Add(this.pbxPic);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.txtAcc);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.uiLabel1);
            this.Name = "FormUserDetail";
            this.Text = "FormUserDetail";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxPic;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UITextBox txtAcc;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UITextBox txtAdd;
        private Sunny.UI.UITextBox txtName;
        private Sunny.UI.UILabel uiLabel1;
    }
}