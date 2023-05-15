namespace Lab4
{
    partial class Ex6
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
            flowLayoutPanel = new FlowLayoutPanel();
            webNews = new Microsoft.Web.WebView2.WinForms.WebView2();
            textURL = new TextBox();
            btnGet = new Button();
            prgBar = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)webNews).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.BackColor = SystemColors.ButtonFace;
            flowLayoutPanel.Location = new Point(13, 53);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(761, 529);
            flowLayoutPanel.TabIndex = 11;
            // 
            // webNews
            // 
            webNews.AllowExternalDrop = true;
            webNews.CreationProperties = null;
            webNews.DefaultBackgroundColor = Color.White;
            webNews.Location = new Point(793, 53);
            webNews.Name = "webNews";
            webNews.Size = new Size(342, 529);
            webNews.TabIndex = 10;
            webNews.Visible = false;
            webNews.ZoomFactor = 1D;
            // 
            // textURL
            // 
            textURL.Location = new Point(12, 12);
            textURL.Name = "textURL";
            textURL.Size = new Size(647, 27);
            textURL.TabIndex = 9;
            // 
            // btnGet
            // 
            btnGet.Location = new Point(666, 11);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(108, 29);
            btnGet.TabIndex = 8;
            btnGet.Text = "GET";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // prgBar
            // 
            prgBar.Location = new Point(13, 596);
            prgBar.Name = "prgBar";
            prgBar.Size = new Size(125, 21);
            prgBar.TabIndex = 7;
            prgBar.Visible = false;
            // 
            // Ex6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 629);
            Controls.Add(flowLayoutPanel);
            Controls.Add(webNews);
            Controls.Add(textURL);
            Controls.Add(btnGet);
            Controls.Add(prgBar);
            Name = "Ex6";
            Text = "Ex6";
            ((System.ComponentModel.ISupportInitialize)webNews).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel;
        private Microsoft.Web.WebView2.WinForms.WebView2 webNews;
        private TextBox textURL;
        private Button btnGet;
        private ProgressBar prgBar;
    }
}