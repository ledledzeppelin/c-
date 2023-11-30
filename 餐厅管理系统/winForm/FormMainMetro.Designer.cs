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
            this.mainPanel1 = new 餐厅管理系统.controls.MainPanel();
            this.SuspendLayout();
            // 
            // mainPanel1
            // 
            this.mainPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel1.Location = new System.Drawing.Point(0, 18);
            this.mainPanel1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.mainPanel1.MyProfileImage = null;
            this.mainPanel1.Name = "mainPanel1";
            this.mainPanel1.Size = new System.Drawing.Size(979, 782);
            this.mainPanel1.TabIndex = 0;
            this.mainPanel1.Load += new System.EventHandler(this.mainPanel1_Load_1);
            // 
            // FormMainMetro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 787);
            this.Controls.Add(this.mainPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMainMetro";
            this.Padding = new System.Windows.Forms.Padding(15, 43, 15, 14);
            this.ResumeLayout(false);

        }

        #endregion

        private controls.MainPanel mainPanel1;
    }
}