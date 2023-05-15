namespace Lab4
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
            tbxURL = new TextBox();
            tbxFileURL = new TextBox();
            btnDownload = new Button();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // tbxURL
            // 
            tbxURL.Location = new Point(21, 12);
            tbxURL.Name = "tbxURL";
            tbxURL.Size = new Size(566, 30);
            tbxURL.TabIndex = 0;
            // 
            // tbxFileURL
            // 
            tbxFileURL.Location = new Point(21, 58);
            tbxFileURL.Name = "tbxFileURL";
            tbxFileURL.Size = new Size(566, 30);
            tbxFileURL.TabIndex = 0;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(593, 13);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(136, 29);
            btnDownload.TabIndex = 1;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(25, 104);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.ScrollBars = ScrollBars.Both;
            textBox3.Size = new Size(704, 348);
            textBox3.TabIndex = 2;
            // 
            // Ex5
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 464);
            Controls.Add(textBox3);
            Controls.Add(btnDownload);
            Controls.Add(tbxFileURL);
            Controls.Add(tbxURL);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Ex5";
            Text = "Ex5";
            Load += Ex5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxURL;
        private TextBox tbxFileURL;
        private Button btnDownload;
        private TextBox textBox3;
    }
}