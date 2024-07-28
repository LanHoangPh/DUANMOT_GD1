namespace PRL
{
    partial class FrmLoaiHAng
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
            groupBox2 = new GroupBox();
            dataGridView_lh = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label_timkiemlh = new Label();
            label_tenlh = new Label();
            label_malh = new Label();
            textBox_timkiemlh = new TextBox();
            textBox_tenlh = new TextBox();
            textBox_malh = new TextBox();
            panel1 = new Panel();
            button_deletelh = new Button();
            button_exitfromlh = new Button();
            button_updatelh = new Button();
            button_Themlh = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_lh).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView_lh);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            groupBox2.Location = new Point(12, 326);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1486, 437);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data";
            // 
            // dataGridView_lh
            // 
            dataGridView_lh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_lh.Location = new Point(6, 26);
            dataGridView_lh.Name = "dataGridView_lh";
            dataGridView_lh.RowHeadersWidth = 51;
            dataGridView_lh.Size = new Size(1474, 405);
            dataGridView_lh.TabIndex = 0;
            dataGridView_lh.CellClick += dataGridView_lh_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(752, 19);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 4;
            label1.Text = "LoaiHang";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label_timkiemlh);
            groupBox1.Controls.Add(label_tenlh);
            groupBox1.Controls.Add(label_malh);
            groupBox1.Controls.Add(textBox_timkiemlh);
            groupBox1.Controls.Add(textBox_tenlh);
            groupBox1.Controls.Add(textBox_malh);
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1486, 240);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "LoaiHang";
            // 
            // label_timkiemlh
            // 
            label_timkiemlh.AutoSize = true;
            label_timkiemlh.Location = new Point(97, 187);
            label_timkiemlh.Name = "label_timkiemlh";
            label_timkiemlh.Size = new Size(87, 23);
            label_timkiemlh.TabIndex = 9;
            label_timkiemlh.Text = "Tim Kiem";
            // 
            // label_tenlh
            // 
            label_tenlh.AutoSize = true;
            label_tenlh.Location = new Point(83, 119);
            label_tenlh.Name = "label_tenlh";
            label_tenlh.Size = new Size(123, 23);
            label_tenlh.TabIndex = 8;
            label_tenlh.Text = "Ten Loai Hang";
            // 
            // label_malh
            // 
            label_malh.AutoSize = true;
            label_malh.Location = new Point(83, 45);
            label_malh.Name = "label_malh";
            label_malh.Size = new Size(116, 23);
            label_malh.TabIndex = 7;
            label_malh.Text = "Ma LoaiHang";
            // 
            // textBox_timkiemlh
            // 
            textBox_timkiemlh.Location = new Point(215, 184);
            textBox_timkiemlh.Multiline = true;
            textBox_timkiemlh.Name = "textBox_timkiemlh";
            textBox_timkiemlh.PlaceholderText = "Tim Kiem thong tin o day";
            textBox_timkiemlh.Size = new Size(656, 34);
            textBox_timkiemlh.TabIndex = 2;
            textBox_timkiemlh.TextChanged += textBox_timkiemlh_TextChanged;
            // 
            // textBox_tenlh
            // 
            textBox_tenlh.Location = new Point(215, 116);
            textBox_tenlh.Multiline = true;
            textBox_tenlh.Name = "textBox_tenlh";
            textBox_tenlh.Size = new Size(656, 34);
            textBox_tenlh.TabIndex = 1;
            // 
            // textBox_malh
            // 
            textBox_malh.Location = new Point(215, 42);
            textBox_malh.Multiline = true;
            textBox_malh.Name = "textBox_malh";
            textBox_malh.Size = new Size(656, 34);
            textBox_malh.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button_deletelh);
            panel1.Controls.Add(button_exitfromlh);
            panel1.Controls.Add(button_updatelh);
            panel1.Controls.Add(button_Themlh);
            panel1.Location = new Point(974, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(506, 218);
            panel1.TabIndex = 6;
            // 
            // button_deletelh
            // 
            button_deletelh.Location = new Point(35, 136);
            button_deletelh.Name = "button_deletelh";
            button_deletelh.Size = new Size(152, 53);
            button_deletelh.TabIndex = 5;
            button_deletelh.Text = "Xoa";
            button_deletelh.UseVisualStyleBackColor = true;
            button_deletelh.Click += button_deletelh_Click;
            // 
            // button_exitfromlh
            // 
            button_exitfromlh.Location = new Point(308, 136);
            button_exitfromlh.Name = "button_exitfromlh";
            button_exitfromlh.Size = new Size(152, 53);
            button_exitfromlh.TabIndex = 5;
            button_exitfromlh.Text = "Exit";
            button_exitfromlh.UseVisualStyleBackColor = true;
            button_exitfromlh.Click += button_exitfromlh_Click;
            // 
            // button_updatelh
            // 
            button_updatelh.Location = new Point(308, 23);
            button_updatelh.Name = "button_updatelh";
            button_updatelh.Size = new Size(152, 53);
            button_updatelh.TabIndex = 4;
            button_updatelh.Text = "Update";
            button_updatelh.UseVisualStyleBackColor = true;
            button_updatelh.Click += button_updatelh_Click;
            // 
            // button_Themlh
            // 
            button_Themlh.Location = new Point(35, 23);
            button_Themlh.Name = "button_Themlh";
            button_Themlh.Size = new Size(152, 53);
            button_Themlh.TabIndex = 3;
            button_Themlh.Text = "Add";
            button_Themlh.UseVisualStyleBackColor = true;
            button_Themlh.Click += button_Themlh_Click;
            // 
            // FrmLoaiHAng
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1510, 783);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "FrmLoaiHAng";
            Text = "FrmLoaiHAng";
            Load += FrmLoaiHAng_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_lh).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dataGridView_lh;
        private Label label1;
        private GroupBox groupBox1;
        private Label label_timkiemlh;
        private Label label_tenlh;
        private Label label_malh;
        private TextBox textBox_timkiemlh;
        private TextBox textBox_tenlh;
        private TextBox textBox_malh;
        private Panel panel1;
        private Button button_deletelh;
        private Button button_exitfromlh;
        private Button button_updatelh;
        private Button button_Themlh;
    }
}