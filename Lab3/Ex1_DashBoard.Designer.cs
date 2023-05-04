namespace Lab3
{
    partial class Ex1_DashBoard
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(33, 38);
            button1.Name = "button1";
            button1.Size = new Size(141, 50);
            button1.TabIndex = 0;
            button1.Text = "UDP Server";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(218, 38);
            button2.Name = "button2";
            button2.Size = new Size(138, 50);
            button2.TabIndex = 0;
            button2.Text = "UDP Client";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Ex1_DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 134);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Ex1_DashBoard";
            Text = "Ex1_DashBoard";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}