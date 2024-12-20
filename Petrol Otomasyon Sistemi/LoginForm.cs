using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Petrol_Otomasyon_Sistemi
{
    public partial class LoginForm : Form
    {
        // Veritabanı bağlantısı için bağlantı stringi
        private string connectionString = "Server=.;Database=PetrolOtomasyon;Integrated Security=True;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı, şifre ve pozisyonun boş olup olmadığını kontrol et
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text) || cmbPozisyon.SelectedIndex == -1)
            {
                lblHataMesaji.Text = "Lütfen tüm alanları doldurun.";
                return;
            }

            // Kullanıcı adı ve şifreyi al
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            string pozisyon = cmbPozisyon.SelectedItem.ToString();

            // Veritabanına bağlanıp kullanıcıyı doğrula
            if (DoLogin(kullaniciAdi, sifre, pozisyon))
            {
                // Başarılı giriş sonrası yönlendirme
                if (pozisyon == "Pompacı")
                {
                    // Pompacı ekranına yönlendirme
                    PompaciForm pompaciForm = new PompaciForm();
                    pompaciForm.Show();
                    this.Hide(); // Login formunu gizle
                }
                else if (pozisyon == "Genel Müdür")
                {
                    // Genel Müdür ekranına yönlendirme
                    GenelMudurlukForm genelMudurlukForm = new GenelMudurlukForm();
                    genelMudurlukForm.Show();
                    this.Hide(); // Login formunu gizle
                }
                else if (pozisyon == "Kasa")
                {
                    // Kasa ekranına yönlendirme
                    KasaForm kasaForm = new KasaForm();
                    kasaForm.Show();
                    this.Hide(); // Login formunu gizle
                }
            }
            else
            {
                // Hatalı giriş
                lblHataMesaji.Text = "Kullanıcı adı, şifre veya pozisyon hatalı!";
            }
        }

        // Kullanıcı doğrulama işlemi
        private bool DoLogin(string kullaniciAdi, string sifre, string pozisyon)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Kullanıcı adı, şifre ve pozisyona göre sorgu
                    string query = "SELECT COUNT(*) FROM Kullanicilar WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre AND Pozisyon = @Pozisyon";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                    command.Parameters.AddWithValue("@Sifre", sifre);
                    command.Parameters.AddWithValue("@Pozisyon", pozisyon);

                    // Sonuç döndür
                    int result = (int)command.ExecuteScalar();
                    return result > 0; // 0'dan büyükse kullanıcı doğru giriş yapmıştır
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                return false;
            }
        }
    }
}
