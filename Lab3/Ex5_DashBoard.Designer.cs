namespace Lab3
{
    partial class Ex5_DashBoard
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
            TCPClient = new Button();
            TCPServer = new Button();
            SuspendLayout();
            // 
            // TCPClient
            // 
            TCPClient.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TCPClient.Location = new Point(227, 47);
            TCPClient.Name = "TCPClient";
            TCPClient.Size = new Size(138, 50);
            TCPClient.TabIndex = 1;
            TCPClient.Text = "TCP Client";
            TCPClient.UseVisualStyleBackColor = true;
            TCPClient.Click += TCPClient_Click;
            // 
            // TCPServer
            // 
            TCPServer.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TCPServer.Location = new Point(42, 47);
            TCPServer.Name = "TCPServer";
            TCPServer.Size = new Size(141, 50);
            TCPServer.TabIndex = 2;
            TCPServer.Text = "TCP Server";
            TCPServer.UseVisualStyleBackColor = true;
            TCPServer.Click += TCPServer_Click;
            // 
            // Ex5_DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 146);
            Controls.Add(TCPClient);
            Controls.Add(TCPServer);
            Name = "Ex5_DashBoard";
            Text = "Ex5_DashBoard";
            ResumeLayout(false);
        }

        #endregion

        private Button TCPClient;
        private Button TCPServer;
    }
}