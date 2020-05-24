namespace TAX_DEWS
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.CBstatus = new System.Windows.Forms.ComboBox();
            this.CBbaby = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NMbaby61 = new System.Windows.Forms.NumericUpDown();
            this.NMbaby62 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.CBfm = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBfm2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NMbabynum = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gohome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NMbaby61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMbaby62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMbabynum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "สถานภาพ";
            // 
            // CBstatus
            // 
            this.CBstatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBstatus.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.CBstatus.FormattingEnabled = true;
            this.CBstatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CBstatus.Items.AddRange(new object[] {
            "โสด",
            "หย่า",
            "หม้าย",
            "คู่สมรสมีเงินได้",
            "คู่สมรสไม่มีเงืนได้"});
            this.CBstatus.Location = new System.Drawing.Point(394, 94);
            this.CBstatus.Name = "CBstatus";
            this.CBstatus.Size = new System.Drawing.Size(235, 38);
            this.CBstatus.TabIndex = 2;
            // 
            // CBbaby
            // 
            this.CBbaby.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBbaby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBbaby.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.CBbaby.FormattingEnabled = true;
            this.CBbaby.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CBbaby.Items.AddRange(new object[] {
            "มี",
            "ไม่มี"});
            this.CBbaby.Location = new System.Drawing.Point(383, 196);
            this.CBbaby.Name = "CBbaby";
            this.CBbaby.Size = new System.Drawing.Size(120, 38);
            this.CBbaby.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "บุตร-ธิดา";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "บุตร-ธิดา ที่เกิดก่อนปี 2561";
            // 
            // NMbaby61
            // 
            this.NMbaby61.Font = new System.Drawing.Font("RSU", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.NMbaby61.Location = new System.Drawing.Point(563, 252);
            this.NMbaby61.Name = "NMbaby61";
            this.NMbaby61.Size = new System.Drawing.Size(74, 41);
            this.NMbaby61.TabIndex = 6;
            this.NMbaby61.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NMbaby62
            // 
            this.NMbaby62.Font = new System.Drawing.Font("RSU", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.NMbaby62.Location = new System.Drawing.Point(563, 304);
            this.NMbaby62.Name = "NMbaby62";
            this.NMbaby62.Size = new System.Drawing.Size(74, 41);
            this.NMbaby62.TabIndex = 8;
            this.NMbaby62.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 42);
            this.label4.TabIndex = 7;
            this.label4.Text = "บุตร-ธิดา ที่เกิดก่อนปี 2562";
            // 
            // CBfm
            // 
            this.CBfm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBfm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBfm.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.CBfm.FormattingEnabled = true;
            this.CBfm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CBfm.Items.AddRange(new object[] {
            "ไม่มี",
            "1",
            "2"});
            this.CBfm.Location = new System.Drawing.Point(514, 402);
            this.CBfm.Name = "CBfm";
            this.CBfm.Size = new System.Drawing.Size(91, 38);
            this.CBfm.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(303, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 42);
            this.label5.TabIndex = 9;
            this.label5.Text = "บิดา-มารดาตนเอง";
            // 
            // CBfm2
            // 
            this.CBfm2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBfm2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBfm2.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.CBfm2.FormattingEnabled = true;
            this.CBfm2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CBfm2.Items.AddRange(new object[] {
            "ไม่มี",
            "1",
            "2"});
            this.CBfm2.Location = new System.Drawing.Point(514, 446);
            this.CBfm2.Name = "CBfm2";
            this.CBfm2.Size = new System.Drawing.Size(91, 38);
            this.CBfm2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(293, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 42);
            this.label6.TabIndex = 11;
            this.label6.Text = "บิดา-มารดาคู่สมรส";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("RSU", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Location = new System.Drawing.Point(280, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(346, 36);
            this.label7.TabIndex = 13;
            this.label7.Text = "* กรณีคู่สมรสมีเงินได้ สามารถแยกยื่นได้";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("RSU", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.Location = new System.Drawing.Point(286, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(318, 36);
            this.label8.TabIndex = 14;
            this.label8.Text = "* คนละ 30,000 บาท ไม่จำกัดจำนวน";
            // 
            // NMbabynum
            // 
            this.NMbabynum.Font = new System.Drawing.Font("RSU", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.NMbabynum.Location = new System.Drawing.Point(523, 196);
            this.NMbabynum.Name = "NMbabynum";
            this.NMbabynum.Size = new System.Drawing.Size(74, 41);
            this.NMbabynum.TabIndex = 15;
            this.NMbabynum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("RSU", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(603, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 42);
            this.label9.TabIndex = 16;
            this.label9.Text = "คน";
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.Green;
            this.confirm.Font = new System.Drawing.Font("RSU", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.confirm.ForeColor = System.Drawing.SystemColors.Window;
            this.confirm.Location = new System.Drawing.Point(347, 505);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(215, 47);
            this.confirm.TabIndex = 17;
            this.confirm.Text = "ยืนยันข้อมูล";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.Font = new System.Drawing.Font("RSU", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(12, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 49);
            this.button1.TabIndex = 19;
            this.button1.Text = "< ย้อนกลับ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // gohome
            // 
            this.gohome.BackColor = System.Drawing.Color.Navy;
            this.gohome.Font = new System.Drawing.Font("RSU", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gohome.ForeColor = System.Drawing.SystemColors.Window;
            this.gohome.Location = new System.Drawing.Point(758, 562);
            this.gohome.Name = "gohome";
            this.gohome.Size = new System.Drawing.Size(121, 49);
            this.gohome.TabIndex = 18;
            this.gohome.Text = "ถัดไป >";
            this.gohome.UseVisualStyleBackColor = false;
            this.gohome.Click += new System.EventHandler(this.gohome_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(891, 623);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gohome);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NMbabynum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CBfm2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CBfm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NMbaby62);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NMbaby61);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBbaby);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBstatus);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "ครอบครัว";
            ((System.ComponentModel.ISupportInitialize)(this.NMbaby61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMbaby62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMbabynum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBstatus;
        private System.Windows.Forms.ComboBox CBbaby;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NMbaby61;
        private System.Windows.Forms.NumericUpDown NMbaby62;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBfm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBfm2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NMbabynum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button gohome;
    }
}