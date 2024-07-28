namespace PRL
{
    partial class Login
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
            groupBox2 = new GroupBox();
            label3 = new Label();
            radioButton1 = new RadioButton();
            button_exit = new Button();
            button1 = new Button();
            checkBox1 = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(287, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(241, 138);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(button_exit);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(12, 156);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(806, 320);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(478, 168);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 7;
            label3.Text = "Quên Mật Khẩu";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(301, 204);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(200, 24);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Xác nhận ko phải là robot";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // button_exit
            // 
            button_exit.Location = new Point(480, 244);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(94, 29);
            button_exit.TabIndex = 5;
            button_exit.Text = "Exit";
            button_exit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(215, 244);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(142, 170);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(148, 24);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Hiển thị mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 48);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 122);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 2;
            label1.Text = "Passwrold";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(168, 108);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Nhập mật khẩu";
            textBox2.Size = new Size(503, 34);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(168, 34);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nhập tên";
            textBox1.Size = new Size(503, 34);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 488);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Login";
            Text = "Login";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton1;
        private Button button_exit;
        private Button button1;
        private CheckBox checkBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
    }
}