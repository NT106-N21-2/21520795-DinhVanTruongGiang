namespace Lab2
{
    partial class Bai1
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
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(54, 31);
            button1.Name = "button1";
            button1.Size = new Size(160, 73);
            button1.TabIndex = 0;
            button1.Text = "Đọc File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(269, 31);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(488, 288);
            textBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(54, 141);
            button2.Name = "button2";
            button2.Size = new Size(160, 73);
            button2.TabIndex = 0;
            button2.Text = "Ghi File";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(54, 246);
            button3.Name = "button3";
            button3.Size = new Size(160, 73);
            button3.TabIndex = 0;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 359);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Bai1";
            Text = "Bai1";
            Load += Bai1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
    }
}