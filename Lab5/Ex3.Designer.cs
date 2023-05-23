namespace Lab5
{
    partial class Ex3
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
            btn_Next = new Button();
            btn_Back = new Button();
            lb_Page = new Label();
            cmb_Protocol = new ComboBox();
            label1 = new Label();
            lb_Recent = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lv_yourMail = new ListView();
            lb_recentEmail = new Label();
            lb_totalEmail = new Label();
            btn_Login = new Button();
            tb_Password = new TextBox();
            tb_Email = new TextBox();
            SuspendLayout();
            // 
            // btn_Next
            // 
            btn_Next.Location = new Point(694, 717);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(94, 29);
            btn_Next.TabIndex = 46;
            btn_Next.Text = "Next";
            btn_Next.UseVisualStyleBackColor = true;
            btn_Next.Click += btn_Next_Click;
            // 
            // btn_Back
            // 
            btn_Back.Location = new Point(12, 717);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(94, 29);
            btn_Back.TabIndex = 45;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // lb_Page
            // 
            lb_Page.AutoSize = true;
            lb_Page.Location = new Point(343, 722);
            lb_Page.Name = "lb_Page";
            lb_Page.Size = new Size(0, 20);
            lb_Page.TabIndex = 44;
            // 
            // cmb_Protocol
            // 
            cmb_Protocol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Protocol.FormattingEnabled = true;
            cmb_Protocol.Items.AddRange(new object[] { "IMAP", "POP" });
            cmb_Protocol.Location = new Point(503, 19);
            cmb_Protocol.Name = "cmb_Protocol";
            cmb_Protocol.Size = new Size(110, 28);
            cmb_Protocol.TabIndex = 43;
            cmb_Protocol.SelectedIndexChanged += cmb_Protocol_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(429, 22);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 42;
            label1.Text = "Protocol:";
            // 
            // lb_Recent
            // 
            lb_Recent.AutoSize = true;
            lb_Recent.Location = new Point(201, 105);
            lb_Recent.Name = "lb_Recent";
            lb_Recent.Size = new Size(0, 20);
            lb_Recent.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 105);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 40;
            label5.Text = "Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 60);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 39;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 22);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 38;
            label3.Text = "Email:";
            // 
            // lv_yourMail
            // 
            lv_yourMail.Location = new Point(12, 128);
            lv_yourMail.Name = "lv_yourMail";
            lv_yourMail.Size = new Size(776, 582);
            lv_yourMail.TabIndex = 37;
            lv_yourMail.UseCompatibleStateImageBehavior = false;
            // 
            // lb_recentEmail
            // 
            lb_recentEmail.AutoSize = true;
            lb_recentEmail.Location = new Point(286, 105);
            lb_recentEmail.Name = "lb_recentEmail";
            lb_recentEmail.Size = new Size(0, 20);
            lb_recentEmail.TabIndex = 36;
            // 
            // lb_totalEmail
            // 
            lb_totalEmail.AutoSize = true;
            lb_totalEmail.Location = new Point(91, 105);
            lb_totalEmail.Name = "lb_totalEmail";
            lb_totalEmail.Size = new Size(0, 20);
            lb_totalEmail.TabIndex = 35;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = SystemColors.ButtonFace;
            btn_Login.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Login.Location = new Point(670, 36);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(118, 44);
            btn_Login.TabIndex = 34;
            btn_Login.Text = "LOGIN";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // tb_Password
            // 
            tb_Password.Location = new Point(91, 57);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(309, 27);
            tb_Password.TabIndex = 33;
            tb_Password.UseSystemPasswordChar = true;
            // 
            // tb_Email
            // 
            tb_Email.Location = new Point(91, 19);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(309, 27);
            tb_Email.TabIndex = 32;
            // 
            // Ex3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 753);
            Controls.Add(btn_Next);
            Controls.Add(btn_Back);
            Controls.Add(lb_Page);
            Controls.Add(cmb_Protocol);
            Controls.Add(label1);
            Controls.Add(lb_Recent);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lv_yourMail);
            Controls.Add(lb_recentEmail);
            Controls.Add(lb_totalEmail);
            Controls.Add(btn_Login);
            Controls.Add(tb_Password);
            Controls.Add(tb_Email);
            Name = "Ex3";
            Text = "Ex3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Next;
        private Button btn_Back;
        private Label lb_Page;
        private ComboBox cmb_Protocol;
        private Label label1;
        private Label lb_Recent;
        private Label label5;
        private Label label4;
        private Label label3;
        private ListView lv_yourMail;
        private Label lb_recentEmail;
        private Label lb_totalEmail;
        private Button btn_Login;
        private TextBox tb_Password;
        private TextBox tb_Email;
    }
}