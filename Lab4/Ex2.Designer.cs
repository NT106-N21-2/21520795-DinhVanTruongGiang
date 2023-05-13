namespace Lab4
{
    partial class Ex2
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
            tb_URL = new TextBox();
            tb_Data = new TextBox();
            rtb_Response = new RichTextBox();
            btn_Post = new Button();
            SuspendLayout();
            // 
            // tb_URL
            // 
            tb_URL.Location = new Point(12, 12);
            tb_URL.Name = "tb_URL";
            tb_URL.ReadOnly = true;
            tb_URL.Size = new Size(659, 27);
            tb_URL.TabIndex = 0;
            tb_URL.Text = "http://www.contoso.com/PostAccepter.aspx";
            // 
            // tb_Data
            // 
            tb_Data.Location = new Point(12, 45);
            tb_Data.Name = "tb_Data";
            tb_Data.Size = new Size(659, 27);
            tb_Data.TabIndex = 1;
            // 
            // rtb_Response
            // 
            rtb_Response.Location = new Point(12, 78);
            rtb_Response.Name = "rtb_Response";
            rtb_Response.ReadOnly = true;
            rtb_Response.Size = new Size(776, 360);
            rtb_Response.TabIndex = 2;
            rtb_Response.Text = "";
            // 
            // btn_Post
            // 
            btn_Post.Location = new Point(677, 12);
            btn_Post.Name = "btn_Post";
            btn_Post.Size = new Size(111, 34);
            btn_Post.TabIndex = 3;
            btn_Post.Text = "POST";
            btn_Post.UseVisualStyleBackColor = true;
            btn_Post.Click += btn_Post_Click;
            // 
            // Ex2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Post);
            Controls.Add(rtb_Response);
            Controls.Add(tb_Data);
            Controls.Add(tb_URL);
            Name = "Ex2";
            Text = "Ex2";
            FormClosing += Ex2_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_URL;
        private TextBox tb_Data;
        private RichTextBox rtb_Response;
        private Button btn_Post;
    }
}