namespace Lab03_Homework
{
    partial class formStuRes
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
            this.comboBoxDT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.comboBoxSV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewSR = new System.Windows.Forms.DataGridView();
            this.comboBoxCN = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxCN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxDT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnAll);
            this.groupBox1.Controls.Add(this.comboBoxSV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(20, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 168);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBoxDT
            // 
            this.comboBoxDT.FormattingEnabled = true;
            this.comboBoxDT.Location = new System.Drawing.Point(85, 73);
            this.comboBoxDT.Name = "comboBoxDT";
            this.comboBoxDT.Size = new System.Drawing.Size(188, 28);
            this.comboBoxDT.TabIndex = 5;
            this.comboBoxDT.SelectedIndexChanged += new System.EventHandler(this.comboBoxDT_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đề tài";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(367, 73);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(92, 28);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Xem in";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(367, 24);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(92, 28);
            this.btnAll.TabIndex = 2;
            this.btnAll.Text = "Tất cả";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // comboBoxSV
            // 
            this.comboBoxSV.FormattingEnabled = true;
            this.comboBoxSV.Location = new System.Drawing.Point(85, 27);
            this.comboBoxSV.Name = "comboBoxSV";
            this.comboBoxSV.Size = new System.Drawing.Size(188, 28);
            this.comboBoxSV.TabIndex = 1;
            this.comboBoxSV.SelectedIndexChanged += new System.EventHandler(this.comboBoxSV_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sinh viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewSR);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(20, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 281);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả học tập";
            // 
            // dataGridViewSR
            // 
            this.dataGridViewSR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSR.Location = new System.Drawing.Point(6, 35);
            this.dataGridViewSR.Name = "dataGridViewSR";
            this.dataGridViewSR.RowTemplate.Height = 25;
            this.dataGridViewSR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSR.Size = new System.Drawing.Size(453, 227);
            this.dataGridViewSR.TabIndex = 0;
            // 
            // comboBoxCN
            // 
            this.comboBoxCN.FormattingEnabled = true;
            this.comboBoxCN.Location = new System.Drawing.Point(85, 119);
            this.comboBoxCN.Name = "comboBoxCN";
            this.comboBoxCN.Size = new System.Drawing.Size(188, 28);
            this.comboBoxCN.TabIndex = 7;
            this.comboBoxCN.SelectedIndexChanged += new System.EventHandler(this.comboBoxCN_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chủ nhiệm";
            // 
            // formStuRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 489);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "formStuRes";
            this.Text = "formStuRes";
            this.Load += new System.EventHandler(this.formStuRes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBoxDT;
        private Label label2;
        private Button btnPrint;
        private Button btnAll;
        private ComboBox comboBoxSV;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridViewSR;
        private ComboBox comboBoxCN;
        private Label label3;
    }
}