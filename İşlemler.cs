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
    public partial class İşlemler : Form
    {
        public İşlemler()
        {
            InitializeComponent();
        }
        private void Ekleme_Click(object sender, EventArgs e)
        {
            Ekleme ekleme = new Ekleme();
            ekleme.Show();
            this.Hide();

        }
        private void K_Sorgula_Click(object sender, EventArgs e)
        {
            sorgu sorgu = new sorgu();
            sorgu.Show();
            this.Hide();

        }


        private void İşlemler_Load(object sender, EventArgs e)
        {
            D_Islemleri.DosyaIdBelirleme();
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();  
            giris.Show();

            this.Hide();
        }
    }
}
