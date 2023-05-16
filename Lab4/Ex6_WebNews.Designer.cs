namespace Lab4
{
    partial class Ex6_WebNews
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
            webNews = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webNews).BeginInit();
            SuspendLayout();
            // 
            // webNews
            // 
            webNews.AllowExternalDrop = true;
            webNews.CreationProperties = null;
            webNews.DefaultBackgroundColor = Color.White;
            webNews.Location = new Point(12, 12);
            webNews.Name = "webNews";
            webNews.Size = new Size(890, 825);
            webNews.TabIndex = 0;
            webNews.ZoomFactor = 1D;
            // 
            // Ex6_WebNews
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(914, 849);
            Controls.Add(webNews);
            Name = "Ex6_WebNews";
            Text = "Ex6_WebNews";
            Load += Ex6_WebNews_Load;
            ((System.ComponentModel.ISupportInitialize)webNews).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webNews;
    }
}