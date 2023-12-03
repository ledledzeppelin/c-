namespace 餐厅管理系统.winForm
{
    partial class FormMultLogin
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnLoginAdmin = new Sunny.UI.UIButton();
            this.txtAdminPsd = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.btnReg = new Sunny.UI.UIButton();
            this.btnLogin = new Sunny.UI.UIButton();
            this.txtPassword = new Sunny.UI.UITextBox();
            this.cbxType = new Sunny.UI.UIComboBox();
            this.txtUser = new Sunny.UI.UITextBox();
            this.pnlRegUser = new System.Windows.Forms.Panel();
            this.btnUserPic = new System.Windows.Forms.Button();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.txtRegUserAdd = new Sunny.UI.UITextBox();
            this.txtRegUserCPsd = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.txtRegUserPsd = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.btnBackLogin = new Sunny.UI.UIButton();
            this.btnRegUser = new Sunny.UI.UIButton();
            this.txtRegUseNickName = new Sunny.UI.UITextBox();
            this.txtRegUserAcc = new Sunny.UI.UITextBox();
            this.pnlRegRes = new System.Windows.Forms.Panel();
            this.btnSelectPic = new System.Windows.Forms.Button();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.txtRegResAdd = new Sunny.UI.UITextBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.txtRegResName = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiButton8 = new Sunny.UI.UIButton();
            this.btnRegRes = new Sunny.UI.UIButton();
            this.txtRegResPsd = new Sunny.UI.UITextBox();
            this.txtRegResAcc = new Sunny.UI.UITextBox();
            this.uiLabel13 = new Sunny.UI.UILabel();
            this.pnlLogin.SuspendLayout();
            this.pnlRegUser.SuspendLayout();
            this.pnlRegRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(977, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 32);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(1017, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 32);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlLogin.Controls.Add(this.btnLoginAdmin);
            this.pnlLogin.Controls.Add(this.txtAdminPsd);
            this.pnlLogin.Controls.Add(this.uiLabel3);
            this.pnlLogin.Controls.Add(this.uiLabel2);
            this.pnlLogin.Controls.Add(this.uiLabel1);
            this.pnlLogin.Controls.Add(this.btnReg);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.cbxType);
            this.pnlLogin.Controls.Add(this.txtUser);
            this.pnlLogin.Location = new System.Drawing.Point(0, 203);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(1067, 250);
            this.pnlLogin.TabIndex = 2;
            // 
            // btnLoginAdmin
            // 
            this.btnLoginAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginAdmin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLoginAdmin.Location = new System.Drawing.Point(588, 128);
            this.btnLoginAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoginAdmin.MinimumSize = new System.Drawing.Size(2, 2);
            this.btnLoginAdmin.Name = "btnLoginAdmin";
            this.btnLoginAdmin.Size = new System.Drawing.Size(200, 25);
            this.btnLoginAdmin.TabIndex = 9;
            this.btnLoginAdmin.Text = "点击进入管理员模式";
            this.btnLoginAdmin.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLoginAdmin.Click += new System.EventHandler(this.btnLoginAdmin_Click);
            // 
            // txtAdminPsd
            // 
            this.txtAdminPsd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdminPsd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAdminPsd.Location = new System.Drawing.Point(588, 82);
            this.txtAdminPsd.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtAdminPsd.MinimumSize = new System.Drawing.Size(2, 12);
            this.txtAdminPsd.Name = "txtAdminPsd";
            this.txtAdminPsd.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAdminPsd.PasswordChar = '*';
            this.txtAdminPsd.ShowText = false;
            this.txtAdminPsd.Size = new System.Drawing.Size(200, 25);
            this.txtAdminPsd.TabIndex = 3;
            this.txtAdminPsd.TagString = "";
            this.txtAdminPsd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAdminPsd.Watermark = "输入管理员密钥";
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel3.Location = new System.Drawing.Point(213, 118);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(89, 25);
            this.uiLabel3.TabIndex = 8;
            this.uiLabel3.Text = "密码：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel2.Location = new System.Drawing.Point(213, 83);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(89, 25);
            this.uiLabel2.TabIndex = 7;
            this.uiLabel2.Text = "用户：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel1.Location = new System.Drawing.Point(213, 50);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(89, 25);
            this.uiLabel1.TabIndex = 6;
            this.uiLabel1.Text = "类型：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnReg
            // 
            this.btnReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReg.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReg.Location = new System.Drawing.Point(373, 175);
            this.btnReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReg.MinimumSize = new System.Drawing.Size(2, 2);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(89, 25);
            this.btnReg.TabIndex = 5;
            this.btnReg.Text = "注册";
            this.btnReg.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.Location = new System.Drawing.Point(240, 175);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.MinimumSize = new System.Drawing.Size(2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(89, 25);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登录";
            this.btnLogin.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DecimalPlaces = 4;
            this.txtPassword.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassword.Location = new System.Drawing.Point(311, 118);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtPassword.MinimumSize = new System.Drawing.Size(2, 12);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ShowText = false;
            this.txtPassword.Size = new System.Drawing.Size(151, 25);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPassword.Watermark = "";
            // 
            // cbxType
            // 
            this.cbxType.DataSource = null;
            this.cbxType.FillColor = System.Drawing.Color.White;
            this.cbxType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxType.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbxType.Items.AddRange(new object[] {
            "用户",
            "餐厅"});
            this.cbxType.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbxType.Location = new System.Drawing.Point(311, 50);
            this.cbxType.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.cbxType.MinimumSize = new System.Drawing.Size(56, 0);
            this.cbxType.Name = "cbxType";
            this.cbxType.Padding = new System.Windows.Forms.Padding(0, 0, 40, 2);
            this.cbxType.Size = new System.Drawing.Size(151, 25);
            this.cbxType.TabIndex = 3;
            this.cbxType.Text = "用户";
            this.cbxType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxType.Watermark = "";
            // 
            // txtUser
            // 
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUser.Location = new System.Drawing.Point(311, 84);
            this.txtUser.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtUser.MinimumSize = new System.Drawing.Size(2, 12);
            this.txtUser.Name = "txtUser";
            this.txtUser.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUser.ShowText = false;
            this.txtUser.Size = new System.Drawing.Size(151, 25);
            this.txtUser.TabIndex = 0;
            this.txtUser.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtUser.Watermark = "";
            // 
            // pnlRegUser
            // 
            this.pnlRegUser.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlRegUser.Controls.Add(this.btnUserPic);
            this.pnlRegUser.Controls.Add(this.uiLabel11);
            this.pnlRegUser.Controls.Add(this.uiLabel10);
            this.pnlRegUser.Controls.Add(this.txtRegUserAdd);
            this.pnlRegUser.Controls.Add(this.txtRegUserCPsd);
            this.pnlRegUser.Controls.Add(this.uiLabel6);
            this.pnlRegUser.Controls.Add(this.uiLabel4);
            this.pnlRegUser.Controls.Add(this.txtRegUserPsd);
            this.pnlRegUser.Controls.Add(this.uiLabel5);
            this.pnlRegUser.Controls.Add(this.btnBackLogin);
            this.pnlRegUser.Controls.Add(this.btnRegUser);
            this.pnlRegUser.Controls.Add(this.txtRegUseNickName);
            this.pnlRegUser.Controls.Add(this.txtRegUserAcc);
            this.pnlRegUser.Location = new System.Drawing.Point(0, 203);
            this.pnlRegUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRegUser.Name = "pnlRegUser";
            this.pnlRegUser.Size = new System.Drawing.Size(1067, 250);
            this.pnlRegUser.TabIndex = 10;
            this.pnlRegUser.Visible = false;
            // 
            // btnUserPic
            // 
            this.btnUserPic.BackColor = System.Drawing.Color.Transparent;
            this.btnUserPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserPic.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUserPic.Location = new System.Drawing.Point(569, 42);
            this.btnUserPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserPic.Name = "btnUserPic";
            this.btnUserPic.Size = new System.Drawing.Size(203, 172);
            this.btnUserPic.TabIndex = 13;
            this.btnUserPic.Text = "点击选择头像";
            this.btnUserPic.UseVisualStyleBackColor = false;
            this.btnUserPic.Click += new System.EventHandler(this.btnUserPic_Click);
            // 
            // uiLabel11
            // 
            this.uiLabel11.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel11.Location = new System.Drawing.Point(265, 165);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(89, 25);
            this.uiLabel11.TabIndex = 12;
            this.uiLabel11.Text = "地址：";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel10
            // 
            this.uiLabel10.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel10.Location = new System.Drawing.Point(196, 132);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(158, 25);
            this.uiLabel10.TabIndex = 12;
            this.uiLabel10.Text = "确认密码：";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRegUserAdd
            // 
            this.txtRegUserAdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegUserAdd.DecimalPlaces = 4;
            this.txtRegUserAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRegUserAdd.Location = new System.Drawing.Point(363, 165);
            this.txtRegUserAdd.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtRegUserAdd.MinimumSize = new System.Drawing.Size(2, 12);
            this.txtRegUserAdd.Name = "txtRegUserAdd";
            this.txtRegUserAdd.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRegUserAdd.ShowText = false;
            this.txtRegUserAdd.Size = new System.Drawing.Size(151, 25);
            this.txtRegUserAdd.TabIndex = 11;
            this.txtRegUserAdd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRegUserAdd.Watermark = "";
            // 
            // txtRegUserCPsd
            // 
            this.txtRegUserCPsd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegUserCPsd.DecimalPlaces = 4;
            this.txtRegUserCPsd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRegUserCPsd.Location = new System.Drawing.Point(363, 132);
            this.txtRegUserCPsd.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtRegUserCPsd.MinimumSize = new System.Drawing.Size(2, 12);
            this.txtRegUserCPsd.Name = "txtRegUserCPsd";
            this.txtRegUserCPsd.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRegUserCPsd.PasswordChar = '*';
            this.txtRegUserCPsd.ShowText = false;
            this.txtRegUserCPsd.Size = new System.Drawing.Size(151, 25);
            this.txtRegUserCPsd.TabIndex = 11;
            this.txtRegUserCPsd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRegUserCPsd.Watermark = "";
            // 
            // uiLabel6
            // 
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel6.Location = new System.Drawing.Point(265, 98);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(89, 25);
            this.uiLabel6.TabIndex = 10;
            this.uiLabel6.Text = "密码：";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel4.Location = new System.Drawing.Point(265, 65);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(89, 25);
            this.uiLabel4.TabIndex = 8;
            this.uiLabel4.Text = "昵称：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRegUserPsd
            // 
            this.txtRegUserPsd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegUserPsd.DecimalPlaces = 4;
            this.txtRegUserPsd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRegUserPsd.Location = new System.Drawing.Point(363, 98);
            this.txtRegUserPsd.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtRegUserPsd.MinimumSize = new System.Drawing.Size(2, 12);
            this.txtRegUserPsd.Name = "txtRegUserPsd";
            this.txtRegUserPsd.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRegUserPsd.PasswordChar = '*';
            this.txtRegUserPsd.ShowText = false;
            this.txtRegUserPsd.Size = new System.Drawing.Size(151, 25);
            this.txtRegUserPsd.TabIndex = 9;
            this.txtRegUserPsd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRegUserPsd.Watermark = "";
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel5.Location = new System.Drawing.Point(265, 32);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(89, 25);
            this.uiLabel5.TabIndex = 7;
            this.uiLabel5.Text = "账号：";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBackLogin
            // 
            this.btnBackLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackLogin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBackLogin.Location = new System.Drawing.Point(425, 205);
            this.btnBackLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackLogin.MinimumSize = new System.Drawing.Size(2, 2);
            this.btnBackLogin.Name = "btnBackLogin";
            this.btnBackLogin.Size = new System.Drawing.Size(89, 25);
            this.btnBackLogin.TabIndex = 5;
            this.btnBackLogin.Text = "继续登录";
            this.btnBackLogin.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBackLogin.Click += new System.EventHandler(this.btnBackLogin_Click);
            // 
            // btnRegUser
            // 
            this.btnRegUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegUser.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRegUser.Location = new System.Drawing.Point(292, 205);
            this.btnRegUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegUser.MinimumSize = new System.Drawing.Size(2, 2);
            this.btnRegUser.Name = "btnRegUser";
            this.btnRegUser.Size = new System.Drawing.Size(89, 25);
            this.btnRegUser.TabIndex = 4;
            this.btnRegUser.Text = "注册";
            this.btnRegUser.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRegUser.Click += new System.EventHandler(this.btnRegUser_Click);
            // 
            // txtRegUseNickName
            // 
            this.txtRegUseNickName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegUseNickName.DecimalPlaces = 4;
            this.txtRegUseNickName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRegUseNickName.Location = new System.Drawing.Point(363, 65);
            this.txtRegUseNickName.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtRegUseNickName.MinimumSize = new System.Drawing.Size(2, 12);
            this.txtRegUseNickName.Name = "txtRegUseNickName";
            this.txtRegUseNickName.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRegUseNickName.ShowText = false;
            this.txtRegUseNickName.Size = new System.Drawing.Size(151, 25);
            this.txtRegUseNickName.TabIndex = 3;
            this.txtRegUseNickName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRegUseNickName.Watermark = "";
            // 
            // txtRegUserAcc
            // 
            this.txtRegUserAcc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegUserAcc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRegUserAcc.Location = new System.Drawing.Point(363, 32);
            this.txtRegUserAcc.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtRegUserAcc.MinimumSize = new System.Drawing.Size(2, 12);
            this.txtRegUserAcc.Name = "txtRegUserAcc";
            this.txtRegUserAcc.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRegUserAcc.ShowText = false;
            this.txtRegUserAcc.Size = new System.Drawing.Size(151, 25);
            this.txtRegUserAcc.TabIndex = 0;
            this.txtRegUserAcc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRegUserAcc.Watermark = "";
            // 
            // pnlRegRes
            // 
            this.pnlRegRes.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlRegRes.Controls.Add(this.btnSelectPic);
            this.pnlRegRes.Controls.Add(this.uiLabel12);
            this.pnlRegRes.Controls.Add(this.txtRegResAdd);
            this.pnlRegRes.Controls.Add(this.uiLabel9);
            this.pnlRegRes.Controls.Add(this.txtRegResName);
            this.pnlRegRes.Controls.Add(this.uiLabel7);
            this.pnlRegRes.Controls.Add(this.uiLabel8);
            this.pnlRegRes.Controls.Add(this.uiButton8);
            this.pnlRegRes.Controls.Add(this.btnRegRes);
            this.pnlRegRes.Controls.Add(this.txtRegResPsd);
            this.pnlRegRes.Controls.Add(this.txtRegResAcc);
            this.pnlRegRes.Location = new System.Drawing.Point(0, 203);
            this.pnlRegRes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRegRes.Name = "pnlRegRes";
            this.pnlRegRes.Size = new System.Drawing.Size(1067, 250);
            this.pnlRegRes.TabIndex = 11;
            this.pnlRegRes.Visible = false;
            // 
            // btnSelectPic
            // 
            this.btnSelectPic.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectPic.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelectPic.Location = new System.Drawing.Point(576, 45);
            this.btnSelectPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectPic.Name = "btnSelectPic";
            this.btnSelectPic.Size = new System.Drawing.Size(203, 172);
            this.btnSelectPic.TabIndex = 12;
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
            this.uiLabel12.Location = new System.Drawing.Point(231, 148);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(89, 25);
            this.uiLabel12.TabIndex = 13;
            this.uiLabel12.Text = "地址：";
            this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRegResAdd
            // 
            this.txtRegResAdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegResAdd.DecimalPlaces = 4;
            this.txtRegResAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRegResAdd.Location = new System.Drawing.Point(329, 148);
            this.txtRegResAdd.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtRegResAdd.MinimumSize = new System.Drawing.Size(2, 12);
            this.txtRegResAdd.Name = "txtRegResAdd";
            this.txtRegResAdd.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRegResAdd.ShowText = false;
            this.txtRegResAdd.Size = new System.Drawing.Size(151, 25);
            this.txtRegResAdd.TabIndex = 12;
            this.txtRegResAdd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRegResAdd.Watermark = "";
            // 
            // uiLabel9
            // 
            this.uiLabel9.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel9.Location = new System.Drawing.Point(231, 47);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(89, 25);
            this.uiLabel9.TabIndex = 11;
            this.uiLabel9.Text = "餐厅：";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRegResName
            // 
            this.txtRegResName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegResName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRegResName.Location = new System.Drawing.Point(329, 47);
            this.txtRegResName.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtRegResName.MinimumSize = new System.Drawing.Size(2, 12);
            this.txtRegResName.Name = "txtRegResName";
            this.txtRegResName.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRegResName.ShowText = false;
            this.txtRegResName.Size = new System.Drawing.Size(151, 25);
            this.txtRegResName.TabIndex = 10;
            this.txtRegResName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRegResName.Watermark = "";
            // 
            // uiLabel7
            // 
            this.uiLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel7.Location = new System.Drawing.Point(231, 115);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(89, 25);
            this.uiLabel7.TabIndex = 8;
            this.uiLabel7.Text = "密码：";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel8
            // 
            this.uiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel8.Location = new System.Drawing.Point(231, 82);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(89, 25);
            this.uiLabel8.TabIndex = 7;
            this.uiLabel8.Text = "账号：";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiButton8
            // 
            this.uiButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton8.Location = new System.Drawing.Point(391, 192);
            this.uiButton8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiButton8.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiButton8.Name = "uiButton8";
            this.uiButton8.Size = new System.Drawing.Size(89, 25);
            this.uiButton8.TabIndex = 5;
            this.uiButton8.Text = "继续登录";
            this.uiButton8.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton8.Click += new System.EventHandler(this.btnBackLogin_Click);
            // 
            // btnRegRes
            // 
            this.btnRegRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegRes.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRegRes.Location = new System.Drawing.Point(259, 192);
            this.btnRegRes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegRes.MinimumSize = new System.Drawing.Size(2, 2);
            this.btnRegRes.Name = "btnRegRes";
            this.btnRegRes.Size = new System.Drawing.Size(89, 25);
            this.btnRegRes.TabIndex = 4;
            this.btnRegRes.Text = "注册";
            this.btnRegRes.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRegRes.Click += new System.EventHandler(this.btnRegRes_Click);
            // 
            // txtRegResPsd
            // 
            this.txtRegResPsd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegResPsd.DecimalPlaces = 4;
            this.txtRegResPsd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRegResPsd.Location = new System.Drawing.Point(329, 115);
            this.txtRegResPsd.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtRegResPsd.MinimumSize = new System.Drawing.Size(2, 12);
            this.txtRegResPsd.Name = "txtRegResPsd";
            this.txtRegResPsd.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRegResPsd.PasswordChar = '*';
            this.txtRegResPsd.ShowText = false;
            this.txtRegResPsd.Size = new System.Drawing.Size(151, 25);
            this.txtRegResPsd.TabIndex = 3;
            this.txtRegResPsd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRegResPsd.Watermark = "";
            // 
            // txtRegResAcc
            // 
            this.txtRegResAcc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegResAcc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRegResAcc.Location = new System.Drawing.Point(329, 82);
            this.txtRegResAcc.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtRegResAcc.MinimumSize = new System.Drawing.Size(2, 12);
            this.txtRegResAcc.Name = "txtRegResAcc";
            this.txtRegResAcc.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRegResAcc.ShowText = false;
            this.txtRegResAcc.Size = new System.Drawing.Size(151, 25);
            this.txtRegResAcc.TabIndex = 0;
            this.txtRegResAcc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRegResAcc.Watermark = "";
            // 
            // uiLabel13
            // 
            this.uiLabel13.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel13.ForeColor = System.Drawing.Color.White;
            this.uiLabel13.Location = new System.Drawing.Point(27, 12);
            this.uiLabel13.Name = "uiLabel13";
            this.uiLabel13.Size = new System.Drawing.Size(100, 22);
            this.uiLabel13.TabIndex = 12;
            this.uiLabel13.Text = "登录";
            this.uiLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormMultLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.BackgroundImage = global::餐厅管理系统.Properties.Resources.bak;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 667);
            this.Controls.Add(this.uiLabel13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlRegRes);
            this.Controls.Add(this.pnlRegUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMultLogin";
            this.Text = "FormMultLogin";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMultLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMultLogin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMultLogin_MouseUp);
            this.pnlLogin.ResumeLayout(false);
            this.pnlRegUser.ResumeLayout(false);
            this.pnlRegRes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlLogin;
        private Sunny.UI.UITextBox txtUser;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UIComboBox cbxType;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton btnReg;
        private Sunny.UI.UIButton btnLogin;
        private Sunny.UI.UIButton btnLoginAdmin;
        private Sunny.UI.UITextBox txtAdminPsd;
        private System.Windows.Forms.Panel pnlRegUser;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIButton btnBackLogin;
        private Sunny.UI.UIButton btnRegUser;
        private Sunny.UI.UITextBox txtRegUseNickName;
        private Sunny.UI.UITextBox txtRegUserAcc;
        private System.Windows.Forms.Panel pnlRegRes;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UIButton uiButton8;
        private Sunny.UI.UIButton btnRegRes;
        private Sunny.UI.UITextBox txtRegResPsd;
        private Sunny.UI.UITextBox txtRegResAcc;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UITextBox txtRegUserAdd;
        private Sunny.UI.UITextBox txtRegUserCPsd;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox txtRegUserPsd;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UITextBox txtRegResAdd;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UITextBox txtRegResName;
        private System.Windows.Forms.Button btnSelectPic;
        private Sunny.UI.UILabel uiLabel13;
        private System.Windows.Forms.Button btnUserPic;
    }
}