namespace CSharpp_TinhLaiSuat3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Numnam = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            txtGui = new NumericUpDown();
            cbxLai = new ComboBox();
            label5 = new Label();
            listLKQ = new ListBox();
            ((System.ComponentModel.ISupportInitialize)txtGui).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(176, 9);
            label1.Name = "label1";
            label1.Size = new Size(170, 33);
            label1.TabIndex = 0;
            label1.Text = "Tính Lãi Xuất";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.ForeColor = Color.Cornsilk;
            label2.Location = new Point(51, 65);
            label2.Name = "label2";
            label2.Size = new Size(104, 33);
            label2.TabIndex = 0;
            label2.Text = "Số Tiền";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveBorder;
            label3.ForeColor = Color.Cornsilk;
            label3.Location = new Point(51, 126);
            label3.Name = "label3";
            label3.Size = new Size(109, 33);
            label3.TabIndex = 0;
            label3.Text = "Lãi Suất";
            label3.Click += label1_Click;
            // 
            // Numnam
            // 
            Numnam.AutoSize = true;
            Numnam.BackColor = SystemColors.ActiveBorder;
            Numnam.ForeColor = Color.Cornsilk;
            Numnam.Location = new Point(51, 184);
            Numnam.Name = "Numnam";
            Numnam.Size = new Size(118, 33);
            Numnam.TabIndex = 0;
            Numnam.Text = "Năm Gửi";
            Numnam.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.Location = new Point(257, 230);
            button1.Name = "button1";
            button1.Size = new Size(130, 46);
            button1.TabIndex = 1;
            button1.Text = "Tính";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(216, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 40);
            textBox1.TabIndex = 2;
            // 
            // txtGui
            // 
            txtGui.Location = new Point(216, 184);
            txtGui.Name = "txtGui";
            txtGui.Size = new Size(212, 40);
            txtGui.TabIndex = 3;
            // 
            // cbxLai
            // 
            cbxLai.FormattingEnabled = true;
            cbxLai.Location = new Point(216, 126);
            cbxLai.Name = "cbxLai";
            cbxLai.Size = new Size(212, 41);
            cbxLai.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveBorder;
            label5.ForeColor = Color.Cornsilk;
            label5.Location = new Point(12, 280);
            label5.Name = "label5";
            label5.Size = new Size(110, 33);
            label5.TabIndex = 0;
            label5.Text = "Kết Quả";
            label5.Click += label1_Click;
            // 
            // listLKQ
            // 
            listLKQ.FormattingEnabled = true;
            listLKQ.ItemHeight = 33;
            listLKQ.Location = new Point(12, 328);
            listLKQ.Name = "listLKQ";
            listLKQ.Size = new Size(432, 334);
            listLKQ.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(553, 680);
            Controls.Add(listLKQ);
            Controls.Add(cbxLai);
            Controls.Add(txtGui);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(Numnam);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)txtGui).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label Numnam;
        private Button button1;
        private TextBox textBox1;
        private NumericUpDown txtGui;
        private ComboBox cbxLai;
        private Label label5;
        private ListBox listLKQ;
    }
}
