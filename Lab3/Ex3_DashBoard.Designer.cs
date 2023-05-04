namespace Lab3
{
    partial class Ex3_DashBoard
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
            btn_Client = new Button();
            btn_Server = new Button();
            SuspendLayout();
            // 
            // btn_Client
            // 
            btn_Client.Location = new Point(272, 241);
            btn_Client.Name = "btn_Client";
            btn_Client.Size = new Size(236, 81);
            btn_Client.TabIndex = 3;
            btn_Client.Text = "Open new TCP Client";
            btn_Client.UseVisualStyleBackColor = true;
            btn_Client.Click += btn_Client_Click;
            // 
            // btn_Server
            // 
            btn_Server.Location = new Point(272, 80);
            btn_Server.Name = "btn_Server";
            btn_Server.Size = new Size(236, 81);
            btn_Server.TabIndex = 2;
            btn_Server.Text = "Open TCP Server";
            btn_Server.UseVisualStyleBackColor = true;
            btn_Server.Click += btn_Server_Click;
            // 
            // Ex3_DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Client);
            Controls.Add(btn_Server);
            Name = "Ex3_DashBoard";
            Text = "Ex3_DashBoard";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Client;
        private Button btn_Server;
    }
}