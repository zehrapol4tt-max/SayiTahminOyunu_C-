namespace SayiTahminOyunu
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
            btnTahminEt = new Button();
            txtTahmin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblSonuc = new Label();
            lblTahminSayi = new Label();
            SuspendLayout();
            // 
            // btnTahminEt
            // 
            btnTahminEt.Location = new Point(754, 349);
            btnTahminEt.Name = "btnTahminEt";
            btnTahminEt.Size = new Size(304, 81);
            btnTahminEt.TabIndex = 0;
            btnTahminEt.Text = "TAHMİN ET";
            btnTahminEt.UseVisualStyleBackColor = true;
            btnTahminEt.Click += btnTahminEt_Click;
            // 
            // txtTahmin
            // 
            txtTahmin.Location = new Point(632, 215);
            txtTahmin.Name = "txtTahmin";
            txtTahmin.Size = new Size(543, 75);
            txtTahmin.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 556);
            label1.Name = "label1";
            label1.Size = new Size(210, 68);
            label1.TabIndex = 2;
            label1.Text = "SONUÇ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 746);
            label2.Name = "label2";
            label2.Size = new Size(385, 68);
            label2.TabIndex = 3;
            label2.Text = "TAHMİN SAYISI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 222);
            label3.Name = "label3";
            label3.Size = new Size(335, 68);
            label3.TabIndex = 4;
            label3.Text = "GİRİLEN SAYI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(301, 43);
            label4.Name = "label4";
            label4.Size = new Size(1262, 68);
            label4.TabIndex = 5;
            label4.Text = "1 VE 100 ARASINDA BIR SAYI GİRİNİZ.(1 VE 100 DAHİL)";
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(560, 556);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(0, 68);
            lblSonuc.TabIndex = 6;
            // 
            // lblTahminSayi
            // 
            lblTahminSayi.AutoSize = true;
            lblTahminSayi.Location = new Point(754, 746);
            lblTahminSayi.Name = "lblTahminSayi";
            lblTahminSayi.Size = new Size(56, 68);
            lblTahminSayi.TabIndex = 7;
            lblTahminSayi.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(28F, 68F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1723, 956);
            Controls.Add(lblTahminSayi);
            Controls.Add(lblSonuc);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTahmin);
            Controls.Add(btnTahminEt);
            Font = new Font("Segoe UI", 19F);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTahminEt;
        private TextBox txtTahmin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblSonuc;
        private Label lblTahminSayi;
    }
}
