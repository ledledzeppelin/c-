namespace 餐厅管理系统.controls
{
    partial class CommentPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentPanel));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.ControlImage = new System.Windows.Forms.PictureBox();
            this.ControlNickName = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ControlMyComment = new System.Windows.Forms.Label();
            this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextBox();
            this.ControlSubmit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.LabelRate = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ControlImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlImage
            // 
            this.ControlImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ControlImage.ErrorImage")));
            this.ControlImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("ControlImage.InitialImage")));
            this.ControlImage.Location = new System.Drawing.Point(36, 35);
            this.ControlImage.Name = "ControlImage";
            this.ControlImage.Size = new System.Drawing.Size(94, 88);
            this.ControlImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ControlImage.TabIndex = 1;
            this.ControlImage.TabStop = false;
            // 
            // ControlNickName
            // 
            this.ControlNickName.AutoEllipsis = true;
            this.ControlNickName.Font = new System.Drawing.Font("宋体", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ControlNickName.Location = new System.Drawing.Point(32, 140);
            this.ControlNickName.Name = "ControlNickName";
            this.ControlNickName.Size = new System.Drawing.Size(98, 57);
            this.ControlNickName.TabIndex = 2;
            this.ControlNickName.Text = "我的昵称";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 200);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1292, 303);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // ControlMyComment
            // 
            this.ControlMyComment.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ControlMyComment.AutoEllipsis = true;
            this.ControlMyComment.BackColor = System.Drawing.Color.Transparent;
            this.ControlMyComment.Location = new System.Drawing.Point(230, 30);
            this.ControlMyComment.Name = "ControlMyComment";
            this.ControlMyComment.Size = new System.Drawing.Size(1030, 108);
            this.ControlMyComment.TabIndex = 0;
            this.ControlMyComment.Text = "我的评论";
            this.ControlMyComment.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ControlMyComment_MouseClick);
            this.ControlMyComment.MouseEnter += new System.EventHandler(this.ControlMyComment_MouseEnter);
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.AcceptsReturn = false;
            this.bunifuTextBox1.AcceptsTab = false;
            this.bunifuTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTextBox1.AnimationSpeed = 200;
            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox1.AutoSizeHeight = true;
            this.bunifuTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.Silver;
            this.bunifuTextBox1.BorderRadius = 1;
            this.bunifuTextBox1.BorderThickness = 1;
            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.bunifuTextBox1.DefaultText = "";
            this.bunifuTextBox1.FillColor = System.Drawing.Color.White;
            this.bunifuTextBox1.HideSelection = true;
            this.bunifuTextBox1.IconLeft = null;
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.IconPadding = 10;
            this.bunifuTextBox1.IconRight = null;
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.Lines = new string[0];
            this.bunifuTextBox1.Location = new System.Drawing.Point(230, 30);
            this.bunifuTextBox1.MaxLength = 32767;
            this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.bunifuTextBox1.Modified = false;
            this.bunifuTextBox1.Multiline = true;
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bunifuTextBox1.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnIdleState = stateProperties4;
            this.bunifuTextBox1.Padding = new System.Windows.Forms.Padding(3);
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bunifuTextBox1.PlaceholderText = "Enter text";
            this.bunifuTextBox1.ReadOnly = false;
            this.bunifuTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.SelectionLength = 0;
            this.bunifuTextBox1.SelectionStart = 0;
            this.bunifuTextBox1.ShortcutsEnabled = true;
            this.bunifuTextBox1.Size = new System.Drawing.Size(1030, 108);
            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox1.TabIndex = 6;
            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox1.TextMarginBottom = 0;
            this.bunifuTextBox1.TextMarginLeft = 3;
            this.bunifuTextBox1.TextMarginTop = 1;
            this.bunifuTextBox1.TextPlaceholder = "Enter text";
            this.bunifuTextBox1.UseSystemPasswordChar = false;
            this.bunifuTextBox1.WordWrap = true;
            this.bunifuTextBox1.TextChange += new System.EventHandler(this.bunifuTextBox1_TextChange);
            // 
            // ControlSubmit
            // 
            this.ControlSubmit.AllowAnimations = true;
            this.ControlSubmit.AllowMouseEffects = true;
            this.ControlSubmit.AllowToggling = false;
            this.ControlSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlSubmit.AnimationSpeed = 200;
            this.ControlSubmit.AutoGenerateColors = false;
            this.ControlSubmit.AutoRoundBorders = false;
            this.ControlSubmit.AutoSizeLeftIcon = true;
            this.ControlSubmit.AutoSizeRightIcon = true;
            this.ControlSubmit.BackColor = System.Drawing.Color.Transparent;
            this.ControlSubmit.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.ControlSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ControlSubmit.BackgroundImage")));
            this.ControlSubmit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ControlSubmit.ButtonText = "提交";
            this.ControlSubmit.ButtonTextMarginLeft = 0;
            this.ControlSubmit.ColorContrastOnClick = 45;
            this.ControlSubmit.ColorContrastOnHover = 45;
            this.ControlSubmit.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.ControlSubmit.CustomizableEdges = borderEdges1;
            this.ControlSubmit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ControlSubmit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ControlSubmit.DisabledFillColor = System.Drawing.Color.Empty;
            this.ControlSubmit.DisabledForecolor = System.Drawing.Color.Empty;
            this.ControlSubmit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ControlSubmit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ControlSubmit.ForeColor = System.Drawing.Color.White;
            this.ControlSubmit.IconLeft = null;
            this.ControlSubmit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ControlSubmit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ControlSubmit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ControlSubmit.IconMarginLeft = 11;
            this.ControlSubmit.IconPadding = 10;
            this.ControlSubmit.IconRight = null;
            this.ControlSubmit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ControlSubmit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ControlSubmit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ControlSubmit.IconSize = 25;
            this.ControlSubmit.IdleBorderColor = System.Drawing.Color.Empty;
            this.ControlSubmit.IdleBorderRadius = 0;
            this.ControlSubmit.IdleBorderThickness = 0;
            this.ControlSubmit.IdleFillColor = System.Drawing.Color.Empty;
            this.ControlSubmit.IdleIconLeftImage = null;
            this.ControlSubmit.IdleIconRightImage = null;
            this.ControlSubmit.IndicateFocus = false;
            this.ControlSubmit.Location = new System.Drawing.Point(1153, 151);
            this.ControlSubmit.Name = "ControlSubmit";
            this.ControlSubmit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ControlSubmit.OnDisabledState.BorderRadius = 1;
            this.ControlSubmit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ControlSubmit.OnDisabledState.BorderThickness = 1;
            this.ControlSubmit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ControlSubmit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ControlSubmit.OnDisabledState.IconLeftImage = null;
            this.ControlSubmit.OnDisabledState.IconRightImage = null;
            this.ControlSubmit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.ControlSubmit.onHoverState.BorderRadius = 1;
            this.ControlSubmit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ControlSubmit.onHoverState.BorderThickness = 1;
            this.ControlSubmit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.ControlSubmit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.ControlSubmit.onHoverState.IconLeftImage = null;
            this.ControlSubmit.onHoverState.IconRightImage = null;
            this.ControlSubmit.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ControlSubmit.OnIdleState.BorderRadius = 1;
            this.ControlSubmit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ControlSubmit.OnIdleState.BorderThickness = 1;
            this.ControlSubmit.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.ControlSubmit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.ControlSubmit.OnIdleState.IconLeftImage = null;
            this.ControlSubmit.OnIdleState.IconRightImage = null;
            this.ControlSubmit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ControlSubmit.OnPressedState.BorderRadius = 1;
            this.ControlSubmit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ControlSubmit.OnPressedState.BorderThickness = 1;
            this.ControlSubmit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ControlSubmit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ControlSubmit.OnPressedState.IconLeftImage = null;
            this.ControlSubmit.OnPressedState.IconRightImage = null;
            this.ControlSubmit.Size = new System.Drawing.Size(107, 43);
            this.ControlSubmit.TabIndex = 0;
            this.ControlSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ControlSubmit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ControlSubmit.TextMarginLeft = 0;
            this.ControlSubmit.TextPadding = new System.Windows.Forms.Padding(0);
            this.ControlSubmit.UseDefaultRadiusAndThickness = true;
            this.ControlSubmit.Click += new System.EventHandler(this.ControlSubmit_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(234, 151);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(81, 36);
            this.bunifuLabel1.TabIndex = 7;
            this.bunifuLabel1.Text = "评分：";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LabelRate
            // 
            this.LabelRate.AcceptsReturn = false;
            this.LabelRate.AcceptsTab = false;
            this.LabelRate.AnimationSpeed = 200;
            this.LabelRate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.LabelRate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.LabelRate.AutoSizeHeight = true;
            this.LabelRate.BackColor = System.Drawing.Color.Transparent;
            this.LabelRate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LabelRate.BackgroundImage")));
            this.LabelRate.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.LabelRate.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.LabelRate.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.LabelRate.BorderColorIdle = System.Drawing.Color.Silver;
            this.LabelRate.BorderRadius = 1;
            this.LabelRate.BorderThickness = 1;
            this.LabelRate.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.LabelRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LabelRate.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelRate.DefaultText = "";
            this.LabelRate.FillColor = System.Drawing.Color.White;
            this.LabelRate.HideSelection = true;
            this.LabelRate.IconLeft = null;
            this.LabelRate.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.LabelRate.IconPadding = 10;
            this.LabelRate.IconRight = null;
            this.LabelRate.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.LabelRate.Lines = new string[0];
            this.LabelRate.Location = new System.Drawing.Point(306, 151);
            this.LabelRate.MaxLength = 32767;
            this.LabelRate.MinimumSize = new System.Drawing.Size(1, 1);
            this.LabelRate.Modified = false;
            this.LabelRate.Multiline = false;
            this.LabelRate.Name = "LabelRate";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.LabelRate.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.LabelRate.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.LabelRate.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.LabelRate.OnIdleState = stateProperties8;
            this.LabelRate.Padding = new System.Windows.Forms.Padding(3);
            this.LabelRate.PasswordChar = '\0';
            this.LabelRate.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.LabelRate.PlaceholderText = "Enter text";
            this.LabelRate.ReadOnly = false;
            this.LabelRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LabelRate.SelectedText = "";
            this.LabelRate.SelectionLength = 0;
            this.LabelRate.SelectionStart = 0;
            this.LabelRate.ShortcutsEnabled = true;
            this.LabelRate.Size = new System.Drawing.Size(125, 41);
            this.LabelRate.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.LabelRate.TabIndex = 8;
            this.LabelRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LabelRate.TextMarginBottom = 0;
            this.LabelRate.TextMarginLeft = 3;
            this.LabelRate.TextMarginTop = 1;
            this.LabelRate.TextPlaceholder = "Enter text";
            this.LabelRate.UseSystemPasswordChar = false;
            this.LabelRate.WordWrap = true;
            this.LabelRate.TextChange += new System.EventHandler(this.LabelRate_TextChange);
            // 
            // CommentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelRate);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.ControlSubmit);
            this.Controls.Add(this.bunifuTextBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ControlNickName);
            this.Controls.Add(this.ControlImage);
            this.Controls.Add(this.ControlMyComment);
            this.Name = "CommentPanel";
            this.Size = new System.Drawing.Size(1292, 506);
            ((System.ComponentModel.ISupportInitialize)(this.ControlImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ControlImage;
        private System.Windows.Forms.Label ControlNickName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        
        private System.Windows.Forms.Label ControlMyComment;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ControlSubmit;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuTextBox LabelRate;
    }
}
