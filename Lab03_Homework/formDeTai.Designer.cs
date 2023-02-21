namespace Lab03_Homework
{
    partial class formDeTai
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
            this.comboBoxKP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.comboBoxCN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDT = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxKP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnAll);
            this.groupBox1.Controls.Add(this.comboBoxCN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(41, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 120);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // comboBoxKP
            // 
            this.comboBoxKP.FormattingEnabled = true;
            this.comboBoxKP.Location = new System.Drawing.Point(85, 73);
            this.comboBoxKP.Name = "comboBoxKP";
            this.comboBoxKP.Size = new System.Drawing.Size(188, 28);
            this.comboBoxKP.TabIndex = 5;
            this.comboBoxKP.SelectedIndexChanged += new System.EventHandler(this.comboBoxKP_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kinh phí";
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
            // comboBoxCN
            // 
            this.comboBoxCN.FormattingEnabled = true;
            this.comboBoxCN.Location = new System.Drawing.Point(85, 27);
            this.comboBoxCN.Name = "comboBoxCN";
            this.comboBoxCN.Size = new System.Drawing.Size(188, 28);
            this.comboBoxCN.TabIndex = 1;
            this.comboBoxCN.SelectedIndexChanged += new System.EventHandler(this.comboBoxCN_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chủ nhiệm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewDT);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(41, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 281);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đề tài";
            // 
            // dataGridViewDT
            // 
            this.dataGridViewDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDT.Location = new System.Drawing.Point(6, 35);
            this.dataGridViewDT.Name = "dataGridViewDT";
            this.dataGridViewDT.RowTemplate.Height = 25;
            this.dataGridViewDT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDT.Size = new System.Drawing.Size(453, 227);
            this.dataGridViewDT.TabIndex = 0;
            this.dataGridViewDT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDT_CellContentClick);
            // 
            // formDeTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 423);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "formDeTai";
            this.Text = "Tìm và in ấn đề tài";
            this.Load += new System.EventHandler(this.formDeTai_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBoxKP;
        private Label label2;
        private Button btnPrint;
        private Button btnAll;
        private ComboBox comboBoxCN;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridViewDT;
    }
}