using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;

namespace emlak
{
    public partial class Giris : Form
    {

        public Giris()
        {
            InitializeComponent();
        }

        private void giris_button_Click(object sender, EventArgs e)
        {
            string dosya_yolu = @"C:\Users\90546\OneDrive\Masaüstü\Emlak_Otomasyonu-main\kullanicilar.txt";
            if (!File.Exists(dosya_yolu))
            {
                MessageBox.Show("Kullanıcı Dosyası Bulunmuyor. Öncelikle Kullanıcı Ekleyiniz");
            }
            else
            {
                List<Kullanici> kullanicilar = D_Islemleri.DosyaOkuma(dosya_yolu);
                string kullaniciAdi = Kullanici_Adi.Text;
                string sifre = Sifre.Text;
                bool girisBasarili = false;

                foreach (Kullanici kullanici in kullanicilar)
                {
                    if (kullanici.Kullanici_Adi.Equals(kullaniciAdi) && kullanici.Sifre.Equals(sifre))
                    {
                        girisBasarili = true;
                        break;
                    }
                }

                if (girisBasarili)
                {
                    MessageBox.Show("Giriş Başarılı");
                    İşlemler İşlemler = new İşlemler();
                    İşlemler.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre Girdiniz");
                }
            }
        }

        private void yeni_kayit_Click(object sender, EventArgs e)
        {
            string dosya_yolu = @"C:\Users\90546\OneDrive\Masaüstü\Emlak_Otomasyonu-main\kullanicilar.txt";

            // Dosyanın varlığını kontrol et
            if (!File.Exists(dosya_yolu))
            {
                MessageBox.Show("Kullanıcı Dosyası Bulunmuyor. Öncelikle Kullanıcı Ekleyiniz");
                return;
            }

            // Kullanıcı adı ve şifrenin boş olup olmadığını kontrol et
            string kullaniciAdi = Kullanici_Adi.Text;
            string sifre = Sifre.Text;

            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre alanları boş olamaz.");
                return;
            }

            // Kullanıcı listesini oku
            List<Kullanici> kullanicilar = D_Islemleri.DosyaOkuma(dosya_yolu);

            // Aynı kullanıcı adının var olup olmadığını kontrol et
            foreach (Kullanici kullanici in kullanicilar)
            {
                if (kullanici.Kullanici_Adi.Equals(kullaniciAdi, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Bu kullanıcı adı zaten mevcut. Lütfen başka bir kullanıcı adı seçin.");
                    return;
                }
            }

            // Yeni kullanıcıyı listeye ekle
            kullanicilar.Add(new Kullanici(kullaniciAdi, sifre));

            // Güncellenmiş listeyi dosyaya yaz
            D_Islemleri.DosyaYazma(dosya_yolu, kullanicilar);

            MessageBox.Show("Yeni kullanıcı başarıyla kaydedildi.");
        }

  
    }
}

