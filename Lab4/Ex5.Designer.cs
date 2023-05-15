namespace Lab4
{
    partial class Ex5
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
            label2 = new Label();
            lb_Page = new Label();
            lb_UsersPerPage = new Label();
            label5 = new Label();
            label6 = new Label();
            lb_totalPage = new Label();
            lb_totalUsers = new Label();
            label9 = new Label();
            btn_previousPage = new Button();
            btn_nextPage = new Button();
            pn_userInterface = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(51, 23);
            label1.TabIndex = 0;
            label1.Text = "Page:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 1;
            label2.Text = "Users/Page:";
            // 
            // lb_Page
            // 
            lb_Page.AutoSize = true;
            lb_Page.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Page.Location = new Point(69, 13);
            lb_Page.Name = "lb_Page";
            lb_Page.Size = new Size(19, 23);
            lb_Page.TabIndex = 2;
            lb_Page.Text = "0";
            // 
            // lb_UsersPerPage
            // 
            lb_UsersPerPage.AutoSize = true;
            lb_UsersPerPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_UsersPerPage.Location = new Point(117, 62);
            lb_UsersPerPage.Name = "lb_UsersPerPage";
            lb_UsersPerPage.Size = new Size(19, 23);
            lb_UsersPerPage.TabIndex = 3;
            lb_UsersPerPage.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(209, 13);
            label5.Name = "label5";
            label5.Size = new Size(92, 23);
            label5.TabIndex = 4;
            label5.Text = "Total Page:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(209, 62);
            label6.Name = "label6";
            label6.Size = new Size(96, 23);
            label6.TabIndex = 5;
            label6.Text = "Total Users:";
            // 
            // lb_totalPage
            // 
            lb_totalPage.AutoSize = true;
            lb_totalPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_totalPage.Location = new Point(307, 13);
            lb_totalPage.Name = "lb_totalPage";
            lb_totalPage.Size = new Size(19, 23);
            lb_totalPage.TabIndex = 6;
            lb_totalPage.Text = "0";
            // 
            // lb_totalUsers
            // 
            lb_totalUsers.AutoSize = true;
            lb_totalUsers.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb_totalUsers.Location = new Point(307, 62);
            lb_totalUsers.Name = "lb_totalUsers";
            lb_totalUsers.Size = new Size(19, 23);
            lb_totalUsers.TabIndex = 7;
            lb_totalUsers.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(475, 57);
            label9.Name = "label9";
            label9.Size = new Size(84, 25);
            label9.TabIndex = 8;
            label9.Text = "User List";
            // 
            // btn_previousPage
            // 
            btn_previousPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_previousPage.Location = new Point(375, 53);
            btn_previousPage.Name = "btn_previousPage";
            btn_previousPage.Size = new Size(94, 35);
            btn_previousPage.TabIndex = 9;
            btn_previousPage.Text = "<<";
            btn_previousPage.UseVisualStyleBackColor = true;
            btn_previousPage.Click += btn_previousPage_Click;
            // 
            // btn_nextPage
            // 
            btn_nextPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_nextPage.Location = new Point(565, 54);
            btn_nextPage.Name = "btn_nextPage";
            btn_nextPage.Size = new Size(94, 35);
            btn_nextPage.TabIndex = 10;
            btn_nextPage.Text = ">>";
            btn_nextPage.UseVisualStyleBackColor = true;
            btn_nextPage.Click += btn_nextPage_Click;
            // 
            // pn_userInterface
            // 
            pn_userInterface.AutoScroll = true;
            pn_userInterface.BorderStyle = BorderStyle.FixedSingle;
            pn_userInterface.Location = new Point(12, 100);
            pn_userInterface.Name = "pn_userInterface";
            pn_userInterface.Size = new Size(710, 642);
            pn_userInterface.TabIndex = 11;
            // 
            // Ex5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 754);
            Controls.Add(pn_userInterface);
            Controls.Add(btn_nextPage);
            Controls.Add(btn_previousPage);
            Controls.Add(label9);
            Controls.Add(lb_totalUsers);
            Controls.Add(lb_totalPage);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lb_UsersPerPage);
            Controls.Add(lb_Page);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ex5";
            Text = "Ex5";
            Load += Ex5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lb_Page;
        private Label lb_UsersPerPage;
        private Label label5;
        private Label label6;
        private Label lb_totalPage;
        private Label lb_totalUsers;
        private Label label9;
        private Button btn_previousPage;
        private Button btn_nextPage;
        private Panel pn_userInterface;
    }
}