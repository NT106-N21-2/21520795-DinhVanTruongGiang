namespace Lab5
{
    partial class Ex1
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
            rtb_bodyContent = new RichTextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tb_subjectContent = new TextBox();
            tb_Receiver = new TextBox();
            tb_Sender = new TextBox();
            btn_Send = new Button();
            tb_Password = new TextBox();
            tb_Email = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btn_Login = new Button();
            SuspendLayout();
            // 
            // rtb_bodyContent
            // 
            rtb_bodyContent.BackColor = SystemColors.ButtonHighlight;
            rtb_bodyContent.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rtb_bodyContent.Location = new Point(145, 145);
            rtb_bodyContent.Name = "rtb_bodyContent";
            rtb_bodyContent.Size = new Size(843, 358);
            rtb_bodyContent.TabIndex = 25;
            rtb_bodyContent.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("VNI-Souvir", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(47, 147);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 24;
            label4.Text = "Body:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("VNI-Souvir", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(47, 109);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 23;
            label3.Text = "Subject:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("VNI-Souvir", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(148, 62);
            label2.Name = "label2";
            label2.Size = new Size(41, 25);
            label2.TabIndex = 22;
            label2.Text = "To:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("VNI-Souvir", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(148, 27);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 21;
            label1.Text = "From:";
            // 
            // tb_subjectContent
            // 
            tb_subjectContent.BackColor = SystemColors.ButtonHighlight;
            tb_subjectContent.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_subjectContent.Location = new Point(145, 104);
            tb_subjectContent.Name = "tb_subjectContent";
            tb_subjectContent.Size = new Size(843, 30);
            tb_subjectContent.TabIndex = 20;
            // 
            // tb_Receiver
            // 
            tb_Receiver.BackColor = SystemColors.ButtonHighlight;
            tb_Receiver.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Receiver.Location = new Point(219, 57);
            tb_Receiver.Name = "tb_Receiver";
            tb_Receiver.Size = new Size(325, 30);
            tb_Receiver.TabIndex = 19;
            // 
            // tb_Sender
            // 
            tb_Sender.BackColor = SystemColors.ButtonHighlight;
            tb_Sender.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Sender.Location = new Point(218, 21);
            tb_Sender.Name = "tb_Sender";
            tb_Sender.ReadOnly = true;
            tb_Sender.Size = new Size(326, 30);
            tb_Sender.TabIndex = 18;
            // 
            // btn_Send
            // 
            btn_Send.Font = new Font("VNI-Souvir", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Send.Location = new Point(12, 12);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(130, 75);
            btn_Send.TabIndex = 26;
            btn_Send.Text = "SEND";
            btn_Send.UseVisualStyleBackColor = true;
            btn_Send.Click += btn_Send_Click;
            // 
            // tb_Password
            // 
            tb_Password.Location = new Point(675, 57);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(177, 27);
            tb_Password.TabIndex = 28;
            tb_Password.UseSystemPasswordChar = true;
            // 
            // tb_Email
            // 
            tb_Email.Location = new Point(675, 20);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(177, 27);
            tb_Email.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("VNI-Souvir", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(604, 19);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 30;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("VNI-Souvir", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(571, 59);
            label6.Name = "label6";
            label6.Size = new Size(100, 25);
            label6.TabIndex = 31;
            label6.Text = "Password:";
            // 
            // btn_Login
            // 
            btn_Login.Font = new Font("VNI-Souvir", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Login.Location = new Point(858, 11);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(130, 75);
            btn_Login.TabIndex = 32;
            btn_Login.Text = "LOGIN";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // Ex1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 519);
            Controls.Add(btn_Login);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tb_Password);
            Controls.Add(tb_Email);
            Controls.Add(btn_Send);
            Controls.Add(rtb_bodyContent);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_subjectContent);
            Controls.Add(tb_Receiver);
            Controls.Add(tb_Sender);
            Name = "Ex1";
            Text = "Ex1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtb_bodyContent;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tb_subjectContent;
        private TextBox tb_Receiver;
        private TextBox tb_Sender;
        private Button btn_Send;
        private TextBox tb_Password;
        private TextBox tb_Email;
        private Label label5;
        private Label label6;
        private Button btn_Login;
    }
}