namespace PRL
{
    partial class NuocSXFrm
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBox_tenqgg = new TextBox();
            textBox_maqg = new TextBox();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            label2 = new Label();
            textBox_timkiemsx = new TextBox();
            button_exitfrmsx = new Button();
            button_xoasx = new Button();
            button_suasx = new Button();
            button_addsx = new Button();
            groupBox3 = new GroupBox();
            dataGridView_sx = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_sx).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(697, 33);
            label1.Name = "label1";
            label1.Size = new Size(129, 23);
            label1.TabIndex = 0;
            label1.Text = "Nước Sản Xuất";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox_tenqgg);
            groupBox1.Controls.Add(textBox_maqg);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1486, 210);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // textBox_tenqgg
            // 
            textBox_tenqgg.Location = new Point(365, 123);
            textBox_tenqgg.Name = "textBox_tenqgg";
            textBox_tenqgg.Size = new Size(922, 30);
            textBox_tenqgg.TabIndex = 3;
            // 
            // textBox_maqg
            // 
            textBox_maqg.Location = new Point(365, 35);
            textBox_maqg.Name = "textBox_maqg";
            textBox_maqg.Size = new Size(922, 30);
            textBox_maqg.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 127);
            label4.Name = "label4";
            label4.Size = new Size(114, 23);
            label4.TabIndex = 1;
            label4.Text = "Tên Quốc Gia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 38);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 0;
            label3.Text = "Ma Qg";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox_timkiemsx);
            groupBox2.Controls.Add(button_exitfrmsx);
            groupBox2.Controls.Add(button_xoasx);
            groupBox2.Controls.Add(button_suasx);
            groupBox2.Controls.Add(button_addsx);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 633);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1486, 138);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(592, 84);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 5;
            label2.Text = "Tìm Kiếm";
            // 
            // textBox_timkiemsx
            // 
            textBox_timkiemsx.Location = new Point(685, 69);
            textBox_timkiemsx.Multiline = true;
            textBox_timkiemsx.Name = "textBox_timkiemsx";
            textBox_timkiemsx.PlaceholderText = "Nhập Thông tin tìm kiếm ở đây";
            textBox_timkiemsx.Size = new Size(466, 53);
            textBox_timkiemsx.TabIndex = 4;
            textBox_timkiemsx.TextChanged += textBox_timkiemsx_TextChanged;
            // 
            // button_exitfrmsx
            // 
            button_exitfrmsx.Location = new Point(1275, 69);
            button_exitfrmsx.Name = "button_exitfrmsx";
            button_exitfrmsx.Size = new Size(152, 53);
            button_exitfrmsx.TabIndex = 3;
            button_exitfrmsx.Text = "Exit";
            button_exitfrmsx.UseVisualStyleBackColor = true;
            button_exitfrmsx.Click += button_exitfrmsx_Click;
            // 
            // button_xoasx
            // 
            button_xoasx.Location = new Point(409, 69);
            button_xoasx.Name = "button_xoasx";
            button_xoasx.Size = new Size(152, 53);
            button_xoasx.TabIndex = 2;
            button_xoasx.Text = "Delete";
            button_xoasx.UseVisualStyleBackColor = true;
            button_xoasx.Click += button_xoasx_Click;
            // 
            // button_suasx
            // 
            button_suasx.Location = new Point(227, 69);
            button_suasx.Name = "button_suasx";
            button_suasx.Size = new Size(152, 53);
            button_suasx.TabIndex = 1;
            button_suasx.Text = "Update";
            button_suasx.UseVisualStyleBackColor = true;
            button_suasx.Click += button_suasx_Click;
            // 
            // button_addsx
            // 
            button_addsx.Location = new Point(36, 69);
            button_addsx.Name = "button_addsx";
            button_addsx.Size = new Size(152, 53);
            button_addsx.TabIndex = 0;
            button_addsx.Text = "Add";
            button_addsx.UseVisualStyleBackColor = true;
            button_addsx.Click += button_addsx_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView_sx);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            groupBox3.Location = new Point(12, 326);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1486, 310);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Data";
            // 
            // dataGridView_sx
            // 
            dataGridView_sx.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_sx.Location = new Point(6, 29);
            dataGridView_sx.Name = "dataGridView_sx";
            dataGridView_sx.RowHeadersWidth = 51;
            dataGridView_sx.Size = new Size(1474, 275);
            dataGridView_sx.TabIndex = 0;
            dataGridView_sx.CellClick += dataGridView_sx_CellClick;
            // 
            // NuocSXFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1510, 783);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "NuocSXFrm";
            Text = "NuocSXFrm";
            Load += NuocSXFrm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_sx).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button_addsx;
        private GroupBox groupBox3;
        private Button button_exitfrmsx;
        private Button button_xoasx;
        private Button button_suasx;
        private Label label2;
        private TextBox textBox_timkiemsx;
        private DataGridView dataGridView_sx;
        private TextBox textBox_tenqgg;
        private TextBox textBox_maqg;
        private Label label4;
        private Label label3;
    }
}