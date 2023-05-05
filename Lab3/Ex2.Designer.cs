namespace Lab3
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
            StopListen = new Button();
            Listen = new Button();
            ListViewCommand = new ListView();
            SuspendLayout();
            // 
            // StopListen
            // 
            StopListen.Enabled = false;
            StopListen.Location = new Point(694, 12);
            StopListen.Name = "StopListen";
            StopListen.Size = new Size(94, 29);
            StopListen.TabIndex = 0;
            StopListen.Text = "Stop Listen";
            StopListen.UseVisualStyleBackColor = true;
            StopListen.Click += StopListen_Click;
            // 
            // Listen
            // 
            Listen.Location = new Point(594, 12);
            Listen.Name = "Listen";
            Listen.Size = new Size(94, 29);
            Listen.TabIndex = 1;
            Listen.Text = "Listen";
            Listen.UseVisualStyleBackColor = true;
            Listen.Click += Listen_Click;
            // 
            // ListViewCommand
            // 
            ListViewCommand.Location = new Point(12, 47);
            ListViewCommand.Name = "ListViewCommand";
            ListViewCommand.Size = new Size(776, 391);
            ListViewCommand.TabIndex = 2;
            ListViewCommand.UseCompatibleStateImageBehavior = false;
            // 
            // Ex2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListViewCommand);
            Controls.Add(Listen);
            Controls.Add(StopListen);
            Name = "Ex2";
            Text = "Ex2";
            Load += Ex2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button StopListen;
        private Button Listen;
        private ListView ListViewCommand;
    }
}