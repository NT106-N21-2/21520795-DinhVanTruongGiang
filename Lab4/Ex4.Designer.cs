namespace Lab4
{
    partial class Ex4
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
            btnViewWeb = new Button();
            btnDownLoad = new Button();
            btnViewSource = new Button();
            btnPrevious = new Button();
            btnNextPage = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // tbxURL
            // 
            tbxURL.Location = new Point(12, 12);
            tbxURL.Name = "tbxURL";
            tbxURL.Size = new Size(521, 30);
            tbxURL.TabIndex = 0;
            // 
            // btnViewWeb
            // 
            btnViewWeb.Location = new Point(661, 11);
            btnViewWeb.Name = "btnViewWeb";
            btnViewWeb.Size = new Size(112, 30);
            btnViewWeb.TabIndex = 1;
            btnViewWeb.Text = "View Web";
            btnViewWeb.UseVisualStyleBackColor = true;
            btnViewWeb.Click += btnViewWeb_Click;
            // 
            // btnDownLoad
            // 
            btnDownLoad.Location = new Point(779, 11);
            btnDownLoad.Name = "btnDownLoad";
            btnDownLoad.Size = new Size(112, 30);
            btnDownLoad.TabIndex = 1;
            btnDownLoad.Text = "Download";
            btnDownLoad.UseVisualStyleBackColor = true;
            btnDownLoad.Click += btnDownLoad_Click;
            // 
            // btnViewSource
            // 
            btnViewSource.Location = new Point(897, 11);
            btnViewSource.Name = "btnViewSource";
            btnViewSource.Size = new Size(120, 30);
            btnViewSource.TabIndex = 1;
            btnViewSource.Text = "View Source";
            btnViewSource.UseVisualStyleBackColor = true;
            btnViewSource.Click += btnViewSource_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(539, 12);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(55, 30);
            btnPrevious.TabIndex = 2;
            btnPrevious.Text = "<<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(600, 11);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(55, 30);
            btnNextPage.TabIndex = 2;
            btnNextPage.Text = ">>";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(12, 57);
            webView21.Name = "webView21";
            webView21.Size = new Size(1072, 578);
            webView21.TabIndex = 3;
            webView21.ZoomFactor = 1D;
            // 
            // Ex4
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 647);
            Controls.Add(webView21);
            Controls.Add(btnNextPage);
            Controls.Add(btnPrevious);
            Controls.Add(btnViewSource);
            Controls.Add(btnDownLoad);
            Controls.Add(btnViewWeb);
            Controls.Add(tbxURL);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Ex4";
            Text = "Ex4";
            Load += Ex4_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxURL;
        private Button btnViewWeb;
        private Button btnDownLoad;
        private Button btnViewSource;
        private Button btnPrevious;
        private Button btnNextPage;
        private System.CodeDom.CodeTypeReference webControl1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}