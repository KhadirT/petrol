using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Petrol_Otomasyon_Sistemi
{
    public partial class PompaciForm : Form
    {
        // Veritabanı bağlantı dizesi
        private string connectionString = "Server=.;Database=PetrolOtomasyon;Integrated Security=True;";

        public PompaciForm()
        {
            InitializeComponent();
        }

        // Yakıt talep et butonuna tıklanıldığında çalışacak metod
        private void btnTalepOlustur_Click(object sender, EventArgs e)
        {
            // Plaka numarası, ödeme türü ve talep miktarı alınır
            string plaka = txtPlaka.Text.Trim();
            string odemeTuru = cmbOdemeTuru.SelectedItem?.ToString();
            string talepMiktariStr = txtLitre.Text.Trim();  // Talep miktarını txtLitre'den alıyoruz

            // Hata kontrolü: Eğer plaka, ödeme türü veya talep miktarı boşsa, kullanıcıyı uyar
            if (string.IsNullOrEmpty(plaka) || string.IsNullOrEmpty(odemeTuru) || string.IsNullOrEmpty(talepMiktariStr))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Talep miktarını sayısal bir değere dönüştür
            decimal talepMiktari;
            if (!decimal.TryParse(talepMiktariStr, out talepMiktari))
            {
                MessageBox.Show("Geçerli bir talep miktarı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Veritabanına bu bilgileri ekle veya işlemi başlat
            try
            {
                // Veritabanına bağlantı açılıyor
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Talep işlemi için SQL komutunu yazıyoruz
                    string query = "INSERT INTO YakitTalepleri (Plaka, OdemeTuru, TalepTarihi, TalepMiktari) VALUES (@Plaka, @OdemeTuru, @TalepTarihi, @TalepMiktari)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Parametreler ekleniyor
                        cmd.Parameters.AddWithValue("@Plaka", plaka);
                        cmd.Parameters.AddWithValue("@OdemeTuru", odemeTuru);
                        cmd.Parameters.AddWithValue("@TalepTarihi", DateTime.Now);
                        cmd.Parameters.AddWithValue("@TalepMiktari", talepMiktari);  // Talep miktarını ekliyoruz

                        // Sorgu çalıştırılıyor
                        cmd.ExecuteNonQuery();
                    }
                }

                // Başarı mesajı
                MessageBox.Show("Yakıt talebi başarıyla oluşturulmuştur.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Formu temizle
                txtPlaka.Clear();
                cmbOdemeTuru.SelectedIndex = -1;
                txtLitre.Clear();  // Talep miktarını da temizliyoruz
            }
            catch (Exception ex)
            {
                // Hata mesajı
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Bu metot, form yüklendiğinde çalışan bir işlevsel kod olabilir.
        private void PompaciForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılacak işlemler
            // Örneğin, ödeme türünü veya diğer verileri doldurmak gibi işlemler yapılabilir.
        }

        // Litre TextBox'ı için TextChanged olayı
        private void txtLitre_TextChanged(object sender, EventArgs e)
        {
            // Kullanıcı litre miktarını her değiştirdiğinde, metin kutusundaki değeri kontrol et
            string talepMiktariStr = txtLitre.Text.Trim();

            // Eğer miktar sayısal ise ve boş değilse, bu değeri TalepMiktarı olarak al
            // Ancak burada herhangi bir hata mesajı vermeye gerek yok, çünkü zaten buton tıklama olayında bu kontrol yapılacak
        }
    }
}
