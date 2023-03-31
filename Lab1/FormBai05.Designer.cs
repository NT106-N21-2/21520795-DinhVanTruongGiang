namespace Lab1
{
    partial class FormBai05
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
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 33);
            label1.Name = "label1";
            label1.Size = new Size(86, 26);
            label1.TabIndex = 0;
            label1.Text = "Loại xe:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(539, 33);
            label2.Name = "label2";
            label2.Size = new Size(149, 26);
            label2.TabIndex = 0;
            label2.Text = "Loại xăng dầu:";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(309, 215);
            button1.Name = "button1";
            button1.Size = new Size(145, 40);
            button1.TabIndex = 1;
            button1.Text = "Đổ đầy bình";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(539, 125);
            label3.Name = "label3";
            label3.Size = new Size(166, 26);
            label3.TabIndex = 0;
            label3.Text = "Tỉ giá (VNĐ/lít):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(40, 293);
            label4.Name = "label4";
            label4.Size = new Size(273, 26);
            label4.TabIndex = 0;
            label4.Text = "Quãng đường đi được (km):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(540, 293);
            label5.Name = "label5";
            label5.Size = new Size(189, 26);
            label5.TabIndex = 0;
            label5.Text = "Thành tiền (VNĐ):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(296, 33);
            label6.Name = "label6";
            label6.Size = new Size(149, 26);
            label6.TabIndex = 0;
            label6.Text = "Dung tích (lít):";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(40, 322);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(125, 33);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(296, 62);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 33);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(539, 322);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(125, 33);
            textBox3.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Wave Alpha", "Sirius", "Vision", "Lead", "Winner", "Airblade", "Xe tải 9 tấn" });
            comboBox1.Location = new Point(40, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 33);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(539, 62);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(157, 33);
            comboBox2.TabIndex = 3;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(539, 166);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(138, 33);
            textBox4.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(40, 125);
            label7.Name = "label7";
            label7.Size = new Size(332, 26);
            label7.TabIndex = 0;
            label7.Text = "Mức độ tốn nhiên liệu (lít/100km):";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(40, 154);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(125, 33);
            textBox5.TabIndex = 2;
            // 
            // FormBai05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "FormBai05";
            Text = "FormBai05";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox5;
    }
}