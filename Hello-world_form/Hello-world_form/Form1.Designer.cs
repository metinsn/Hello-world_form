namespace Hello_world_form
{
    partial class ilkForm
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
            this.MesajGosterBtn = new System.Windows.Forms.Button();
            this.AdSoyadlbl = new System.Windows.Forms.Label();
            this.SifreLbl = new System.Windows.Forms.Label();
            this.AdSoyadTxtBox = new System.Windows.Forms.TextBox();
            this.SifreTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MesajGosterBtn
            // 
            this.MesajGosterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MesajGosterBtn.Location = new System.Drawing.Point(167, 28);
            this.MesajGosterBtn.Name = "MesajGosterBtn";
            this.MesajGosterBtn.Size = new System.Drawing.Size(110, 33);
            this.MesajGosterBtn.TabIndex = 0;
            this.MesajGosterBtn.Text = "Mesaj Göster";
            this.MesajGosterBtn.UseVisualStyleBackColor = false;
            this.MesajGosterBtn.Click += new System.EventHandler(this.BtnMesage1_Click);
            // 
            // AdSoyadlbl
            // 
            this.AdSoyadlbl.AutoSize = true;
            this.AdSoyadlbl.Location = new System.Drawing.Point(30, 9);
            this.AdSoyadlbl.Name = "AdSoyadlbl";
            this.AdSoyadlbl.Size = new System.Drawing.Size(53, 13);
            this.AdSoyadlbl.TabIndex = 1;
            this.AdSoyadlbl.Text = "Ad Soyad";
            // 
            // SifreLbl
            // 
            this.SifreLbl.AutoSize = true;
            this.SifreLbl.Location = new System.Drawing.Point(30, 48);
            this.SifreLbl.Name = "SifreLbl";
            this.SifreLbl.Size = new System.Drawing.Size(28, 13);
            this.SifreLbl.TabIndex = 2;
            this.SifreLbl.Text = "Şifre";
            // 
            // AdSoyadTxtBox
            // 
            this.AdSoyadTxtBox.Location = new System.Drawing.Point(33, 25);
            this.AdSoyadTxtBox.Name = "AdSoyadTxtBox";
            this.AdSoyadTxtBox.Size = new System.Drawing.Size(120, 20);
            this.AdSoyadTxtBox.TabIndex = 3;
            // 
            // SifreTxtBox
            // 
            this.SifreTxtBox.Location = new System.Drawing.Point(33, 64);
            this.SifreTxtBox.Name = "SifreTxtBox";
            this.SifreTxtBox.Size = new System.Drawing.Size(120, 20);
            this.SifreTxtBox.TabIndex = 4;
            this.SifreTxtBox.UseSystemPasswordChar = true;
            this.SifreTxtBox.TextChanged += new System.EventHandler(this.SifreTxtBox_TextChanged);
            // 
            // ilkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(289, 92);
            this.Controls.Add(this.SifreTxtBox);
            this.Controls.Add(this.AdSoyadTxtBox);
            this.Controls.Add(this.SifreLbl);
            this.Controls.Add(this.AdSoyadlbl);
            this.Controls.Add(this.MesajGosterBtn);
            this.Name = "ilkForm";
            this.Text = "Merhaba Dünya";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MesajGosterBtn;
        private System.Windows.Forms.Label AdSoyadlbl;
        private System.Windows.Forms.Label SifreLbl;
        private System.Windows.Forms.TextBox AdSoyadTxtBox;
        private System.Windows.Forms.TextBox SifreTxtBox;
    }
}

