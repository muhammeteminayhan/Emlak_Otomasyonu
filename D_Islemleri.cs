using ClassLibrary;
using System.Text;
using System.Windows.Forms;

namespace emlak
{
    internal class D_Islemleri
    {

        public static void DosyaIdBelirleme()
        {
            FileStream fs = new FileStream(@"C:\Users\90546\OneDrive\Masaüstü\Emlak_Otomasyonu-main\satilik.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string yazi = sr.ReadLine();

            while (yazi != null)
            {
                yazi = sr.ReadLine();
                Console.WriteLine("+1 Satilik");
                Ev.id += 1;
            }
            sr.Close();
            fs.Close();


            fs = new FileStream(@"C:\Users\90546\OneDrive\Masaüstü\Emlak_Otomasyonu-main\kiralik.txt", FileMode.Open, FileAccess.Read);
            sr = new StreamReader(fs);
            yazi = sr.ReadLine();
            while (yazi != null)
            {
                yazi = sr.ReadLine();
                Console.WriteLine("+1 Kiralik");
                Ev.id += 1;
            }

            sr.Close();
            fs.Close();
        }
        public static List<Kullanici> DosyaOkuma(string dosya_yolu)
        {
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            List<Kullanici> kullanicilar = new List<Kullanici>();
            string yazi = sr.ReadLine();

            while (yazi != null)
            {
                string[] parca = yazi.Split('|');
                kullanicilar.Add(new Kullanici(parca[0], parca[1]));
                yazi = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            return kullanicilar;
        }
             

        public static void DosyaYazma(string dosya_yolu, List<Kullanici> kullanicilar)
        {
            FileStream fs = new FileStream(dosya_yolu, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            foreach (Kullanici kullanici in kullanicilar)
            {
                string yazi = $"{kullanici.Kullanici_Adi}|{kullanici.Sifre}";
                sw.WriteLine(yazi);
            }

            sw.Close();
            fs.Close();
        }
        public static List<string> DosyaOkumaSemt(string dosya_yolu, string il)
        {
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            List<string> semtler = new List<string>();
            string yazi = sr.ReadLine();
            while (yazi != null)
            {
                string[] parca = yazi.Split('|');
                if (il.Equals(parca[0]))
                {
                    semtler.Add(parca[1]);
                }
                yazi = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            return semtler;
        }
        public static void DosyaSatilikYazmak(string dosya_yolu, string durum)
        {
            if (!File.Exists(dosya_yolu))
            {
                File.Create(dosya_yolu).Close();
            }

            using (FileStream fs = new FileStream(dosya_yolu, FileMode.Create, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                foreach (SatilikEv ev in Ev.evler.OfType<SatilikEv>()) 
                {
                    if (ev.turu.Equals("satilik"))
                    {
                        sw.WriteLine(ev.EmlakNumarasi + "|" + ev.il + "|" + ev.ilce + "|" + ev.KatNumarasi + "|" + ev.Alan + "|" + ev.OdaSayisi + "|"
                            + ev.Tip + "|" + ev.turu + "|" +ev.Yasi + "|" + ev.Fiyat);
                    }
                }
            }
        }


        public static List<SatilikEv> DosyaSatilikEvOkuma()
        {
            List<SatilikEv> evler = new List<SatilikEv>();
            string dosya_yolu = @"C:\Users\90546\OneDrive\Masaüstü\Emlak_Otomasyonu-main\satilik.txt";

            if (!File.Exists(dosya_yolu))
            {
                Console.WriteLine("Satılık Dosya Bulunamadı");
                return evler; // Dosya yoksa boş liste döndür
            }

            using (FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs))
            {
                string yazi;
                while ((yazi = sr.ReadLine()) != null)
                {
                    string[] dosya = yazi.Split('|');

                    if (dosya.Length != 10)
                    {
                        Console.WriteLine("Veri formatı hatalı: " + yazi);
                        MessageBox.Show("ada");
                        continue;
                    }

                    try
                    {
                        SatilikEv ev = new SatilikEv(
                            dosya[1],         // il
                            dosya[2],         // ilce
                            int.Parse(dosya[3]), // KatNumarasi
                            int.Parse(dosya[4]), // Alan
                            int.Parse(dosya[5]), // OdaSayisi
                            dosya[6],           // Tip
                            dosya[7],         // turu
                            int.Parse(dosya[8]), // Yasi
                            decimal.Parse(dosya[9]), // Fiyat
                            decimal.Parse(dosya[0])  // EmlakNumarasi
                            
                        );

                        evler.Add(ev);
                        Ev.evler.Add(ev);
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Veri formatı hatalı: " + yazi);
                        Console.WriteLine("Hata: " + ex.Message);
                        continue; 
                    }
                }
            }

            return evler;
        }



        public static void DosyaKiralikEvYazmak(string dosya_yolu, string durum)
        {
            if (!File.Exists(dosya_yolu))
            {
                File.Create(dosya_yolu);
            }
            FileStream fs = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            foreach (KiralikEv ev in KiralikEv.evler)
            {
                if (ev.turu.Equals("kiralik"))
                {
                    sw.WriteLine(ev.EmlakNumarasi + "|" + ev.il + "|" + ev.ilce + "|" + ev.KatNumarasi + "|" + ev.Alan +"|"+ ev.OdaSayisi + "|" + ev.Tip +
                  "|" + ev.turu + "|" +ev.Yasi + "|" + ev.Kira +"|"+ ev.Depozito);               
                }
            }

            sw.Close();
            fs.Close();
        }
        public static List<KiralikEv> DosyaKiralikEvOkuma()
        {
            List<KiralikEv> evler = new List<KiralikEv>();
            string dosya_yolu = @"C:\Users\90546\OneDrive\Masaüstü\Emlak_Otomasyonu-main\kiralik.txt";

            if (!File.Exists(dosya_yolu))
            {
                MessageBox.Show("Kiralık Dosyası Bulunamadı");
                return evler;
            }

            using (FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs))
            {
                string yazi;
                while ((yazi = sr.ReadLine()) != null)
                {
                    string[] dosya = yazi.Split('|');

                        if (dosya.Length != 11)
                        {
                            Console.WriteLine("Veri formatı hatalı: " + yazi);
                            MessageBox.Show("Veri formatı ");
                            continue; // Hatalı veriyi atla
                        }

                    try
                    {
                        KiralikEv ev = new KiralikEv(
                            dosya[1],         // il
                            dosya[2],         // ilce
                            int.Parse(dosya[3]), // KatNumarasi
                            int.Parse(dosya[4]), // Alan
                            int.Parse(dosya[5]), // OdaSayisi
                            dosya[6],           // Tip
                            dosya[7],         // turu
                            int.Parse(dosya[8]), // Yasi
                            decimal.Parse(dosya[9]), // Kira
                            decimal.Parse(dosya[10]), // Depozito
                            decimal.Parse(dosya[0])  // EmlakNumarasi
                        );

                        evler.Add(ev);
                        Ev.evler.Add(ev);
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Veri formatı hatalı: " + yazi);
                        Console.WriteLine("Hata: " + ex.Message);
                        continue; // Hatalı veriyi atla
                    }
                }
            }
            return evler;
        }

        public static void DosyadanSatirSil(string dosyaYolu, decimal emlakNumarasi)
        {
            List<string> satirlar = new List<string>();
            using (StreamReader sr = new StreamReader(dosyaYolu))
            {
                string satir;
                while ((satir = sr.ReadLine()) != null)
                {
                    if (!satir.StartsWith(emlakNumarasi.ToString()))
                    {
                        satirlar.Add(satir);
                    }
                }
            }

            using (StreamWriter sw = new StreamWriter(dosyaYolu))
            {
                foreach (string s in satirlar)
                {
                    sw.WriteLine(s);
                }
            }
        }

    }

    }

    