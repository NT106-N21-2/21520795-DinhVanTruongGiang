namespace Lab3
{
    partial class Ex5_Client
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
            tb_Message = new TextBox();
            tb_Name = new TextBox();
            rtb_Client = new RichTextBox();
            lb_Message = new Label();
            lb_Name = new Label();
            btn_Send = new Button();
            SuspendLayout();
            // 
            // tb_Message
            // 
            tb_Message.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Message.Location = new Point(12, 410);
            tb_Message.Name = "tb_Message";
            tb_Message.Size = new Size(646, 30);
            tb_Message.TabIndex = 17;
            // 
            // tb_Name
            // 
            tb_Name.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Name.Location = new Point(12, 341);
            tb_Name.Name = "tb_Name";
            tb_Name.Size = new Size(312, 30);
            tb_Name.TabIndex = 16;
            // 
            // rtb_Client
            // 
            rtb_Client.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rtb_Client.Location = new Point(12, 11);
            rtb_Client.Name = "rtb_Client";
            rtb_Client.ReadOnly = true;
            rtb_Client.Size = new Size(776, 301);
            rtb_Client.TabIndex = 15;
            rtb_Client.Text = "";
            // 
            // lb_Message
            // 
            lb_Message.AutoSize = true;
            lb_Message.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Message.Location = new Point(12, 384);
            lb_Message.Name = "lb_Message";
            lb_Message.Size = new Size(76, 23);
            lb_Message.TabIndex = 14;
            lb_Message.Text = "Message";
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Name.Location = new Point(12, 315);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(92, 23);
            lb_Name.TabIndex = 13;
            lb_Name.Text = "Your name";
            // 
            // btn_Send
            // 
            btn_Send.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Send.Location = new Point(684, 400);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(104, 37);
            btn_Send.TabIndex = 12;
            btn_Send.Text = "Send";
            btn_Send.UseVisualStyleBackColor = true;
            btn_Send.Click += btn_Send_Click;
            // 
            // Ex5_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb_Message);
            Controls.Add(tb_Name);
            Controls.Add(rtb_Client);
            Controls.Add(lb_Message);
            Controls.Add(lb_Name);
            Controls.Add(btn_Send);
            Name = "Ex5_Client";
            Text = "Ex5_Client";
            FormClosing += Ex5_Client_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_Message;
        private TextBox tb_Name;
        private RichTextBox rtb_Client;
        private Label lb_Message;
        private Label lb_Name;
        private Button btn_Send;
    }
}