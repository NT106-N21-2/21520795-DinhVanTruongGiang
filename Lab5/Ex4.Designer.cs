namespace Lab5
{
    partial class Ex4
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tb_Username = new TextBox();
            tb_Passwd = new TextBox();
            tb_SmtpAddress = new TextBox();
            tb_Imap_Address = new TextBox();
            bt_Send = new Button();
            bt_Refresh = new Button();
            bt_Log = new Button();
            listView1 = new ListView();
            SMTP_port = new NumericUpDown();
            IMAP_port = new NumericUpDown();
            page = new Label();
            bt_Back = new Button();
            bt_Next = new Button();
            ((System.ComponentModel.ISupportInitialize)SMTP_port).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IMAP_port).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 17);
            label1.Name = "label1";
            label1.Size = new Size(93, 22);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 49);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 0;
            label2.Text = "Tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 81);
            label3.Name = "label3";
            label3.Size = new Size(82, 22);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(414, 17);
            label4.Name = "label4";
            label4.Size = new Size(67, 22);
            label4.TabIndex = 0;
            label4.Text = "Cài đặt";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(430, 49);
            label5.Name = "label5";
            label5.Size = new Size(61, 22);
            label5.TabIndex = 0;
            label5.Text = "SMTP";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(430, 81);
            label6.Name = "label6";
            label6.Size = new Size(43, 22);
            label6.TabIndex = 0;
            label6.Text = "Port";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(702, 49);
            label7.Name = "label7";
            label7.Size = new Size(58, 22);
            label7.TabIndex = 0;
            label7.Text = "IMAP";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(702, 81);
            label8.Name = "label8";
            label8.Size = new Size(43, 22);
            label8.TabIndex = 0;
            label8.Text = "Port";
            // 
            // tb_Username
            // 
            tb_Username.Location = new Point(130, 46);
            tb_Username.Name = "tb_Username";
            tb_Username.Size = new Size(255, 30);
            tb_Username.TabIndex = 1;
            // 
            // tb_Passwd
            // 
            tb_Passwd.Location = new Point(130, 78);
            tb_Passwd.Name = "tb_Passwd";
            tb_Passwd.Size = new Size(255, 30);
            tb_Passwd.TabIndex = 1;
            // 
            // tb_SmtpAddress
            // 
            tb_SmtpAddress.Location = new Point(490, 46);
            tb_SmtpAddress.Name = "tb_SmtpAddress";
            tb_SmtpAddress.Size = new Size(193, 30);
            tb_SmtpAddress.TabIndex = 1;
            tb_SmtpAddress.Text = "smtp.gmail.com";
            // 
            // tb_Imap_Address
            // 
            tb_Imap_Address.Location = new Point(766, 46);
            tb_Imap_Address.Name = "tb_Imap_Address";
            tb_Imap_Address.Size = new Size(193, 30);
            tb_Imap_Address.TabIndex = 1;
            tb_Imap_Address.Text = "imap.gmail.com";
            // 
            // bt_Send
            // 
            bt_Send.Location = new Point(30, 118);
            bt_Send.Name = "bt_Send";
            bt_Send.Size = new Size(94, 29);
            bt_Send.TabIndex = 2;
            bt_Send.Text = "Gửi Mail";
            bt_Send.UseVisualStyleBackColor = true;
            bt_Send.Click += bt_Send_Click;
            // 
            // bt_Refresh
            // 
            bt_Refresh.Location = new Point(147, 118);
            bt_Refresh.Name = "bt_Refresh";
            bt_Refresh.Size = new Size(94, 29);
            bt_Refresh.TabIndex = 2;
            bt_Refresh.Text = "Refresh";
            bt_Refresh.UseVisualStyleBackColor = true;
            bt_Refresh.Click += bt_Refresh_Click;
            // 
            // bt_Log
            // 
            bt_Log.Location = new Point(259, 118);
            bt_Log.Name = "bt_Log";
            bt_Log.Size = new Size(126, 29);
            bt_Log.TabIndex = 2;
            bt_Log.Text = "Đăng nhập";
            bt_Log.UseVisualStyleBackColor = true;
            bt_Log.Click += bt_Log_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(20, 153);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(1108, 588);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.MouseDoubleClick += listView1_MouseDoubleClick;
            // 
            // SMTP_port
            // 
            SMTP_port.Location = new Point(490, 79);
            SMTP_port.Maximum = new decimal(new int[] { 65536, 0, 0, 0 });
            SMTP_port.Name = "SMTP_port";
            SMTP_port.Size = new Size(150, 30);
            SMTP_port.TabIndex = 4;
            SMTP_port.Value = new decimal(new int[] { 465, 0, 0, 0 });
            // 
            // IMAP_port
            // 
            IMAP_port.Location = new Point(766, 82);
            IMAP_port.Maximum = new decimal(new int[] { 65536, 0, 0, 0 });
            IMAP_port.Name = "IMAP_port";
            IMAP_port.Size = new Size(150, 30);
            IMAP_port.TabIndex = 4;
            IMAP_port.Value = new decimal(new int[] { 993, 0, 0, 0 });
            // 
            // page
            // 
            page.AutoSize = true;
            page.Location = new Point(539, 125);
            page.Name = "page";
            page.Size = new Size(57, 22);
            page.TabIndex = 5;
            page.Text = "1 - 30";
            // 
            // bt_Back
            // 
            bt_Back.Enabled = false;
            bt_Back.Location = new Point(490, 122);
            bt_Back.Name = "bt_Back";
            bt_Back.Size = new Size(29, 29);
            bt_Back.TabIndex = 6;
            bt_Back.Text = "<";
            bt_Back.UseVisualStyleBackColor = true;
            bt_Back.Click += bt_Back_Click;
            // 
            // bt_Next
            // 
            bt_Next.Location = new Point(611, 122);
            bt_Next.Name = "bt_Next";
            bt_Next.Size = new Size(29, 29);
            bt_Next.TabIndex = 6;
            bt_Next.Text = ">";
            bt_Next.UseVisualStyleBackColor = true;
            bt_Next.Click += bt_Next_Click;
            // 
            // Ex4
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 753);
            Controls.Add(bt_Next);
            Controls.Add(bt_Back);
            Controls.Add(page);
            Controls.Add(IMAP_port);
            Controls.Add(SMTP_port);
            Controls.Add(listView1);
            Controls.Add(bt_Log);
            Controls.Add(bt_Refresh);
            Controls.Add(bt_Send);
            Controls.Add(tb_Passwd);
            Controls.Add(tb_Imap_Address);
            Controls.Add(tb_SmtpAddress);
            Controls.Add(tb_Username);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Ex4";
            Text = "Ex4";
            Load += Ex4_Load;
            ((System.ComponentModel.ISupportInitialize)SMTP_port).EndInit();
            ((System.ComponentModel.ISupportInitialize)IMAP_port).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox tb_Username;
        private TextBox tb_Passwd;
        private TextBox tb_SmtpAddress;
        private TextBox tb_Imap_Address;
        private Button bt_Send;
        private Button bt_Refresh;
        private Button bt_Log;
        private ListView listView1;
        private NumericUpDown SMTP_port;
        private NumericUpDown IMAP_port;
        private Label page;
        private Button bt_Back;
        private Button bt_Next;
    }
}