namespace Petrol_Otomasyon_Sistemi
{
    partial class KasaForm
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
            this.lblPlaka = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.lblYakitMiktari = new System.Windows.Forms.Label();
            this.txtYakitMiktari = new System.Windows.Forms.TextBox();
            this.lblOdemeTuru = new System.Windows.Forms.Label();
            this.cmbOdemeTuru = new System.Windows.Forms.ComboBox();
            this.lblOdemeMiktari = new System.Windows.Forms.Label();
            this.txtOdemeMiktari = new System.Windows.Forms.TextBox();
            this.btnOdemeOnayla = new System.Windows.Forms.Button();
            this.dgvKasaIslemleri = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnFişYazdir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKasaIslemleri)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(30, 30);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(46, 17);
            this.lblPlaka.TabIndex = 0;
            this.lblPlaka.Text = "Plaka:";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(120, 30);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(200, 22);
            this.txtPlaka.TabIndex = 1;
            // 
            // lblYakitMiktari
            // 
            this.lblYakitMiktari.AutoSize = true;
            this.lblYakitMiktari.Location = new System.Drawing.Point(30, 70);
            this.lblYakitMiktari.Name = "lblYakitMiktari";
            this.lblYakitMiktari.Size = new System.Drawing.Size(91, 17);
            this.lblYakitMiktari.TabIndex = 2;
            this.lblYakitMiktari.Text = "Yakıt Miktarı:";
            // 
            // txtYakitMiktari
            // 
            this.txtYakitMiktari.Location = new System.Drawing.Point(120, 70);
            this.txtYakitMiktari.Name = "txtYakitMiktari";
            this.txtYakitMiktari.Size = new System.Drawing.Size(200, 22);
            this.txtYakitMiktari.TabIndex = 3;
            // 
            // lblOdemeTuru
            // 
            this.lblOdemeTuru.AutoSize = true;
            this.lblOdemeTuru.Location = new System.Drawing.Point(30, 110);
            this.lblOdemeTuru.Name = "lblOdemeTuru";
            this.lblOdemeTuru.Size = new System.Drawing.Size(90, 17);
            this.lblOdemeTuru.TabIndex = 4;
            this.lblOdemeTuru.Text = "Ödeme Türü:";
            // 
            // cmbOdemeTuru
            // 
            this.cmbOdemeTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdemeTuru.FormattingEnabled = true;
            this.cmbOdemeTuru.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı"});
            this.cmbOdemeTuru.Location = new System.Drawing.Point(120, 110);
            this.cmbOdemeTuru.Name = "cmbOdemeTuru";
            this.cmbOdemeTuru.Size = new System.Drawing.Size(200, 24);
            this.cmbOdemeTuru.TabIndex = 5;
            // 
            // lblOdemeMiktari
            // 
            this.lblOdemeMiktari.AutoSize = true;
            this.lblOdemeMiktari.Location = new System.Drawing.Point(30, 150);
            this.lblOdemeMiktari.Name = "lblOdemeMiktari";
            this.lblOdemeMiktari.Size = new System.Drawing.Size(103, 17);
            this.lblOdemeMiktari.TabIndex = 6;
            this.lblOdemeMiktari.Text = "Ödeme Miktarı:";
            // 
            // txtOdemeMiktari
            // 
            this.txtOdemeMiktari.Location = new System.Drawing.Point(120, 150);
            this.txtOdemeMiktari.Name = "txtOdemeMiktari";
            this.txtOdemeMiktari.Size = new System.Drawing.Size(200, 22);
            this.txtOdemeMiktari.TabIndex = 7;
            // 
            // btnOdemeOnayla
            // 
            this.btnOdemeOnayla.Location = new System.Drawing.Point(120, 190);
            this.btnOdemeOnayla.Name = "btnOdemeOnayla";
            this.btnOdemeOnayla.Size = new System.Drawing.Size(200, 30);
            this.btnOdemeOnayla.TabIndex = 8;
            this.btnOdemeOnayla.Text = "Ödemeyi Onayla";
            this.btnOdemeOnayla.UseVisualStyleBackColor = true;
            this.btnOdemeOnayla.Click += new System.EventHandler(this.btnOdemeOnayla_Click);
            // 
            // dgvKasaIslemleri
            // 
            this.dgvKasaIslemleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKasaIslemleri.Location = new System.Drawing.Point(30, 240);
            this.dgvKasaIslemleri.Name = "dgvKasaIslemleri";
            this.dgvKasaIslemleri.RowHeadersWidth = 51;
            this.dgvKasaIslemleri.RowTemplate.Height = 24;
            this.dgvKasaIslemleri.Size = new System.Drawing.Size(740, 200);
            this.dgvKasaIslemleri.TabIndex = 9;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(420, 190);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(150, 30);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnFişYazdir
            // 
            this.btnFişYazdir.Location = new System.Drawing.Point(580, 190);
            this.btnFişYazdir.Name = "btnFişYazdir";
            this.btnFişYazdir.Size = new System.Drawing.Size(150, 30);
            this.btnFişYazdir.TabIndex = 11;
            this.btnFişYazdir.Text = "Fiş Yazdır";
            this.btnFişYazdir.UseVisualStyleBackColor = true;
//            this.btnFişYazdir.Click += new System.EventHandler(this.btnFişYazdir_Click);
            // 
            // KasaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.btnFişYazdir);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dgvKasaIslemleri);
            this.Controls.Add(this.btnOdemeOnayla);
            this.Controls.Add(this.txtOdemeMiktari);
            this.Controls.Add(this.lblOdemeMiktari);
            this.Controls.Add(this.cmbOdemeTuru);
            this.Controls.Add(this.lblOdemeTuru);
            this.Controls.Add(this.txtYakitMiktari);
            this.Controls.Add(this.lblYakitMiktari);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.lblPlaka);
            this.Name = "KasaForm";
            this.Text = "Kasa İşlemleri";
            this.Load += new System.EventHandler(this.KasaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKasaIslemleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label lblYakitMiktari;
        private System.Windows.Forms.TextBox txtYakitMiktari;
        private System.Windows.Forms.Label lblOdemeTuru;
        private System.Windows.Forms.ComboBox cmbOdemeTuru;
        private System.Windows.Forms.Label lblOdemeMiktari;
        private System.Windows.Forms.TextBox txtOdemeMiktari;
        private System.Windows.Forms.Button btnOdemeOnayla;
        private System.Windows.Forms.DataGridView dgvKasaIslemleri;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnFişYazdir;
    }
}
