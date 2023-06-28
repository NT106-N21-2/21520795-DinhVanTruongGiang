namespace Lab6
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
            groupBox1 = new GroupBox();
            btn_Encode = new Button();
            label4 = new Label();
            label3 = new Label();
            rtb_inputData = new RichTextBox();
            label2 = new Label();
            rtb_Encode = new RichTextBox();
            rtb_Decode = new RichTextBox();
            label1 = new Label();
            tb_Key = new TextBox();
            btn_Decode = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(btn_Encode);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(rtb_inputData);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(rtb_Encode);
            groupBox1.Controls.Add(rtb_Decode);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tb_Key);
            groupBox1.Controls.Add(btn_Decode);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(15, 18);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(761, 697);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "MÃ HOÁ VIGENÈRE";
            // 
            // btn_Encode
            // 
            btn_Encode.BackColor = SystemColors.ActiveBorder;
            btn_Encode.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Encode.Location = new Point(393, 33);
            btn_Encode.Margin = new Padding(3, 4, 3, 4);
            btn_Encode.Name = "btn_Encode";
            btn_Encode.Size = new Size(171, 44);
            btn_Encode.TabIndex = 10;
            btn_Encode.Text = "MÃ HOÁ";
            btn_Encode.UseVisualStyleBackColor = false;
            btn_Encode.Click += btn_Encode_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 45);
            label4.Name = "label4";
            label4.Size = new Size(37, 23);
            label4.TabIndex = 9;
            label4.Text = "Key";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 124);
            label3.Name = "label3";
            label3.Size = new Size(120, 23);
            label3.TabIndex = 8;
            label3.Text = "Dữ liệu (Input)";
            // 
            // rtb_inputData
            // 
            rtb_inputData.Location = new Point(7, 149);
            rtb_inputData.Margin = new Padding(3, 4, 3, 4);
            rtb_inputData.Name = "rtb_inputData";
            rtb_inputData.Size = new Size(747, 132);
            rtb_inputData.TabIndex = 7;
            rtb_inputData.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 288);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 6;
            label2.Text = "Mã hoá";
            // 
            // rtb_Encode
            // 
            rtb_Encode.Location = new Point(7, 313);
            rtb_Encode.Margin = new Padding(3, 4, 3, 4);
            rtb_Encode.Name = "rtb_Encode";
            rtb_Encode.ReadOnly = true;
            rtb_Encode.Size = new Size(747, 165);
            rtb_Encode.TabIndex = 5;
            rtb_Encode.Text = "";
            // 
            // rtb_Decode
            // 
            rtb_Decode.Location = new Point(7, 523);
            rtb_Decode.Margin = new Padding(3, 4, 3, 4);
            rtb_Decode.Name = "rtb_Decode";
            rtb_Decode.ReadOnly = true;
            rtb_Decode.Size = new Size(747, 165);
            rtb_Decode.TabIndex = 4;
            rtb_Decode.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 497);
            label1.Name = "label1";
            label1.Size = new Size(68, 23);
            label1.TabIndex = 2;
            label1.Text = "Giải mã";
            // 
            // tb_Key
            // 
            tb_Key.Location = new Point(7, 71);
            tb_Key.Margin = new Padding(3, 4, 3, 4);
            tb_Key.Name = "tb_Key";
            tb_Key.Size = new Size(206, 29);
            tb_Key.TabIndex = 1;
            tb_Key.KeyPress += tb_Key_KeyPress;
            // 
            // btn_Decode
            // 
            btn_Decode.BackColor = SystemColors.ActiveBorder;
            btn_Decode.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Decode.Location = new Point(583, 32);
            btn_Decode.Margin = new Padding(3, 4, 3, 4);
            btn_Decode.Name = "btn_Decode";
            btn_Decode.Size = new Size(171, 44);
            btn_Decode.TabIndex = 0;
            btn_Decode.Text = "GIẢI MÃ";
            btn_Decode.UseVisualStyleBackColor = false;
            btn_Decode.Click += btn_Decode_Click;
            // 
            // Ex2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 732);
            Controls.Add(groupBox1);
            Name = "Ex2";
            Text = "Ex2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_Encode;
        private Label label4;
        private Label label3;
        private RichTextBox rtb_inputData;
        private Label label2;
        private RichTextBox rtb_Encode;
        private RichTextBox rtb_Decode;
        private Label label1;
        private TextBox tb_Key;
        private Button btn_Decode;
    }
}