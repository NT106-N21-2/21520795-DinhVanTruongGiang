namespace Lab5
{
    partial class Ex2
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
            lv_yourMail = new ListView();
            lb_recentEmail = new Label();
            lb_totalEmail = new Label();
            btn_Login = new Button();
            tb_Password = new TextBox();
            tb_Email = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // lv_yourMail
            // 
            lv_yourMail.Location = new Point(13, 115);
            lv_yourMail.Name = "lv_yourMail";
            lv_yourMail.Size = new Size(776, 662);
            lv_yourMail.TabIndex = 11;
            lv_yourMail.UseCompatibleStateImageBehavior = false;
            // 
            // lb_recentEmail
            // 
            lb_recentEmail.AutoSize = true;
            lb_recentEmail.Location = new Point(286, 92);
            lb_recentEmail.Name = "lb_recentEmail";
            lb_recentEmail.Size = new Size(0, 20);
            lb_recentEmail.TabIndex = 10;
            // 
            // lb_totalEmail
            // 
            lb_totalEmail.AutoSize = true;
            lb_totalEmail.Location = new Point(91, 92);
            lb_totalEmail.Name = "lb_totalEmail";
            lb_totalEmail.Size = new Size(0, 20);
            lb_totalEmail.TabIndex = 9;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = SystemColors.ButtonFace;
            btn_Login.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Login.Location = new Point(578, 23);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(210, 44);
            btn_Login.TabIndex = 8;
            btn_Login.Text = "LOGIN";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // tb_Password
            // 
            tb_Password.Location = new Point(91, 44);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(309, 27);
            tb_Password.TabIndex = 7;
            tb_Password.UseSystemPasswordChar = true;
            // 
            // tb_Email
            // 
            tb_Email.Location = new Point(91, 6);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(309, 27);
            tb_Email.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 12;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 47);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 13;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 92);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 14;
            label5.Text = "Total:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(201, 92);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 15;
            label6.Text = "Recent:";
            // 
            // Ex2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 789);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lv_yourMail);
            Controls.Add(lb_recentEmail);
            Controls.Add(lb_totalEmail);
            Controls.Add(btn_Login);
            Controls.Add(tb_Password);
            Controls.Add(tb_Email);
            Name = "Ex2";
            Text = "Ex2";
            Load += Ex2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lv_yourMail;
        private Label lb_recentEmail;
        private Label lb_totalEmail;
        private Button btn_Login;
        private TextBox tb_Password;
        private TextBox tb_Email;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}