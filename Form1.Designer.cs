namespace TAX_DEWS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.TBpaym = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBbouns = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBpayelse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TBearn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.gohome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "เงินเดือน (ต่อเดือน)";
            // 
            // TBpaym
            // 
            this.TBpaym.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TBpaym.Location = new System.Drawing.Point(376, 128);
            this.TBpaym.Name = "TBpaym";
            this.TBpaym.Size = new System.Drawing.Size(263, 47);
            this.TBpaym.TabIndex = 1;
            this.TBpaym.Text = "0";
            this.TBpaym.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBpaym.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBpaym_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "โบนัส (ต่อปี)";
            // 
            // TBbouns
            // 
            this.TBbouns.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TBbouns.Location = new System.Drawing.Point(376, 188);
            this.TBbouns.Name = "TBbouns";
            this.TBbouns.Size = new System.Drawing.Size(263, 47);
            this.TBbouns.TabIndex = 3;
            this.TBbouns.Text = "0";
            this.TBbouns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBbouns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBbouns_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(662, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "บาท";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(662, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 42);
            this.label4.TabIndex = 5;
            this.label4.Text = "บาท";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(662, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 42);
            this.label5.TabIndex = 8;
            this.label5.Text = "บาท";
            // 
            // TBpayelse
            // 
            this.TBpayelse.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TBpayelse.Location = new System.Drawing.Point(376, 248);
            this.TBpayelse.Name = "TBpayelse";
            this.TBpayelse.Size = new System.Drawing.Size(263, 47);
            this.TBpayelse.TabIndex = 7;
            this.TBpayelse.Text = "0";
            this.TBpayelse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBpayelse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBpayelse_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(173, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 42);
            this.label6.TabIndex = 6;
            this.label6.Text = "รายได้อื่นๆ (ต่อปี)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("RSU", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Location = new System.Drawing.Point(206, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(483, 36);
            this.label7.TabIndex = 9;
            this.label7.Text = "* เฉพาะรายได้ที่ต้องเสียภาษีตามเกณฑ์ของกรมสรรพากร";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(662, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 42);
            this.label8.TabIndex = 12;
            this.label8.Text = "บาท";
            // 
            // TBearn
            // 
            this.TBearn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TBearn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBearn.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TBearn.ForeColor = System.Drawing.SystemColors.Window;
            this.TBearn.Location = new System.Drawing.Point(376, 363);
            this.TBearn.Name = "TBearn";
            this.TBearn.ReadOnly = true;
            this.TBearn.Size = new System.Drawing.Size(263, 40);
            this.TBearn.TabIndex = 11;
            this.TBearn.Text = "กรุณา \"ยืนยันข้อมูล\"";
            this.TBearn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(142, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 42);
            this.label9.TabIndex = 10;
            this.label9.Text = "รายได้ทั้งหมด (ต่อปี)";
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.Green;
            this.confirm.Font = new System.Drawing.Font("RSU", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.confirm.ForeColor = System.Drawing.SystemColors.Window;
            this.confirm.Location = new System.Drawing.Point(402, 415);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(215, 47);
            this.confirm.TabIndex = 13;
            this.confirm.Text = "ยืนยันข้อมูล";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // gohome
            // 
            this.gohome.BackColor = System.Drawing.Color.Navy;
            this.gohome.Font = new System.Drawing.Font("RSU", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gohome.ForeColor = System.Drawing.SystemColors.Window;
            this.gohome.Location = new System.Drawing.Point(758, 497);
            this.gohome.Name = "gohome";
            this.gohome.Size = new System.Drawing.Size(121, 49);
            this.gohome.TabIndex = 14;
            this.gohome.Text = "ถัดไป >";
            this.gohome.UseVisualStyleBackColor = false;
            this.gohome.Click += new System.EventHandler(this.gohome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(891, 558);
            this.Controls.Add(this.gohome);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TBearn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBpayelse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBbouns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBpaym);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "รายได้สุทธิ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBpaym;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBbouns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBpayelse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBearn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button gohome;
    }
}

