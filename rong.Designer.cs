namespace TAX_DEWS
{
    partial class rong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rong));
            this.gohome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gohome
            // 
            this.gohome.BackColor = System.Drawing.Color.DarkRed;
            this.gohome.Font = new System.Drawing.Font("RSU", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gohome.ForeColor = System.Drawing.SystemColors.Window;
            this.gohome.Location = new System.Drawing.Point(12, 12);
            this.gohome.Name = "gohome";
            this.gohome.Size = new System.Drawing.Size(121, 49);
            this.gohome.TabIndex = 17;
            this.gohome.Text = "< ย้อนกลับ";
            this.gohome.UseVisualStyleBackColor = false;
            this.gohome.Click += new System.EventHandler(this.gohome_Click);
            // 
            // rong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.gohome);
            this.Name = "rong";
            this.Text = "เมืองรอง";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gohome;
    }
}