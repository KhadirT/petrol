namespace Petrol_Otomasyon_Sistemi
{
    partial class PompaciForm
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
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.cmbOdemeTuru = new System.Windows.Forms.ComboBox();
            this.btnTalepOlustur = new System.Windows.Forms.Button();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.lblOdemeTuru = new System.Windows.Forms.Label();
            this.cmbPetrolTuru = new System.Windows.Forms.ComboBox();
            this.lblPetrolTuru = new System.Windows.Forms.Label();
            this.txtLitre = new System.Windows.Forms.TextBox();
            this.lblLitre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(150, 50);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(200, 22);
            this.txtPlaka.TabIndex = 0;
            // 
            // cmbOdemeTuru
            // 
            this.cmbOdemeTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdemeTuru.FormattingEnabled = true;
            this.cmbOdemeTuru.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı",
            "Diğer"});
            this.cmbOdemeTuru.Location = new System.Drawing.Point(150, 100);
            this.cmbOdemeTuru.Name = "cmbOdemeTuru";
            this.cmbOdemeTuru.Size = new System.Drawing.Size(200, 24);
            this.cmbOdemeTuru.TabIndex = 1;
            // 
            // btnTalepOlustur
            // 
            this.btnTalepOlustur.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTalepOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTalepOlustur.Location = new System.Drawing.Point(150, 250);
            this.btnTalepOlustur.Name = "btnTalepOlustur";
            this.btnTalepOlustur.Size = new System.Drawing.Size(200, 40);
            this.btnTalepOlustur.TabIndex = 2;
            this.btnTalepOlustur.Text = "Yakıt Talep Et";
            this.btnTalepOlustur.UseVisualStyleBackColor = false;
            this.btnTalepOlustur.Click += new System.EventHandler(this.btnTalepOlustur_Click);
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPlaka.Location = new System.Drawing.Point(12, 52);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(132, 20);
            this.lblPlaka.TabIndex = 3;
            this.lblPlaka.Text = "Plaka Numarası:";
            // 
            // lblOdemeTuru
            // 
            this.lblOdemeTuru.AutoSize = true;
            this.lblOdemeTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOdemeTuru.Location = new System.Drawing.Point(37, 100);
            this.lblOdemeTuru.Name = "lblOdemeTuru";
            this.lblOdemeTuru.Size = new System.Drawing.Size(107, 20);
            this.lblOdemeTuru.TabIndex = 4;
            this.lblOdemeTuru.Text = "Ödeme Türü:";
            // 
            // cmbPetrolTuru
            // 
            this.cmbPetrolTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPetrolTuru.FormattingEnabled = true;
            this.cmbPetrolTuru.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "LPG"});
            this.cmbPetrolTuru.Location = new System.Drawing.Point(150, 150);
            this.cmbPetrolTuru.Name = "cmbPetrolTuru";
            this.cmbPetrolTuru.Size = new System.Drawing.Size(200, 24);
            this.cmbPetrolTuru.TabIndex = 5;
            // 
            // lblPetrolTuru
            // 
            this.lblPetrolTuru.AutoSize = true;
            this.lblPetrolTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPetrolTuru.Location = new System.Drawing.Point(37, 150);
            this.lblPetrolTuru.Name = "lblPetrolTuru";
            this.lblPetrolTuru.Size = new System.Drawing.Size(97, 20);
            this.lblPetrolTuru.TabIndex = 6;
            this.lblPetrolTuru.Text = "Petrol Türü:";
            // 
            // txtLitre
            // 
            this.txtLitre.Location = new System.Drawing.Point(150, 200);
            this.txtLitre.Name = "txtLitre";
            this.txtLitre.Size = new System.Drawing.Size(200, 22);
            this.txtLitre.TabIndex = 7;
            this.txtLitre.TextChanged += new System.EventHandler(this.txtLitre_TextChanged);
            // 
            // lblLitre
            // 
            this.lblLitre.AutoSize = true;
            this.lblLitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLitre.Location = new System.Drawing.Point(37, 200);
            this.lblLitre.Name = "lblLitre";
            this.lblLitre.Size = new System.Drawing.Size(105, 20);
            this.lblLitre.TabIndex = 8;
            this.lblLitre.Text = "Yakıt Miktarı:";
            // 
            // PompaciForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lblLitre);
            this.Controls.Add(this.txtLitre);
            this.Controls.Add(this.lblPetrolTuru);
            this.Controls.Add(this.cmbPetrolTuru);
            this.Controls.Add(this.lblOdemeTuru);
            this.Controls.Add(this.lblPlaka);
            this.Controls.Add(this.btnTalepOlustur);
            this.Controls.Add(this.cmbOdemeTuru);
            this.Controls.Add(this.txtPlaka);
            this.Name = "PompaciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pompacı Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.ComboBox cmbOdemeTuru;
        private System.Windows.Forms.Button btnTalepOlustur;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label lblOdemeTuru;
        private System.Windows.Forms.ComboBox cmbPetrolTuru;
        private System.Windows.Forms.Label lblPetrolTuru;
        private System.Windows.Forms.TextBox txtLitre;
        private System.Windows.Forms.Label lblLitre;
    }
}
