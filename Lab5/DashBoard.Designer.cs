namespace Lab5
{
    partial class DashBoard
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
            btn_Exit = new Button();
            btn_Ex4 = new Button();
            btn_Ex3 = new Button();
            btn_Ex2 = new Button();
            btn_Ex1 = new Button();
            SuspendLayout();
            // 
            // btn_Exit
            // 
            btn_Exit.AutoSize = true;
            btn_Exit.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Exit.Location = new Point(235, 174);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(157, 75);
            btn_Exit.TabIndex = 1;
            btn_Exit.Text = "EXIT";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_Ex4
            // 
            btn_Ex4.AutoSize = true;
            btn_Ex4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Ex4.Location = new Point(11, 174);
            btn_Ex4.Name = "btn_Ex4";
            btn_Ex4.Size = new Size(157, 75);
            btn_Ex4.TabIndex = 3;
            btn_Ex4.Text = "Exercise 4";
            btn_Ex4.UseVisualStyleBackColor = true;
            btn_Ex4.Click += btn_Ex4_Click;
            // 
            // btn_Ex3
            // 
            btn_Ex3.AutoSize = true;
            btn_Ex3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Ex3.Location = new Point(461, 37);
            btn_Ex3.Name = "btn_Ex3";
            btn_Ex3.Size = new Size(157, 75);
            btn_Ex3.TabIndex = 4;
            btn_Ex3.Text = "Exercise 3";
            btn_Ex3.UseVisualStyleBackColor = true;
            btn_Ex3.Click += btn_Ex3_Click;
            // 
            // btn_Ex2
            // 
            btn_Ex2.AutoSize = true;
            btn_Ex2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Ex2.Location = new Point(235, 37);
            btn_Ex2.Name = "btn_Ex2";
            btn_Ex2.Size = new Size(157, 75);
            btn_Ex2.TabIndex = 5;
            btn_Ex2.Text = "Exercise 2";
            btn_Ex2.UseVisualStyleBackColor = true;
            btn_Ex2.Click += btn_Ex2_Click;
            // 
            // btn_Ex1
            // 
            btn_Ex1.AutoSize = true;
            btn_Ex1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Ex1.Location = new Point(11, 37);
            btn_Ex1.Name = "btn_Ex1";
            btn_Ex1.Size = new Size(157, 75);
            btn_Ex1.TabIndex = 6;
            btn_Ex1.Text = "Exercise 1";
            btn_Ex1.UseVisualStyleBackColor = true;
            btn_Ex1.Click += btn_Ex1_Click;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 286);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Ex4);
            Controls.Add(btn_Ex3);
            Controls.Add(btn_Ex2);
            Controls.Add(btn_Ex1);
            Name = "DashBoard";
            Text = "DashBoard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Exit;
        private Button btn_Ex4;
        private Button btn_Ex3;
        private Button btn_Ex2;
        private Button btn_Ex1;
    }
}