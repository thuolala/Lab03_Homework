namespace Lab03_Homework
{
    partial class formStu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.comboBoxQue = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewStu = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnAll);
            this.groupBox1.Controls.Add(this.comboBoxQue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(435, 26);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(89, 28);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Xem in";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(323, 26);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(92, 28);
            this.btnAll.TabIndex = 2;
            this.btnAll.Text = "Tất cả";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // comboBoxQue
            // 
            this.comboBoxQue.FormattingEnabled = true;
            this.comboBoxQue.Location = new System.Drawing.Point(85, 27);
            this.comboBoxQue.Name = "comboBoxQue";
            this.comboBoxQue.Size = new System.Drawing.Size(188, 28);
            this.comboBoxQue.TabIndex = 1;
            this.comboBoxQue.SelectedIndexChanged += new System.EventHandler(this.comboBoxQue_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quê quán";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewStu);
            this.groupBox2.Location = new System.Drawing.Point(12, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 268);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sinh viên";
            // 
            // dataGridViewStu
            // 
            this.dataGridViewStu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStu.Location = new System.Drawing.Point(-16, 26);
            this.dataGridViewStu.Name = "dataGridViewStu";
            this.dataGridViewStu.RowTemplate.Height = 25;
            this.dataGridViewStu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStu.Size = new System.Drawing.Size(540, 227);
            this.dataGridViewStu.TabIndex = 0;
            // 
            // formStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 385);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formStu";
            this.Text = "Tìm kiếm sinh viên theo quê quán";
            this.Load += new System.EventHandler(this.formStu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnPrint;
        private Button btnAll;
        private ComboBox comboBoxQue;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridViewStu;
    }
}