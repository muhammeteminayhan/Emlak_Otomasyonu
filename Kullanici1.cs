 namespace emlak
{
           public class Kullanici
            {
                public string Kullanici_Adi { get; set; }
                public string Sifre { get; set; }

                public Kullanici(string kullanici_Adi, string Sifre)
                {
                    this.Kullanici_Adi = kullanici_Adi;
                    this.Sifre = Sifre;
                }
            }
        }
   