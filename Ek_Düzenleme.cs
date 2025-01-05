using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emlak
{
    public partial class Ek_Düzenleme : Form
    {
        public Ek_Düzenleme()
        {
            InitializeComponent();
        }

        public decimal EmlakNumarasi = 111111111;

        public Ek_Düzenleme(string il, string ilce, int OdaSayisi, int KatNumarasi, decimal Alan, string Tip, string turu,
            int yasi, decimal Fiyat = 800, decimal EmlakNumarasi = 111111111)
        {
            InitializeComponent();
            Oda_Sayisi.Text = OdaSayisi.ToString();
            Kat_Numarasi.Text = KatNumarasi.ToString();
            IL.Text = il.ToString();
            ILCE.Text = ilce.ToString();
            tAlan.Text = Alan.ToString();
            Ev_Turu.Text = Tip.ToString();
            if (turu.Equals("satilik"))
            {
                Satilik.Checked = true;
            }
            tFiyat.Text = Fiyat.ToString();
            Yapim.Text = yasi.ToString();
            FileStream fs = new FileStream(@"C:\Users\90546\OneDrive\Masaüstü\Emlak_Otomasyonu-main\Room.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string yazi = sr.ReadLine();
            int i = 0;
            while (yazi != null)
            {
                string[] dosya = yazi.Split('|');

                yazi = sr.ReadLine();
                i++;
            }
            this.EmlakNumarasi = EmlakNumarasi;
            sr.Close();
            fs.Close();
        }

        public Ek_Düzenleme(string il, string ilce, int OdaSayisi, int KatNumarasi, decimal Alan, string Tip, string turu,
        int yasi, decimal Kira = 800, decimal Depozito = 100, decimal EmlakNumarasi = 111111111)
        {
            InitializeComponent();
            Oda_Sayisi.Text = OdaSayisi.ToString();
            Kat_Numarasi.Text = KatNumarasi.ToString();
            IL.Text = il.ToString();
            ILCE.Text = ilce.ToString();
            tAlan.Text = Alan.ToString();
            Ev_Turu.Text = Tip.ToString();
            Yapim.Text = yasi.ToString();
        }
        private void Kaydet_Click(object sender, EventArgs e)
        {

            int i = 0;
            foreach (Ev ev in Ev.evler)
            {
                Console.WriteLine(ev.EmlakNumarasi);
                Console.WriteLine(ev.OdaSayisi);

            }
            foreach (Ev ev in Ev.evler)
            {
                if (ev.EmlakNumarasi == EmlakNumarasi)
                {
                    Ev.evler.RemoveAt(i);
                    break;
                }
                i++;
            }

            if (Satilik.Checked)
            {

                SatilikEv satilikEv = new SatilikEv(
                    IL.Text, ILCE.Text, int.Parse(Kat_Numarasi.Text), int.Parse(tAlan.Text), int.Parse(Oda_Sayisi.Text), Ev_Turu.Text, "satilik",
                    int.Parse(Yapim.Text), int.Parse(tFiyat.Text));
                Ev.evler.Add(satilikEv);
                MessageBox.Show("Satılık Ev Kayıt Edildi");
                string dosya_yolu = @"C:\Users\90546\OneDrive\Masaüstü\Emlak_Otomasyonu-main\satilik.txt";
                D_Islemleri.DosyaSatilikYazmak(dosya_yolu, "satilik");
            }

            else
            {

                KiralikEv kiralikEv = new KiralikEv(IL.Text, ILCE.Text, int.Parse(Kat_Numarasi.Text), int.Parse(tAlan.Text), int.Parse(Oda_Sayisi.Text),
                    Ev_Turu.Text, "kiralik", int.Parse(Yapim.Text), decimal.Parse(Kira.Text), decimal.Parse(tDepozito.Text));
                Ev.evler.Add(kiralikEv);
                MessageBox.Show("Kiralık Ev Kayıt Edildi");
                string dosya_yolu = @"C:\Users\90546\OneDrive\Masaüstü\Emlak_Otomasyonu-main\kiralik.txt";

                D_Islemleri.DosyaKiralikEvYazmak(dosya_yolu, "kiralik");
            }
            sorgu sorgu = new sorgu();
            sorgu.Show();
            this.Hide();
            sorgu.FormClosed += (s, args) => this.Close();

        }

        private void IL_SelectedValueChanged(object sender, EventArgs e)
        {
            Ev.sehir = (IL.SelectedIndex) + 1;
            string dosya_yolu = @"C:\Users\90546\OneDrive\Masaüstü\Emlak_Otomasyonu-main\semtler.txt";
            if (!File.Exists(dosya_yolu))
            {
                MessageBox.Show("Semt Dosyası Bulunmuyor");
                return;
            }
            else
            {

                List<string> semtler = D_Islemleri.DosyaOkumaSemt(dosya_yolu, IL.Text);
                ILCE.Items.Clear();
                foreach (string semt in semtler)
                {
                    ILCE.Items.Add(semt);
                }
                ILCE.Enabled = true;
            }
        }
        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void Satilik_CheckedChanged(object sender, EventArgs e)
        {
            kontrol.SatilikRadioButton(this);


        }
        private void Kiralik_CheckedChanged(object sender, EventArgs e)
        {
            kontrol.KiralikRadioButton(this);

        }

        private void Geri_Click(object sender, EventArgs e)
        {
            
            this.Hide();

        }
    }
}
