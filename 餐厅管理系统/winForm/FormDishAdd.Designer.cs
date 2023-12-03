namespace 餐厅管理系统.winForm
{
    partial class FormDishAdd
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
            this.btnSelectPic = new System.Windows.Forms.Button();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.txtPrice = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.txtName = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.cbxType = new Sunny.UI.UIComboBox();
            this.btnAdd = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // btnSelectPic
            // 
            this.btnSelectPic.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectPic.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnSelectPic.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelectPic.Location = new System.Drawing.Point(109, 148);
            this.btnSelectPic.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectPic.Name = "btnSelectPic";
            this.btnSelectPic.Size = new System.Drawing.Size(152, 138);
            this.btnSelectPic.TabIndex = 20;
            this.btnSelectPic.Text = "点击选择图片";
            this.btnSelectPic.UseVisualStyleBackColor = false;
            this.btnSelectPic.Click += new System.EventHandler(this.btnSelectPic_Click);
            // 
            // uiLabel12
            // 
            this.uiLabel12.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel12.Location = new System.Drawing.Point(8, 142);
            this.uiLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(94, 20);
            this.uiLabel12.TabIndex = 22;
            this.uiLabel12.Text = "选择图片：";
            this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel9
            // 
            this.uiLabel9.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel9.Location = new System.Drawing.Point(35, 57);
            this.uiLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(67, 20);
            this.uiLabel9.TabIndex = 19;
            this.uiLabel9.Text = "价格：";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPrice.Location = new System.Drawing.Point(109, 57);
            this.txtPrice.MinimumSize = new System.Drawing.Size(1, 10);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Padding = new System.Windows.Forms.Padding(3);
            this.txtPrice.ShowText = false;
            this.txtPrice.Size = new System.Drawing.Size(152, 20);
            this.txtPrice.TabIndex = 18;
            this.txtPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPrice.Watermark = "";
            // 
            // uiLabel7
            // 
            this.uiLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel7.Location = new System.Drawing.Point(22, 115);
            this.uiLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(80, 20);
            this.uiLabel7.TabIndex = 17;
            this.uiLabel7.Text = "所属餐厅：";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel8
            // 
            this.uiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel8.Location = new System.Drawing.Point(35, 86);
            this.uiLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(67, 20);
            this.uiLabel8.TabIndex = 16;
            this.uiLabel8.Text = "菜品：";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(109, 86);
            this.txtName.MinimumSize = new System.Drawing.Size(1, 10);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(3);
            this.txtName.ShowText = false;
            this.txtName.Size = new System.Drawing.Size(152, 20);
            this.txtName.TabIndex = 14;
            this.txtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtName.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.Black;
            this.uiLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel1.Location = new System.Drawing.Point(18, 13);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(112, 23);
            this.uiLabel1.TabIndex = 23;
            this.uiLabel1.Text = "添加菜品";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxType
            // 
            this.cbxType.DataSource = null;
            this.cbxType.FillColor = System.Drawing.Color.White;
            this.cbxType.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cbxType.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbxType.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbxType.Location = new System.Drawing.Point(109, 114);
            this.cbxType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxType.Name = "cbxType";
            this.cbxType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbxType.Size = new System.Drawing.Size(152, 23);
            this.cbxType.TabIndex = 24;
            this.cbxType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxType.Watermark = "";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(95, 299);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 31);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "添加";
            this.btnAdd.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormDishAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 342);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.btnSelectPic);
            this.Controls.Add(this.uiLabel12);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.txtName);
            this.Name = "FormDishAdd";
            this.Text = "FormDishAdd";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectPic;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UITextBox txtPrice;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UITextBox txtName;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox cbxType;
        private Sunny.UI.UIButton btnAdd;
    }
}