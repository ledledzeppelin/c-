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
            this.mainPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel1.Location = new System.Drawing.Point(20, 60);
            this.mainPanel1.Name = "mainPanel1";
            this.mainPanel1.Size = new System.Drawing.Size(1246, 887);
            this.mainPanel1.TabIndex = 0;
            // 
            // FormMainMetro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 967);
            this.Controls.Add(this.mainPanel1);
            this.Name = "FormMainMetro";
            this.ResumeLayout(false);

        }

        #endregion

        private controls.MainPanel mainPanel1;
    }
}