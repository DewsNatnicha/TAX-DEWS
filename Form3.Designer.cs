namespace TAX_DEWS
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.gohome = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TBearn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB50 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBsumtax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBearnall = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBtax = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.g4 = new System.Windows.Forms.TextBox();
            this.g3 = new System.Windows.Forms.TextBox();
            this.g2 = new System.Windows.Forms.TextBox();
            this.g1 = new System.Windows.Forms.TextBox();
            this.g5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gohome
            // 
            this.gohome.BackColor = System.Drawing.Color.Navy;
            this.gohome.Font = new System.Drawing.Font("RSU", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gohome.ForeColor = System.Drawing.SystemColors.Window;
            this.gohome.Location = new System.Drawing.Point(12, 497);
            this.gohome.Name = "gohome";
            this.gohome.Size = new System.Drawing.Size(121, 49);
            this.gohome.TabIndex = 15;
            this.gohome.Text = "< ย้อนกลับ";
            this.gohome.UseVisualStyleBackColor = false;
            this.gohome.Click += new System.EventHandler(this.gohome_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(685, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 42);
            this.label8.TabIndex = 18;
            this.label8.Text = "บาท";
            // 
            // TBearn
            // 
            this.TBearn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TBearn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBearn.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TBearn.ForeColor = System.Drawing.SystemColors.Window;
            this.TBearn.Location = new System.Drawing.Point(399, 153);
            this.TBearn.Name = "TBearn";
            this.TBearn.ReadOnly = true;
            this.TBearn.Size = new System.Drawing.Size(263, 40);
            this.TBearn.TabIndex = 17;
            this.TBearn.Text = "0";
            this.TBearn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(165, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 42);
            this.label9.TabIndex = 16;
            this.label9.Text = "รายได้ทั้งหมด (ต่อปี)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(685, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 42);
            this.label1.TabIndex = 21;
            this.label1.Text = "บาท";
            // 
            // TB50
            // 
            this.TB50.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TB50.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB50.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TB50.ForeColor = System.Drawing.SystemColors.Window;
            this.TB50.Location = new System.Drawing.Point(399, 212);
            this.TB50.Name = "TB50";
            this.TB50.ReadOnly = true;
            this.TB50.Size = new System.Drawing.Size(263, 40);
            this.TB50.TabIndex = 20;
            this.TB50.Text = "0";
            this.TB50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 42);
            this.label2.TabIndex = 19;
            this.label2.Text = "รายจ่าย 50% ของรายได้";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(685, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 42);
            this.label3.TabIndex = 24;
            this.label3.Text = "บาท";
            // 
            // TBsumtax
            // 
            this.TBsumtax.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TBsumtax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBsumtax.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TBsumtax.ForeColor = System.Drawing.SystemColors.Window;
            this.TBsumtax.Location = new System.Drawing.Point(399, 272);
            this.TBsumtax.Name = "TBsumtax";
            this.TBsumtax.ReadOnly = true;
            this.TBsumtax.Size = new System.Drawing.Size(263, 40);
            this.TBsumtax.TabIndex = 23;
            this.TBsumtax.Text = "0";
            this.TBsumtax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 42);
            this.label4.TabIndex = 22;
            this.label4.Text = "รวมค่าลดหย่อน";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(685, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 42);
            this.label5.TabIndex = 27;
            this.label5.Text = "บาท";
            // 
            // TBearnall
            // 
            this.TBearnall.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TBearnall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBearnall.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TBearnall.ForeColor = System.Drawing.SystemColors.Window;
            this.TBearnall.Location = new System.Drawing.Point(399, 333);
            this.TBearnall.Name = "TBearnall";
            this.TBearnall.ReadOnly = true;
            this.TBearnall.Size = new System.Drawing.Size(263, 40);
            this.TBearnall.TabIndex = 26;
            this.TBearnall.Text = "0";
            this.TBearnall.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(259, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 42);
            this.label6.TabIndex = 25;
            this.label6.Text = "รายได้สุทธิ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(685, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 42);
            this.label7.TabIndex = 30;
            this.label7.Text = "บาท";
            // 
            // TBtax
            // 
            this.TBtax.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TBtax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBtax.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TBtax.ForeColor = System.Drawing.SystemColors.Window;
            this.TBtax.Location = new System.Drawing.Point(399, 394);
            this.TBtax.Name = "TBtax";
            this.TBtax.ReadOnly = true;
            this.TBtax.Size = new System.Drawing.Size(263, 40);
            this.TBtax.TabIndex = 29;
            this.TBtax.Text = "0";
            this.TBtax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(226, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 42);
            this.label10.TabIndex = 28;
            this.label10.Text = "ภาษีที่ต้องจ่าย";
            // 
            // g4
            // 
            this.g4.BackColor = System.Drawing.SystemColors.Window;
            this.g4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.g4.Font = new System.Drawing.Font("RSU", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.g4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.g4.Location = new System.Drawing.Point(928, 59);
            this.g4.Name = "g4";
            this.g4.ReadOnly = true;
            this.g4.Size = new System.Drawing.Size(242, 10);
            this.g4.TabIndex = 116;
            this.g4.Text = "0";
            this.g4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // g3
            // 
            this.g3.BackColor = System.Drawing.SystemColors.Window;
            this.g3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.g3.Font = new System.Drawing.Font("RSU", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.g3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.g3.Location = new System.Drawing.Point(928, 44);
            this.g3.Name = "g3";
            this.g3.ReadOnly = true;
            this.g3.Size = new System.Drawing.Size(242, 10);
            this.g3.TabIndex = 115;
            this.g3.Text = "0";
            this.g3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // g2
            // 
            this.g2.BackColor = System.Drawing.SystemColors.Window;
            this.g2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.g2.Font = new System.Drawing.Font("RSU", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.g2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.g2.Location = new System.Drawing.Point(928, 28);
            this.g2.Name = "g2";
            this.g2.ReadOnly = true;
            this.g2.Size = new System.Drawing.Size(242, 10);
            this.g2.TabIndex = 114;
            this.g2.Text = "0";
            this.g2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // g1
            // 
            this.g1.BackColor = System.Drawing.SystemColors.Window;
            this.g1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.g1.Font = new System.Drawing.Font("RSU", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.g1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.g1.Location = new System.Drawing.Point(928, 12);
            this.g1.Name = "g1";
            this.g1.ReadOnly = true;
            this.g1.Size = new System.Drawing.Size(242, 10);
            this.g1.TabIndex = 113;
            this.g1.Text = "0";
            this.g1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // g5
            // 
            this.g5.BackColor = System.Drawing.SystemColors.Window;
            this.g5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.g5.Font = new System.Drawing.Font("RSU", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.g5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.g5.Location = new System.Drawing.Point(928, 75);
            this.g5.Name = "g5";
            this.g5.ReadOnly = true;
            this.g5.Size = new System.Drawing.Size(242, 10);
            this.g5.TabIndex = 117;
            this.g5.Text = "0";
            this.g5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 558);
            this.Controls.Add(this.g5);
            this.Controls.Add(this.g4);
            this.Controls.Add(this.g3);
            this.Controls.Add(this.g2);
            this.Controls.Add(this.g1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBtax);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBearnall);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBsumtax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB50);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TBearn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gohome);
            this.Name = "Form3";
            this.Text = "สรุปผล";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gohome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBearn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB50;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBsumtax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBearnall;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBtax;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox g4;
        public System.Windows.Forms.TextBox g3;
        public System.Windows.Forms.TextBox g2;
        public System.Windows.Forms.TextBox g1;
        public System.Windows.Forms.TextBox g5;
    }
}