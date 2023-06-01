namespace Lab5
{
    partial class Ex4_MailView
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
            tb_From = new TextBox();
            tb_To = new TextBox();
            tb_Sub = new TextBox();
            bt_Rep = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            richTextBox1 = new RichTextBox();
            bt_Download = new Button();
            listBox1 = new ListBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 23);
            label1.TabIndex = 0;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 45);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 23);
            label2.TabIndex = 0;
            label2.Text = "To:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 115);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 23);
            label3.TabIndex = 0;
            label3.Text = "Subject:";
            // 
            // tb_From
            // 
            tb_From.Location = new Point(98, 9);
            tb_From.Name = "tb_From";
            tb_From.ReadOnly = true;
            tb_From.Size = new Size(469, 30);
            tb_From.TabIndex = 1;
            // 
            // tb_To
            // 
            tb_To.Location = new Point(98, 45);
            tb_To.Multiline = true;
            tb_To.Name = "tb_To";
            tb_To.ReadOnly = true;
            tb_To.Size = new Size(469, 59);
            tb_To.TabIndex = 1;
            // 
            // tb_Sub
            // 
            tb_Sub.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tb_Sub.Location = new Point(98, 110);
            tb_Sub.Name = "tb_Sub";
            tb_Sub.ReadOnly = true;
            tb_Sub.Size = new Size(800, 39);
            tb_Sub.TabIndex = 1;
            // 
            // bt_Rep
            // 
            bt_Rep.Location = new Point(622, 9);
            bt_Rep.Name = "bt_Rep";
            bt_Rep.Size = new Size(93, 61);
            bt_Rep.TabIndex = 3;
            bt_Rep.Text = "Reply";
            bt_Rep.UseVisualStyleBackColor = true;
            bt_Rep.Click += bt_Rep_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(13, 155);
            webView21.Name = "webView21";
            webView21.Size = new Size(885, 556);
            webView21.TabIndex = 4;
            webView21.ZoomFactor = 1D;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(13, 155);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(885, 556);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // bt_Download
            // 
            bt_Download.Location = new Point(915, 7);
            bt_Download.Name = "bt_Download";
            bt_Download.Size = new Size(263, 61);
            bt_Download.TabIndex = 3;
            bt_Download.Text = "Download File";
            bt_Download.UseVisualStyleBackColor = true;
            bt_Download.Click += bt_Download_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 22;
            listBox1.Location = new Point(915, 155);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(263, 554);
            listBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(915, 77);
            button1.Name = "button1";
            button1.Size = new Size(263, 61);
            button1.TabIndex = 3;
            button1.Text = "Download All Files";
            button1.UseVisualStyleBackColor = true;
            // 
            // Ex4_MailView
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 723);
            Controls.Add(listBox1);
            Controls.Add(richTextBox1);
            Controls.Add(webView21);
            Controls.Add(button1);
            Controls.Add(bt_Download);
            Controls.Add(bt_Rep);
            Controls.Add(tb_To);
            Controls.Add(tb_Sub);
            Controls.Add(tb_From);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Ex4_MailView";
            Text = "Ex4_MailView";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_From;
        private TextBox tb_To;
        private TextBox tb_Sub;
        private Button bt_Rep;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private RichTextBox richTextBox1;
        private Button bt_Download;
        private ListBox listBox1;
        private Button button1;
    }
}