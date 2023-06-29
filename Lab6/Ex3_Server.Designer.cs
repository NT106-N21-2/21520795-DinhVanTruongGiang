namespace Lab6
{
    partial class Ex3_Server
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
            latestMsg = new TextBox();
            publicKey = new TextBox();
            privateKey = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            bt_Listen = new Button();
            rtb_main = new RichTextBox();
            SuspendLayout();
            // 
            // latestMsg
            // 
            latestMsg.Location = new Point(590, 49);
            latestMsg.Margin = new Padding(4, 3, 4, 3);
            latestMsg.Multiline = true;
            latestMsg.Name = "latestMsg";
            latestMsg.ReadOnly = true;
            latestMsg.ScrollBars = ScrollBars.Both;
            latestMsg.Size = new Size(590, 200);
            latestMsg.TabIndex = 0;
            // 
            // publicKey
            // 
            publicKey.Location = new Point(590, 275);
            publicKey.Margin = new Padding(4, 3, 4, 3);
            publicKey.Multiline = true;
            publicKey.Name = "publicKey";
            publicKey.ReadOnly = true;
            publicKey.ScrollBars = ScrollBars.Both;
            publicKey.Size = new Size(590, 213);
            publicKey.TabIndex = 0;
            // 
            // privateKey
            // 
            privateKey.Location = new Point(590, 514);
            privateKey.Margin = new Padding(4, 3, 4, 3);
            privateKey.Multiline = true;
            privateKey.Name = "privateKey";
            privateKey.ReadOnly = true;
            privateKey.ScrollBars = ScrollBars.Both;
            privateKey.Size = new Size(590, 187);
            privateKey.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(590, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(199, 20);
            label1.TabIndex = 1;
            label1.Text = "Latest Encrypted Message";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(590, 491);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "Privatekey";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(590, 252);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 1;
            label3.Text = "Publickey";
            label3.Click += label1_Click;
            // 
            // bt_Listen
            // 
            bt_Listen.Location = new Point(15, 12);
            bt_Listen.Name = "bt_Listen";
            bt_Listen.Size = new Size(94, 29);
            bt_Listen.TabIndex = 2;
            bt_Listen.Text = "Listen";
            bt_Listen.UseVisualStyleBackColor = true;
            bt_Listen.Click += bt_Listen_Click;
            // 
            // rtb_main
            // 
            rtb_main.Location = new Point(15, 49);
            rtb_main.Name = "rtb_main";
            rtb_main.ReadOnly = true;
            rtb_main.Size = new Size(568, 652);
            rtb_main.TabIndex = 3;
            rtb_main.Text = "";
            // 
            // Ex3_Server
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 713);
            Controls.Add(rtb_main);
            Controls.Add(bt_Listen);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(privateKey);
            Controls.Add(publicKey);
            Controls.Add(latestMsg);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Ex3_Server";
            Text = "Ex3_Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox latestMsg;
        private TextBox publicKey;
        private TextBox privateKey;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button bt_Listen;
        private RichTextBox rtb_main;
    }
}