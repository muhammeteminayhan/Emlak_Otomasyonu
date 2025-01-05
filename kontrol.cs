using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emlak
{
    internal class kontrol
    {
        public static bool FormButtonKontrol(Ekleme form)
        {
            if (form.IL.Text == "")
            {
                return false;
            }
            if (form.ILCE.Text == "")
            {
                return false;
            }
            if (!(form.Kiralik.Checked || form.Satilik.Checked))
            {
                return false;
            }
            if (form.Satilik.Checked)
            {
                if (form.tFiyat.Text == "")
                {
                    return false;
                }
            }
            if (form.Kiralik.Checked)
            {
                if(form.tDepozito.Text == "")
            {
                    return false;
                }
                if (form.Kira.Text == "")
                {
                    return false;
                }

            }
            if (form.tAlan.Text == "")
            {
                return false;
            }
            if (form.Oda_Sayisi.Text == "")
            {
                return false;
            }
            if (form.Kat_Numarasi.Text == "")
            {
                return false;
            }
            if (form.Ev_Turu.Text == "")
            {
                return false;
            }
            return true;
        }
        public static void SatilikRadioButton(Ekleme form)
        {
            form.label10.Visible = false;
            form.Kira.Visible = false;
            form.label8.Text = "Fiyatı :";
            form.label8.Visible = true;
            form.tFiyat.Visible = true;
            form.tDepozito.Visible = false; 
        }

        public static void KiralikRadioButton(Ekleme form)
        {
            form.tFiyat.Visible = false;
            form.label8.Visible = true;
            form.label8.Text = "Depozito :";
            form.label10.Visible = true;
            form.Kira.Visible = true;
            form.tDepozito.Visible = true;

        }
        public static void SatilikRadioButton(Ek_Düzenleme form)
        {
            form.label10.Visible = false;
            form.Kira.Visible = false;
            form.label8.Text = "Fiyatı :";
            form.label8.Visible = true;
            form.tFiyat.Visible = true;
            form.tDepozito.Visible = false;
        }

        public static void KiralikRadioButton(Ek_Düzenleme form)
        {
            form.tFiyat.Visible = false;
            form.label8.Visible = true;
            form.label8.Text = "Depozito :";
            form.label10.Visible = true;
            form.Kira.Visible = true;
            form.tDepozito.Visible = true;

        }
    }
}
