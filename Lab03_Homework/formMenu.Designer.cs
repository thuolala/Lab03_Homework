namespace Lab03_Homework
{
    partial class formMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.deTaiStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.stuResStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stuStrip,
            this.deTaiStrip,
            this.stuResStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(470, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stuStrip
            // 
            this.stuStrip.Name = "stuStrip";
            this.stuStrip.Size = new System.Drawing.Size(80, 24);
            this.stuStrip.Text = "Sinh viên";
            this.stuStrip.Click += new System.EventHandler(this.stuStrip_Click);
            // 
            // deTaiStrip
            // 
            this.deTaiStrip.Name = "deTaiStrip";
            this.deTaiStrip.Size = new System.Drawing.Size(61, 24);
            this.deTaiStrip.Text = "Đề tài";
            this.deTaiStrip.Click += new System.EventHandler(this.deTaiStrip_Click);
            // 
            // stuResStrip
            // 
            this.stuResStrip.Name = "stuResStrip";
            this.stuResStrip.Size = new System.Drawing.Size(126, 24);
            this.stuResStrip.Text = "Kết quả học tập";
            this.stuResStrip.Click += new System.EventHandler(this.stuResStrip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(97, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lab 03 - Homework";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(110, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm kiếm và in ấn";
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 281);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.formMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem stuStrip;
        private ToolStripMenuItem deTaiStrip;
        private ToolStripMenuItem stuResStrip;
        private Label label1;
        private Label label2;
    }
}