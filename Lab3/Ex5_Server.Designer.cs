namespace Lab3
{
    partial class Ex5_Server
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
            Listen = new Button();
            StopListen = new Button();
            serverTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // Listen
            // 
            Listen.Location = new Point(594, 12);
            Listen.Name = "Listen";
            Listen.Size = new Size(94, 29);
            Listen.TabIndex = 4;
            Listen.Text = "Listen";
            Listen.UseVisualStyleBackColor = true;
            Listen.Click += Listen_Click;
            // 
            // StopListen
            // 
            StopListen.Location = new Point(694, 12);
            StopListen.Name = "StopListen";
            StopListen.Size = new Size(94, 29);
            StopListen.TabIndex = 3;
            StopListen.Text = "Stop Listen";
            StopListen.UseVisualStyleBackColor = true;
            StopListen.Click += StopListen_Click;
            // 
            // serverTextBox
            // 
            serverTextBox.Location = new Point(12, 47);
            serverTextBox.Name = "serverTextBox";
            serverTextBox.ReadOnly = true;
            serverTextBox.Size = new Size(776, 391);
            serverTextBox.TabIndex = 5;
            serverTextBox.Text = "";
            // 
            // Ex5_Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(serverTextBox);
            Controls.Add(Listen);
            Controls.Add(StopListen);
            Name = "Ex5_Server";
            Text = "Ex5_Server";
            //Load += Ex5_Server_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Listen;
        private Button StopListen;
        private RichTextBox serverTextBox;
    }
}