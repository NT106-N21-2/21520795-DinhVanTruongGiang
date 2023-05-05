namespace Lab3
{
    partial class Ex4_TCP_BackupServer
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
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(40, 91);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(677, 397);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(430, 33);
            button1.Name = "button1";
            button1.Size = new Size(198, 39);
            button1.TabIndex = 1;
            button1.Text = "Stop Listening";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(152, 33);
            button2.Name = "button2";
            button2.Size = new Size(198, 39);
            button2.TabIndex = 1;
            button2.Text = "Start Listening";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Ex4_TCP_BackupServer
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 500);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Ex4_TCP_BackupServer";
            Text = "Ex4_TCP_BackupServer";
            Load += Ex4_TCP_BackupServer_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
    }
}