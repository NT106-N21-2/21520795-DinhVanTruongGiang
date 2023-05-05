namespace Lab3
{
    partial class Lab3_MainForm
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
            btn_Ex1 = new Button();
            btn_Ex2 = new Button();
            btn_Ex3 = new Button();
            btn_Ex4 = new Button();
            btn_Ex5 = new Button();
            btn_Exit = new Button();
            SuspendLayout();
            // 
            // btn_Ex1
            // 
            btn_Ex1.AutoSize = true;
            btn_Ex1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Ex1.Location = new Point(68, 53);
            btn_Ex1.Name = "btn_Ex1";
            btn_Ex1.Size = new Size(157, 75);
            btn_Ex1.TabIndex = 0;
            btn_Ex1.Text = "Exercise 1";
            btn_Ex1.UseVisualStyleBackColor = true;
            btn_Ex1.Click += btn_Ex1_Click;
            // 
            // btn_Ex2
            // 
            btn_Ex2.AutoSize = true;
            btn_Ex2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Ex2.Location = new Point(292, 53);
            btn_Ex2.Name = "btn_Ex2";
            btn_Ex2.Size = new Size(157, 75);
            btn_Ex2.TabIndex = 0;
            btn_Ex2.Text = "Exercise 2";
            btn_Ex2.UseVisualStyleBackColor = true;
            btn_Ex2.Click += btn_Ex2_Click;
            // 
            // btn_Ex3
            // 
            btn_Ex3.AutoSize = true;
            btn_Ex3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Ex3.Location = new Point(518, 53);
            btn_Ex3.Name = "btn_Ex3";
            btn_Ex3.Size = new Size(157, 75);
            btn_Ex3.TabIndex = 0;
            btn_Ex3.Text = "Exercise 3";
            btn_Ex3.UseVisualStyleBackColor = true;
            btn_Ex3.Click += btn_Ex3_Click;
            // 
            // btn_Ex4
            // 
            btn_Ex4.AutoSize = true;
            btn_Ex4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Ex4.Location = new Point(68, 190);
            btn_Ex4.Name = "btn_Ex4";
            btn_Ex4.Size = new Size(157, 75);
            btn_Ex4.TabIndex = 0;
            btn_Ex4.Text = "Exercise 4";
            btn_Ex4.UseVisualStyleBackColor = true;
            btn_Ex4.Click += btn_Ex4_Click;
            // 
            // btn_Ex5
            // 
            btn_Ex5.AutoSize = true;
            btn_Ex5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Ex5.Location = new Point(292, 190);
            btn_Ex5.Name = "btn_Ex5";
            btn_Ex5.Size = new Size(157, 75);
            btn_Ex5.TabIndex = 0;
            btn_Ex5.Text = "Exercise 5";
            btn_Ex5.UseVisualStyleBackColor = true;
            btn_Ex5.Click += btn_Ex5_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.AutoSize = true;
            btn_Exit.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Exit.Location = new Point(518, 190);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(157, 75);
            btn_Exit.TabIndex = 0;
            btn_Exit.Text = "EXIT";
            btn_Exit.UseVisualStyleBackColor = true;
            // 
            // Lab3_MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 342);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Ex5);
            Controls.Add(btn_Ex4);
            Controls.Add(btn_Ex3);
            Controls.Add(btn_Ex2);
            Controls.Add(btn_Ex1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Lab3_MainForm";
            Text = "Lab3_MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Ex1;
        private Button btn_Ex2;
        private Button btn_Ex3;
        private Button btn_Ex4;
        private Button btn_Ex5;
        private Button btn_Exit;
    }
}