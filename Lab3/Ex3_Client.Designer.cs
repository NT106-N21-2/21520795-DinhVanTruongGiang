namespace Lab3
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
            btn_Disconnect = new Button();
            btn_Send = new Button();
            rtb_Input = new RichTextBox();
            btn_Connect = new Button();
            SuspendLayout();
            // 
            // btn_Disconnect
            // 
            btn_Disconnect.Location = new Point(646, 207);
            btn_Disconnect.Name = "btn_Disconnect";
            btn_Disconnect.Size = new Size(134, 60);
            btn_Disconnect.TabIndex = 7;
            btn_Disconnect.Text = "Disconnect";
            btn_Disconnect.UseVisualStyleBackColor = true;
            btn_Disconnect.Click += btn_Disconnect_Click;
            // 
            // btn_Send
            // 
            btn_Send.Location = new Point(646, 102);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(134, 60);
            btn_Send.TabIndex = 6;
            btn_Send.Text = "Send";
            btn_Send.UseVisualStyleBackColor = true;
            btn_Send.Click += btn_Send_Click;
            // 
            // rtb_Input
            // 
            rtb_Input.Location = new Point(21, 12);
            rtb_Input.Name = "rtb_Input";
            rtb_Input.Size = new Size(604, 426);
            rtb_Input.TabIndex = 5;
            rtb_Input.Text = "";
            rtb_Input.KeyDown += rtb_Input_KeyDown;
            rtb_Input.MouseDown += rtb_Input_MouseDown;
            rtb_Input.MouseUp += rtb_Input_MouseUp;
            rtb_Input.PreviewKeyDown += rtb_Input_PreviewKeyDown;
            // 
            // btn_Connect
            // 
            btn_Connect.Location = new Point(646, 12);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(134, 60);
            btn_Connect.TabIndex = 4;
            btn_Connect.Text = "Connect";
            btn_Connect.UseVisualStyleBackColor = true;
            btn_Connect.Click += btn_Connect_Click;
            // 
            // Ex3_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Disconnect);
            Controls.Add(btn_Send);
            Controls.Add(rtb_Input);
            Controls.Add(btn_Connect);
            Name = "Ex3_Client";
            Text = "Ex3_Client";
            FormClosed += Ex3_Client_FormClosed;
            Load += Ex3_Client_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Disconnect;
        private Button btn_Send;
        private RichTextBox rtb_Input;
        private Button btn_Connect;
    }
}