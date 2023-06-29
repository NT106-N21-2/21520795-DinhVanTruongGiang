namespace Lab6
{
    partial class Ex3_Client
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
            tb_privateKey = new TextBox();
            tb_publicKey = new TextBox();
            encryptedMessage = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            serIP = new TextBox();
            label4 = new Label();
            bt_Connect = new Button();
            tb_userName = new TextBox();
            label5 = new Label();
            bt_Send = new Button();
            msgTB = new TextBox();
            label6 = new Label();
            rtb_Client = new RichTextBox();
            SuspendLayout();
            // 
            // tb_privateKey
            // 
            tb_privateKey.Location = new Point(577, 509);
            tb_privateKey.Margin = new Padding(4, 3, 4, 3);
            tb_privateKey.Multiline = true;
            tb_privateKey.Name = "tb_privateKey";
            tb_privateKey.ReadOnly = true;
            tb_privateKey.ScrollBars = ScrollBars.Both;
            tb_privateKey.Size = new Size(465, 187);
            tb_privateKey.TabIndex = 2;
            // 
            // tb_publicKey
            // 
            tb_publicKey.Location = new Point(577, 270);
            tb_publicKey.Margin = new Padding(4, 3, 4, 3);
            tb_publicKey.Multiline = true;
            tb_publicKey.Name = "tb_publicKey";
            tb_publicKey.ReadOnly = true;
            tb_publicKey.ScrollBars = ScrollBars.Both;
            tb_publicKey.Size = new Size(465, 213);
            tb_publicKey.TabIndex = 3;
            // 
            // encryptedMessage
            // 
            encryptedMessage.Location = new Point(577, 44);
            encryptedMessage.Margin = new Padding(4, 3, 4, 3);
            encryptedMessage.Multiline = true;
            encryptedMessage.Name = "encryptedMessage";
            encryptedMessage.ReadOnly = true;
            encryptedMessage.ScrollBars = ScrollBars.Both;
            encryptedMessage.Size = new Size(465, 200);
            encryptedMessage.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(577, 247);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 5;
            label3.Text = "Publickey";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(577, 486);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 6;
            label2.Text = "Privatekey";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(577, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 7;
            label1.Text = "Encrypted Message";
            // 
            // serIP
            // 
            serIP.Location = new Point(12, 555);
            serIP.Name = "serIP";
            serIP.Size = new Size(178, 27);
            serIP.TabIndex = 8;
            serIP.Text = "127.0.0.1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 532);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 9;
            label4.Text = "Server's IP";
            label4.Click += label4_Click;
            // 
            // bt_Connect
            // 
            bt_Connect.Location = new Point(475, 555);
            bt_Connect.Name = "bt_Connect";
            bt_Connect.Size = new Size(94, 29);
            bt_Connect.TabIndex = 10;
            bt_Connect.Text = "Connect";
            bt_Connect.UseVisualStyleBackColor = true;
            bt_Connect.Click += btn_Login_Click;
            // 
            // tb_userName
            // 
            tb_userName.Location = new Point(234, 555);
            tb_userName.Name = "tb_userName";
            tb_userName.Size = new Size(235, 27);
            tb_userName.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(234, 532);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 9;
            label5.Text = "User name";
            label5.Click += label4_Click;
            // 
            // bt_Send
            // 
            bt_Send.Location = new Point(475, 618);
            bt_Send.Name = "bt_Send";
            bt_Send.Size = new Size(94, 78);
            bt_Send.TabIndex = 12;
            bt_Send.Text = "Send";
            bt_Send.UseVisualStyleBackColor = true;
            bt_Send.Click += btn_Send_Click;
            // 
            // msgTB
            // 
            msgTB.Location = new Point(12, 619);
            msgTB.Multiline = true;
            msgTB.Name = "msgTB";
            msgTB.Size = new Size(457, 77);
            msgTB.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 596);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 13;
            label6.Text = "Message";
            label6.Click += label6_Click;
            // 
            // rtb_Client
            // 
            rtb_Client.Location = new Point(12, 44);
            rtb_Client.Name = "rtb_Client";
            rtb_Client.Size = new Size(557, 485);
            rtb_Client.TabIndex = 14;
            rtb_Client.Text = "";
            // 
            // Ex3_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 708);
            Controls.Add(rtb_Client);
            Controls.Add(label6);
            Controls.Add(bt_Send);
            Controls.Add(msgTB);
            Controls.Add(bt_Connect);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tb_userName);
            Controls.Add(serIP);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_privateKey);
            Controls.Add(tb_publicKey);
            Controls.Add(encryptedMessage);
            Name = "Ex3_Client";
            Text = "Ex3_Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tb_privateKey;
        private TextBox tb_publicKey;
        private TextBox encryptedMessage;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox serIP;
        private Label label4;
        private Button bt_Connect;
        private TextBox tb_userName;
        private Label label5;
        private Button bt_Send;
        private TextBox msgTB;
        private Label label6;
        private RichTextBox rtb_Client;
    }
}