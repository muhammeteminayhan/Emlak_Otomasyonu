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
    public partial class sorgu : Form
    {
        public sorgu()
        {
            InitializeComponent();
        }

        private void cb_il_SelectedValueChanged(object sender, EventArgs e)
        {
            Ev.sehir = (cb_il.SelectedIndex) + 1;
            string dosya_yolu = @"C:\Users\90546\OneDrive\Masaüstü\Emlak_Otomasyonu-main\semtler.txt";
            if (!File.Exists(dosya_yolu))
            {
                MessageBox.Show("Semt Dosyası Bulunmuyor");
                return;
            }
            else
            {

                List<string> semtler = D_Islemleri.DosyaOkumaSemt(dosya_yolu, cb_il.Text);
                cb_ilce.Items.Clear();
                foreach (string semt in semtler)
                {
                    cb_ilce.Items.Add(semt);
                }
                cb_ilce.Enabled = true;
            }
        }
        bool kontrol = true;

        private void Sorgula_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            Ev.evler.Clear();
            string il = "";
            string ilce = "";
            if (cb_il.Text != "")
            {
                il = cb_il.Text;
            }
            else
            {
                MessageBox.Show("Lütfen ili giriniz");
                return;
            }
            if (cb_ilce.Text != "")
            {
                ilce = cb_ilce.Text;
            }
            else
            {
                MessageBox.Show("Lütfen ilce giriniz");
                return;
            }

            if (Satilik.Checked)
            {
                List<SatilikEv> evler = D_Islemleri.DosyaSatilikEvOkuma();
                foreach (SatilikEv ev in evler)
                {
                    if (ilce.Equals(ev.ilce) && il.Equals(ev.il))
                    {
                        dataGridView1.Rows.Add(ev.EmlakNumarasi, ev.il, ev.ilce, ev.KatNumarasi, ev.Alan, ev.OdaSayisi, ev.Tip, ev.turu, ev.Yasi, ev.Fiyat);
                    }
                }
            }
            else
            {
                List<KiralikEv> evler = D_Islemleri.DosyaKiralikEvOkuma();

                // Eğer depozito sütunu yoksa ekle
                if (!dataGridView1.Columns.Contains("Depozito"))
                {
                    dataGridView1.Columns.Add("Depozito", "Depozito");
                }

                foreach (KiralikEv ev in evler)
                {
                    if (ilce.Equals(ev.ilce) && il.Equals(ev.il))
                    {
                        dataGridView1.Rows.Add(ev.EmlakNumarasi, ev.il, ev.ilce, ev.KatNumarasi, ev.Alan, ev.OdaSayisi, ev.Tip, ev.turu, ev.Yasi, ev.Kira, ev.Depozito);
                    }

                }
            }
        }

        private void Ana_Menü_Click(object sender, EventArgs e)
        {
            İşlemler islemler = new İşlemler();
            islemler.Show();
            this.Hide();
            islemler.FormClosed += (s, args) => this.Close();
        }



        private void Duzenle_Click(object sender, EventArgs e)
        {

            string deger = dataGridView1.CurrentRow.Cells["EmlakNumarasi"].Value.ToString();
            string satKira = dataGridView1.CurrentRow.Cells["turu"].Value.ToString();
            Console.WriteLine(satKira);

            if (satKira.Equals("satilik"))
            {
                foreach (SatilikEv ev in Ev.evler)
                {
                    if (ev.EmlakNumarasi == decimal.Parse(deger))
                    {
                        Console.WriteLine("Emlak Numarası " + ev.EmlakNumarasi);
                        Console.WriteLine("İlce " + ev.ilce);

                        Ek_Düzenleme ek_Düzenleme = new Ek_Düzenleme(ev.il, ev.ilce, ev.OdaSayisi, ev.KatNumarasi, ev.Alan, ev.Tip, ev.turu,
                        ev.Yasi, ev.Fiyat, ev.EmlakNumarasi);

                        ek_Düzenleme.Visible = true;
                        return;
                    }
                }
            }
            else
            {
                foreach (KiralikEv ev in Ev.evler)
                {
                    if (ev.EmlakNumarasi == decimal.Parse(deger))
                    {
                        Console.WriteLine("Emlak Numarası " + ev.EmlakNumarasi);
                        Console.WriteLine("İlce " + ev.ilce);

                        Ek_Düzenleme ek_Duzenleme = new Ek_Düzenleme(ev.il, ev.ilce, ev.OdaSayisi, ev.KatNumarasi, ev.Alan, ev.Tip, ev.turu,
                        ev.Yasi, ev.Kira, ev.Depozito, ev.EmlakNumarasi);
                        ek_Duzenleme.Visible = true;
                        return;
                    }
                }
            }



        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            string Sat_Dosya_yolu = @"C:\Users\90546\OneDrive\Masaüstü\Emlak_Otomasyonu-main\satilik.txt";
            string Kira_Dosya_Yolu = @"C:\Users\90546\OneDrive\Masaüstü\Emlak_Otomasyonu-main\kiralik.txt";
            string deger = dataGridView1.CurrentRow.Cells["EmlakNumarasi"].Value.ToString();
            decimal emlakNumarasi = decimal.Parse(deger);

            // Seçilen evi EmlakNumarasi ile filtreleyerek listeden kaldır
            Ev silinecekEv = Ev.evler.FirstOrDefault(ev => ev.EmlakNumarasi == emlakNumarasi);
            if (silinecekEv != null)
            {
                Ev.evler.Remove(silinecekEv);

                if (silinecekEv.turu.Equals("satilik"))
                {
                   D_Islemleri.DosyadanSatirSil(Sat_Dosya_yolu, emlakNumarasi);
                }
                else
                {
                    D_Islemleri.DosyadanSatirSil(Kira_Dosya_Yolu, emlakNumarasi);
                }

                // DataGridView'i güncelle
                dataGridView1.DataSource = null; // Veri kaynağını temizle
                dataGridView1.DataSource = Ev.evler; // Güncel veri kaynağını ata
                MessageBox.Show("Silindi");
            }
            else
            {
                MessageBox.Show("Silinmek istenen ev bulunamadı.");
            }
        }
    }
}


