using System;
using System.Windows.Forms;

namespace Petrol_Otomasyon_Sistemi
{
    public partial class KasaForm : Form
    {
        // Birim fiyat sabiti
        private const decimal BirimFiyat = 25.50m; // Yakıtın litre başına fiyatı

        public KasaForm()
        {
            InitializeComponent();
        }

        private void KasaForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılması gereken işlemler buraya yazılabilir.
        }

        private void txtYakitMiktari_TextChanged(object sender, EventArgs e)
        {
            // Yakıt miktarı değiştiğinde ödeme miktarını otomatik hesapla
            try
            {
                if (decimal.TryParse(txtYakitMiktari.Text, out decimal yakitMiktari))
                {
                    decimal odemeMiktari = yakitMiktari * BirimFiyat;
                    txtOdemeMiktari.Text = odemeMiktari.ToString("F2"); // 2 ondalık basamaklı format
                }
                else
                {
                    txtOdemeMiktari.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnOdemeOnayla_Click(object sender, EventArgs e)
        {
            // Ödeme onaylama işlemi
            string plaka = txtPlaka.Text;
            string odemeTuru = cmbOdemeTuru.SelectedItem?.ToString();
            string yakitMiktari = txtYakitMiktari.Text;
            string odemeMiktari = txtOdemeMiktari.Text;

            if (string.IsNullOrWhiteSpace(plaka) || string.IsNullOrWhiteSpace(odemeTuru) || string.IsNullOrWhiteSpace(yakitMiktari))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kasa işlemlerine ekleme (örnek DataGridView kullanımı)
            dgvKasaIslemleri.Rows.Add(plaka, yakitMiktari, odemeTuru, odemeMiktari);

            MessageBox.Show("Ödeme başarıyla onaylandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Alanları temizleme
            txtPlaka.Clear();
            txtYakitMiktari.Clear();
            txtOdemeMiktari.Clear();
            cmbOdemeTuru.SelectedIndex = -1;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Güncelleme işlemleri buraya yazılabilir.
            MessageBox.Show("Güncelleme işlemi henüz eklenmedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFişyazdir_Click(object sender, EventArgs e)
        {
            // Fiş yazdırma işlemleri buraya eklenebilir
            MessageBox.Show("Fiş yazdırma işlemi gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
