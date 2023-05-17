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
            txtUrl = new TextBox();
            btnGet = new Button();
            prgBar = new ProgressBar();
            panelArticles = new Panel();
            SuspendLayout();
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(12, 12);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(1005, 27);
            txtUrl.TabIndex = 9;
            // 
            // btnGet
            // 
            btnGet.Location = new Point(1023, 10);
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
            prgBar.MarqueeAnimationSpeed = 10;
            prgBar.Name = "prgBar";
            prgBar.Size = new Size(125, 21);
            prgBar.TabIndex = 7;
            prgBar.Visible = false;
            // 
            // panelArticles
            // 
            panelArticles.AutoScroll = true;
            panelArticles.Location = new Point(12, 53);
            panelArticles.Name = "panelArticles";
            panelArticles.Size = new Size(1119, 529);
            panelArticles.TabIndex = 11;
            // 
            // Ex6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 629);
            Controls.Add(panelArticles);
            Controls.Add(txtUrl);
            Controls.Add(btnGet);
            Controls.Add(prgBar);
            Name = "Ex6";
            Text = "Ex6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUrl;
        private Button btnGet;
        private ProgressBar prgBar;
        private Panel panelArticles;
    }
}