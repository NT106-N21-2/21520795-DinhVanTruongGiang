namespace Lab6
{
    partial class Ex1
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
            panel1 = new Panel();
            tb_Decryption = new TextBox();
            label4 = new Label();
            tb_Encryption = new TextBox();
            label3 = new Label();
            tb_Input = new TextBox();
            label2 = new Label();
            tb_Shift = new TextBox();
            label1 = new Label();
            btn_Decription = new Button();
            btn_Encryption = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tb_Decryption);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tb_Encryption);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tb_Input);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tb_Shift);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_Decription);
            panel1.Controls.Add(btn_Encryption);
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(638, 620);
            panel1.TabIndex = 1;
            // 
            // tb_Decryption
            // 
            tb_Decryption.Location = new Point(25, 493);
            tb_Decryption.Multiline = true;
            tb_Decryption.Name = "tb_Decryption";
            tb_Decryption.ReadOnly = true;
            tb_Decryption.Size = new Size(589, 121);
            tb_Decryption.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 459);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 8;
            label4.Text = "Giải mã";
            // 
            // tb_Encryption
            // 
            tb_Encryption.Location = new Point(25, 322);
            tb_Encryption.Multiline = true;
            tb_Encryption.Name = "tb_Encryption";
            tb_Encryption.Size = new Size(589, 121);
            tb_Encryption.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 288);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 6;
            label3.Text = "Mã hoá";
            // 
            // tb_Input
            // 
            tb_Input.Location = new Point(25, 151);
            tb_Input.Multiline = true;
            tb_Input.Name = "tb_Input";
            tb_Input.Size = new Size(589, 121);
            tb_Input.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 117);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 4;
            label2.Text = "Dữ liệu (Input)";
            // 
            // tb_Shift
            // 
            tb_Shift.Location = new Point(25, 70);
            tb_Shift.Name = "tb_Shift";
            tb_Shift.Size = new Size(156, 27);
            tb_Shift.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 38);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 2;
            label1.Text = "Dịch (Shift)";
            // 
            // btn_Decription
            // 
            btn_Decription.Location = new Point(501, 16);
            btn_Decription.Name = "btn_Decription";
            btn_Decription.Size = new Size(113, 29);
            btn_Decription.TabIndex = 1;
            btn_Decription.Text = "Giải mã";
            btn_Decription.UseVisualStyleBackColor = true;
            btn_Decription.Click += btn_Decription_Click;
            // 
            // btn_Encryption
            // 
            btn_Encryption.Location = new Point(378, 16);
            btn_Encryption.Name = "btn_Encryption";
            btn_Encryption.Size = new Size(113, 29);
            btn_Encryption.TabIndex = 0;
            btn_Encryption.Text = "Mã hoá";
            btn_Encryption.UseVisualStyleBackColor = true;
            btn_Encryption.Click += btn_Encryption_Click;
            // 
            // Ex1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 627);
            Controls.Add(panel1);
            Name = "Ex1";
            Text = "Ex1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox tb_Decryption;
        private Label label4;
        private TextBox tb_Encryption;
        private Label label3;
        private TextBox tb_Input;
        private Label label2;
        private TextBox tb_Shift;
        private Label label1;
        private Button btn_Decription;
        private Button btn_Encryption;
    }
}