
namespace WFAankaKafe.UI
{
    partial class SiparisForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.cboUrun = new System.Windows.Forms.ComboBox();
            this.cboMasa = new System.Windows.Forms.ComboBox();
            this.btnTasi = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnOde = new System.Windows.Forms.Button();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSiparisDetaylar = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.lblOdemeTutar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adet";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(292, 48);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(81, 25);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(156, 50);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(120, 23);
            this.nudAdet.TabIndex = 3;
            // 
            // cboUrun
            // 
            this.cboUrun.FormattingEnabled = true;
            this.cboUrun.Location = new System.Drawing.Point(12, 50);
            this.cboUrun.Name = "cboUrun";
            this.cboUrun.Size = new System.Drawing.Size(121, 23);
            this.cboUrun.TabIndex = 4;
            // 
            // cboMasa
            // 
            this.cboMasa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMasa.FormattingEnabled = true;
            this.cboMasa.Location = new System.Drawing.Point(415, 38);
            this.cboMasa.Name = "cboMasa";
            this.cboMasa.Size = new System.Drawing.Size(121, 23);
            this.cboMasa.TabIndex = 5;
            // 
            // btnTasi
            // 
            this.btnTasi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTasi.Location = new System.Drawing.Point(542, 37);
            this.btnTasi.Name = "btnTasi";
            this.btnTasi.Size = new System.Drawing.Size(81, 24);
            this.btnTasi.TabIndex = 6;
            this.btnTasi.Text = "Taşı";
            this.btnTasi.UseVisualStyleBackColor = true;
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIptal.BackColor = System.Drawing.Color.DarkRed;
            this.btnIptal.ForeColor = System.Drawing.SystemColors.Info;
            this.btnIptal.Location = new System.Drawing.Point(415, 306);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(100, 45);
            this.btnIptal.TabIndex = 7;
            this.btnIptal.Text = "Sipariş İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            // 
            // btnOde
            // 
            this.btnOde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOde.BackColor = System.Drawing.Color.SeaGreen;
            this.btnOde.ForeColor = System.Drawing.Color.White;
            this.btnOde.Location = new System.Drawing.Point(526, 306);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(97, 45);
            this.btnOde.TabIndex = 8;
            this.btnOde.Text = "Ödeme Al";
            this.btnOde.UseVisualStyleBackColor = false;
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnaSayfa.BackColor = System.Drawing.Color.Gold;
            this.btnAnaSayfa.Location = new System.Drawing.Point(415, 369);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(206, 48);
            this.btnAnaSayfa.TabIndex = 9;
            this.btnAnaSayfa.Text = "Ana Sayfaya Dön";
            this.btnAnaSayfa.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(455, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ödeme Tutarı : ";
            // 
            // dgvSiparisDetaylar
            // 
            this.dgvSiparisDetaylar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSiparisDetaylar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisDetaylar.Location = new System.Drawing.Point(12, 81);
            this.dgvSiparisDetaylar.Name = "dgvSiparisDetaylar";
            this.dgvSiparisDetaylar.RowTemplate.Height = 25;
            this.dgvSiparisDetaylar.Size = new System.Drawing.Size(397, 336);
            this.dgvSiparisDetaylar.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Masa No";
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMasaNo.BackColor = System.Drawing.Color.OrangeRed;
            this.lblMasaNo.Font = new System.Drawing.Font("Segoe UI", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMasaNo.ForeColor = System.Drawing.Color.White;
            this.lblMasaNo.Location = new System.Drawing.Point(445, 95);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(161, 129);
            this.lblMasaNo.TabIndex = 13;
            this.lblMasaNo.Text = "01";
            this.lblMasaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOdemeTutar
            // 
            this.lblOdemeTutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOdemeTutar.AutoSize = true;
            this.lblOdemeTutar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOdemeTutar.Location = new System.Drawing.Point(542, 260);
            this.lblOdemeTutar.Name = "lblOdemeTutar";
            this.lblOdemeTutar.Size = new System.Drawing.Size(38, 15);
            this.lblOdemeTutar.TabIndex = 14;
            this.lblOdemeTutar.Text = "7.55₺";
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 446);
            this.Controls.Add(this.lblOdemeTutar);
            this.Controls.Add(this.lblMasaNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvSiparisDetaylar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnTasi);
            this.Controls.Add(this.cboMasa);
            this.Controls.Add(this.cboUrun);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SiparisForm";
            this.Text = "SiparisForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.ComboBox cboUrun;
        private System.Windows.Forms.ComboBox cboMasa;
        private System.Windows.Forms.Button btnTasi;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnOde;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvSiparisDetaylar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMasaNo;
        private System.Windows.Forms.Label lblOdemeTutar;
    }
}