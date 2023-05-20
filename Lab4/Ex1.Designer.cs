namespace Lab4
{
    partial class Ex1
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
            rtb_display = new RichTextBox();
            textBox1 = new TextBox();
            Get = new Button();
            SuspendLayout();
            // 
            // rtb_display
            // 
            rtb_display.Location = new Point(12, 47);
            rtb_display.Name = "rtb_display";
            rtb_display.Size = new Size(776, 391);
            rtb_display.TabIndex = 6;
            rtb_display.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(647, 27);
            textBox1.TabIndex = 5;
            // 
            // Get
            // 
            Get.Location = new Point(665, 12);
            Get.Name = "Get";
            Get.Size = new Size(123, 29);
            Get.TabIndex = 4;
            Get.Text = "GET";
            Get.UseVisualStyleBackColor = true;
            Get.Click += Get_Click;
            // 
            // Ex1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtb_display);
            Controls.Add(textBox1);
            Controls.Add(Get);
            Name = "Ex1";
            Text = "Ex1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtb_display;
        private TextBox textBox1;
        private Button Get;
    }
}