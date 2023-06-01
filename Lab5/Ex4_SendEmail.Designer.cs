namespace Lab5
{
    partial class Ex4_SendEmail
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
            label3 = new Label();
            label4 = new Label();
            tb_From = new TextBox();
            tb_To = new TextBox();
            tb_Sub = new TextBox();
            rtb_Body = new RichTextBox();
            bt_Send = new Button();
            attachmentListBox = new ListBox();
            bt_Clear = new Button();
            bt_Browse = new Button();
            cb_HTML = new CheckBox();
            bt_ClearAttachment = new Button();
            bt_ClearAttch = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 23);
            label1.Name = "label1";
            label1.Size = new Size(58, 22);
            label1.TabIndex = 0;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 64);
            label2.Name = "label2";
            label2.Size = new Size(37, 22);
            label2.TabIndex = 0;
            label2.Text = "To:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 124);
            label3.Name = "label3";
            label3.Size = new Size(75, 22);
            label3.TabIndex = 0;
            label3.Text = "Subject:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 179);
            label4.Name = "label4";
            label4.Size = new Size(58, 22);
            label4.TabIndex = 0;
            label4.Text = "Body:";
            // 
            // tb_From
            // 
            tb_From.Location = new Point(125, 20);
            tb_From.Name = "tb_From";
            tb_From.ReadOnly = true;
            tb_From.Size = new Size(308, 30);
            tb_From.TabIndex = 1;
            // 
            // tb_To
            // 
            tb_To.Location = new Point(125, 61);
            tb_To.Name = "tb_To";
            tb_To.Size = new Size(308, 30);
            tb_To.TabIndex = 1;
            // 
            // tb_Sub
            // 
            tb_Sub.Location = new Point(125, 116);
            tb_Sub.Multiline = true;
            tb_Sub.Name = "tb_Sub";
            tb_Sub.Size = new Size(597, 54);
            tb_Sub.TabIndex = 1;
            // 
            // rtb_Body
            // 
            rtb_Body.Location = new Point(125, 179);
            rtb_Body.Name = "rtb_Body";
            rtb_Body.Size = new Size(597, 475);
            rtb_Body.TabIndex = 2;
            rtb_Body.Text = "";
            // 
            // bt_Send
            // 
            bt_Send.Location = new Point(468, 23);
            bt_Send.Name = "bt_Send";
            bt_Send.Size = new Size(111, 68);
            bt_Send.TabIndex = 3;
            bt_Send.Text = "Send Email";
            bt_Send.UseVisualStyleBackColor = true;
            bt_Send.Click += bt_Send_Click;
            // 
            // attachmentListBox
            // 
            attachmentListBox.FormattingEnabled = true;
            attachmentListBox.ItemHeight = 22;
            attachmentListBox.Location = new Point(728, 116);
            attachmentListBox.Name = "attachmentListBox";
            attachmentListBox.Size = new Size(358, 532);
            attachmentListBox.TabIndex = 4;
            // 
            // bt_Clear
            // 
            bt_Clear.Location = new Point(585, 25);
            bt_Clear.Name = "bt_Clear";
            bt_Clear.Size = new Size(116, 68);
            bt_Clear.TabIndex = 3;
            bt_Clear.Text = "Clear Body";
            bt_Clear.UseVisualStyleBackColor = true;
            bt_Clear.Click += bt_Clear_Click;
            // 
            // bt_Browse
            // 
            bt_Browse.Location = new Point(707, 25);
            bt_Browse.Name = "bt_Browse";
            bt_Browse.Size = new Size(153, 66);
            bt_Browse.TabIndex = 3;
            bt_Browse.Text = "Browse File";
            bt_Browse.UseVisualStyleBackColor = true;
            bt_Browse.Click += bt_Browse_Click;
            // 
            // cb_HTML
            // 
            cb_HTML.AutoSize = true;
            cb_HTML.Location = new Point(29, 215);
            cb_HTML.Name = "cb_HTML";
            cb_HTML.Size = new Size(86, 26);
            cb_HTML.TabIndex = 5;
            cb_HTML.Text = "HTML";
            cb_HTML.UseVisualStyleBackColor = true;
            // 
            // bt_ClearAttachment
            // 
            bt_ClearAttachment.Location = new Point(866, 64);
            bt_ClearAttachment.Name = "bt_ClearAttachment";
            bt_ClearAttachment.Size = new Size(220, 36);
            bt_ClearAttachment.TabIndex = 3;
            bt_ClearAttachment.Text = "Clear All Attachment";
            bt_ClearAttachment.UseVisualStyleBackColor = true;
            bt_ClearAttachment.Click += bt_ClearAttachment_Click;
            // 
            // bt_ClearAttch
            // 
            bt_ClearAttch.Location = new Point(866, 20);
            bt_ClearAttch.Name = "bt_ClearAttch";
            bt_ClearAttch.Size = new Size(220, 38);
            bt_ClearAttch.TabIndex = 3;
            bt_ClearAttch.Text = "Clear Chosen Attachment";
            bt_ClearAttch.UseVisualStyleBackColor = true;
            bt_ClearAttch.Click += bt_ClearAttch_Click;
            // 
            // Ex4_SendEmail
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 666);
            Controls.Add(cb_HTML);
            Controls.Add(attachmentListBox);
            Controls.Add(bt_ClearAttch);
            Controls.Add(bt_ClearAttachment);
            Controls.Add(bt_Browse);
            Controls.Add(bt_Clear);
            Controls.Add(bt_Send);
            Controls.Add(rtb_Body);
            Controls.Add(tb_Sub);
            Controls.Add(tb_To);
            Controls.Add(tb_From);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Ex4_SendEmail";
            Text = "Ex4_SendEmail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tb_From;
        private TextBox tb_To;
        private TextBox tb_Sub;
        private RichTextBox rtb_Body;
        private Button bt_Send;
        private ListBox attachmentListBox;
        private Button bt_Clear;
        private Button bt_Browse;
        private CheckBox cb_HTML;
        private Button bt_ClearAttachment;
        private Button bt_ClearAttch;
    }
}