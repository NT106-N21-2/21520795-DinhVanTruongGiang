namespace Lab3
{
    partial class Ex3_Server
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
            rtb_Result = new RichTextBox();
            btn_Listen = new Button();
            SuspendLayout();
            // 
            // rtb_Result
            // 
            rtb_Result.Location = new Point(12, 71);
            rtb_Result.Name = "rtb_Result";
            rtb_Result.ReadOnly = true;
            rtb_Result.Size = new Size(776, 367);
            rtb_Result.TabIndex = 3;
            rtb_Result.Text = "";
            // 
            // btn_Listen
            // 
            btn_Listen.Location = new Point(341, 12);
            btn_Listen.Name = "btn_Listen";
            btn_Listen.Size = new Size(132, 44);
            btn_Listen.TabIndex = 2;
            btn_Listen.Text = "Listen";
            btn_Listen.UseVisualStyleBackColor = true;
            btn_Listen.Click += btn_Listen_Click;
            // 
            // Ex3_Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtb_Result);
            Controls.Add(btn_Listen);
            Name = "Ex3_Server";
            Text = "Ex3_Server";
            FormClosed += Ex3_Server_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtb_Result;
        private Button btn_Listen;
    }
}