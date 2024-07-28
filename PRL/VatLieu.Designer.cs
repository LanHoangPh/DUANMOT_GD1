namespace PRL
{
    partial class VatLieuu
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
            groupBox1 = new GroupBox();
            label_timkiemvl = new Label();
            label_tenVl = new Label();
            label_mavl = new Label();
            textBox_timkiemVL = new TextBox();
            textBox_tenVL = new TextBox();
            textBox_maVL = new TextBox();
            panel1 = new Panel();
            button_deletevl = new Button();
            button_exitfromvl = new Button();
            button_updatevl = new Button();
            button_ThemVL = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label_timkiemvl);
            groupBox1.Controls.Add(label_tenVl);
            groupBox1.Controls.Add(label_mavl);
            groupBox1.Controls.Add(textBox_timkiemVL);
            groupBox1.Controls.Add(textBox_tenVL);
            groupBox1.Controls.Add(textBox_maVL);
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1486, 240);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "chuc nang";
            // 
            // label_timkiemvl
            // 
            label_timkiemvl.AutoSize = true;
            label_timkiemvl.Location = new Point(97, 187);
            label_timkiemvl.Name = "label_timkiemvl";
            label_timkiemvl.Size = new Size(87, 23);
            label_timkiemvl.TabIndex = 9;
            label_timkiemvl.Text = "Tim Kiem";
            // 
            // label_tenVl
            // 
            label_tenVl.AutoSize = true;
            label_tenVl.Location = new Point(83, 119);
            label_tenVl.Name = "label_tenVl";
            label_tenVl.Size = new Size(106, 23);
            label_tenVl.TabIndex = 8;
            label_tenVl.Text = "Ten Vat Lieu";
            // 
            // label_mavl
            // 
            label_mavl.AutoSize = true;
            label_mavl.Location = new Point(83, 45);
            label_mavl.Name = "label_mavl";
            label_mavl.Size = new Size(104, 23);
            label_mavl.TabIndex = 7;
            label_mavl.Text = "Ma Vat Lieu";
            // 
            // textBox_timkiemVL
            // 
            textBox_timkiemVL.Location = new Point(215, 184);
            textBox_timkiemVL.Multiline = true;
            textBox_timkiemVL.Name = "textBox_timkiemVL";
            textBox_timkiemVL.PlaceholderText = "Tim Kiem thong tin o day";
            textBox_timkiemVL.Size = new Size(656, 34);
            textBox_timkiemVL.TabIndex = 2;
            textBox_timkiemVL.TextChanged += textBox_timkiemVL_TextChanged;
            // 
            // textBox_tenVL
            // 
            textBox_tenVL.Location = new Point(215, 116);
            textBox_tenVL.Multiline = true;
            textBox_tenVL.Name = "textBox_tenVL";
            textBox_tenVL.Size = new Size(656, 34);
            textBox_tenVL.TabIndex = 1;
            // 
            // textBox_maVL
            // 
            textBox_maVL.Location = new Point(215, 42);
            textBox_maVL.Multiline = true;
            textBox_maVL.Name = "textBox_maVL";
            textBox_maVL.Size = new Size(656, 34);
            textBox_maVL.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button_deletevl);
            panel1.Controls.Add(button_exitfromvl);
            panel1.Controls.Add(button_updatevl);
            panel1.Controls.Add(button_ThemVL);
            panel1.Location = new Point(974, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(506, 218);
            panel1.TabIndex = 6;
            // 
            // button_deletevl
            // 
            button_deletevl.Location = new Point(35, 136);
            button_deletevl.Name = "button_deletevl";
            button_deletevl.Size = new Size(152, 53);
            button_deletevl.TabIndex = 5;
            button_deletevl.Text = "Xoa";
            button_deletevl.UseVisualStyleBackColor = true;
            button_deletevl.Click += button_deletevl_Click;
            // 
            // button_exitfromvl
            // 
            button_exitfromvl.Location = new Point(308, 136);
            button_exitfromvl.Name = "button_exitfromvl";
            button_exitfromvl.Size = new Size(152, 53);
            button_exitfromvl.TabIndex = 5;
            button_exitfromvl.Text = "Exit";
            button_exitfromvl.UseVisualStyleBackColor = true;
            button_exitfromvl.Click += button_exitfromvl_Click;
            // 
            // button_updatevl
            // 
            button_updatevl.Location = new Point(308, 23);
            button_updatevl.Name = "button_updatevl";
            button_updatevl.Size = new Size(152, 53);
            button_updatevl.TabIndex = 4;
            button_updatevl.Text = "Update";
            button_updatevl.UseVisualStyleBackColor = true;
            button_updatevl.Click += button_updatevl_Click;
            // 
            // button_ThemVL
            // 
            button_ThemVL.Location = new Point(35, 23);
            button_ThemVL.Name = "button_ThemVL";
            button_ThemVL.Size = new Size(152, 53);
            button_ThemVL.TabIndex = 3;
            button_ThemVL.Text = "Add";
            button_ThemVL.UseVisualStyleBackColor = true;
            button_ThemVL.Click += button_ThemVL_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(752, 27);
            label1.Name = "label1";
            label1.Size = new Size(74, 23);
            label1.TabIndex = 1;
            label1.Text = "Vat Lieu";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            groupBox2.Location = new Point(12, 334);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1486, 437);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1474, 405);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // VatLieuu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1510, 783);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "VatLieuu";
            Text = "VatLieu";
            Load += VatLieu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Label label_timkiemvl;
        private Label label_tenVl;
        private Label label_mavl;
        private TextBox textBox_timkiemVL;
        private TextBox textBox_tenVL;
        private TextBox textBox_maVL;
        private Panel panel1;
        private Button button_deletevl;
        private Button button_exitfromvl;
        private Button button_updatevl;
        private Button button_ThemVL;
    }
}