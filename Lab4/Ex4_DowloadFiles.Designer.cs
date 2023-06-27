namespace Lab4
{
    partial class Ex4_DowloadFiles
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
            btnDowload = new Button();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(152, 22);
            label1.TabIndex = 0;
            label1.Text = "Enter a HTML tag";
            // 
            // btnDowload
            // 
            btnDowload.Location = new Point(567, 16);
            btnDowload.Name = "btnDowload";
            btnDowload.Size = new Size(170, 29);
            btnDowload.TabIndex = 1;
            btnDowload.Text = "Download/Show";
            btnDowload.UseVisualStyleBackColor = true;
            btnDowload.Click += btnDowload_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 30);
            textBox1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 83);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(725, 449);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(108, 22);
            label2.TabIndex = 4;
            label2.Text = "List of Items";
            // 
            // Ex4_DowloadFiles
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 544);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(btnDowload);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Ex4_DowloadFiles";
            Text = "Ex4_DowloadFiles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnDowload;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private Label label2;
    }
}