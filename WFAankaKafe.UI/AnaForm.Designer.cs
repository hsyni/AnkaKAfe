
namespace WFAankaKafe.UI
{
    partial class AnaForm
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
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiUrunler = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGecmisUrunler = new System.Windows.Forms.ToolStripMenuItem();
            this.lvwMasalar = new System.Windows.Forms.ListView();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUrunler,
            this.tsmiGecmisUrunler});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(615, 24);
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "menuStrip1";
            this.MenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // tsmiUrunler
            // 
            this.tsmiUrunler.Name = "tsmiUrunler";
            this.tsmiUrunler.Size = new System.Drawing.Size(58, 20);
            this.tsmiUrunler.Text = "Ürünler";
            // 
            // tsmiGecmisUrunler
            // 
            this.tsmiGecmisUrunler.Name = "tsmiGecmisUrunler";
            this.tsmiGecmisUrunler.Size = new System.Drawing.Size(108, 20);
            this.tsmiGecmisUrunler.Text = "Gecmis Siparişler";
            // 
            // lvwMasalar
            // 
            this.lvwMasalar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwMasalar.HideSelection = false;
            this.lvwMasalar.Location = new System.Drawing.Point(12, 36);
            this.lvwMasalar.Name = "lvwMasalar";
            this.lvwMasalar.Size = new System.Drawing.Size(586, 384);
            this.lvwMasalar.TabIndex = 1;
            this.lvwMasalar.UseCompatibleStateImageBehavior = false;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 432);
            this.Controls.Add(this.lvwMasalar);
            this.Controls.Add(this.MenuStrip1);
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "AnaForm";
            this.Text = "AnkaKafe-Sipariş Takip Otomasyonu";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvwMasalar;
        private System.Windows.Forms.ToolStripMenuItem tsmiUrunler;
        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiGecmisUrunler;
    }
}