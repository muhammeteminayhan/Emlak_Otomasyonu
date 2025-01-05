
namespace emlak
{
    partial class Ekleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            IL = new ComboBox();
            ILCE = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            tAlan = new TextBox();
            label5 = new Label();
            label6 = new Label();
            Yapim = new TextBox();
            label7 = new Label();
            tFiyat = new TextBox();
            label8 = new Label();
            Ev_Turu = new ComboBox();
            label9 = new Label();
            Satilik = new RadioButton();
            Kiralik = new RadioButton();
            Kaydet = new Button();
            Kat_Numarasi = new TextBox();
            Oda_Sayisi = new TextBox();
            tDepozito = new TextBox();
            Kira = new TextBox();
            label10 = new Label();
            Geri = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(524, 75);
            label1.Name = "label1";
            label1.Size = new Size(45, 28);
            label1.TabIndex = 0;
            label1.Text = "İL : ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(501, 124);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 1;
            label2.Text = "İLÇE : ";
            // 
            // IL
            // 
            IL.Cursor = Cursors.NoMoveVert;
            IL.FormattingEnabled = true;
            IL.Items.AddRange(new object[] { "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa ", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" });
            IL.Location = new Point(575, 74);
            IL.Name = "IL";
            IL.Size = new Size(151, 28);
            IL.TabIndex = 0;
            IL.SelectedValueChanged += IL_SelectedValueChanged;
            // 
            // ILCE
            // 
            ILCE.Enabled = false;
            ILCE.FormattingEnabled = true;
            ILCE.Location = new Point(575, 124);
            ILCE.Name = "ILCE";
            ILCE.Size = new Size(151, 28);
            ILCE.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(291, 27);
            label3.Name = "label3";
            label3.Size = new Size(165, 31);
            label3.TabIndex = 4;
            label3.Text = "HOŞGELDİNİZ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(452, 174);
            label4.Name = "label4";
            label4.Size = new Size(117, 28);
            label4.TabIndex = 5;
            label4.Text = "Alan(M2) : ";
            // 
            // tAlan
            // 
            tAlan.Location = new Point(575, 174);
            tAlan.Name = "tAlan";
            tAlan.Size = new Size(151, 27);
            tAlan.TabIndex = 6;
            tAlan.KeyPress += KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(442, 318);
            label5.Name = "label5";
            label5.Size = new Size(127, 28);
            label5.TabIndex = 7;
            label5.Text = "Oda Sayısı : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(411, 219);
            label6.Name = "label6";
            label6.Size = new Size(158, 28);
            label6.TabIndex = 9;
            label6.Text = "Kat Numarası : ";
            // 
            // Yapim
            // 
            Yapim.Location = new Point(575, 269);
            Yapim.Name = "Yapim";
            Yapim.Size = new Size(151, 27);
            Yapim.TabIndex = 12;
            Yapim.KeyPress += KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(456, 268);
            label7.Name = "label7";
            label7.Size = new Size(113, 28);
            label7.TabIndex = 11;
            label7.Text = "Bina Yaşı : ";
            // 
            // tFiyat
            // 
            tFiyat.Location = new Point(211, 155);
            tFiyat.Name = "tFiyat";
            tFiyat.Size = new Size(151, 27);
            tFiyat.TabIndex = 14;
            tFiyat.Visible = false;
            tFiyat.KeyPress += KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(54, 156);
            label8.Name = "label8";
            label8.Size = new Size(75, 28);
            label8.TabIndex = 13;
            label8.Text = "Fiyat : ";
            label8.Visible = false;
            // 
            // Ev_Turu
            // 
            Ev_Turu.FormattingEnabled = true;
            Ev_Turu.Items.AddRange(new object[] { "Daire", "Bahçeli", "Dubleks", "Mustakil", "Villa" });
            Ev_Turu.Location = new Point(575, 364);
            Ev_Turu.Name = "Ev_Turu";
            Ev_Turu.Size = new Size(151, 28);
            Ev_Turu.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(469, 364);
            label9.Name = "label9";
            label9.Size = new Size(100, 28);
            label9.TabIndex = 15;
            label9.Text = "Ev Türü : ";
            // 
            // Satilik
            // 
            Satilik.AutoSize = true;
            Satilik.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Satilik.Location = new Point(83, 104);
            Satilik.Name = "Satilik";
            Satilik.Size = new Size(98, 32);
            Satilik.TabIndex = 17;
            Satilik.TabStop = true;
            Satilik.Text = "Satılık ";
            Satilik.UseVisualStyleBackColor = true;
            Satilik.CheckedChanged += Satilik_CheckedChanged;
            // 
            // Kiralik
            // 
            Kiralik.AutoSize = true;
            Kiralik.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Kiralik.Location = new Point(224, 106);
            Kiralik.Name = "Kiralik";
            Kiralik.Size = new Size(94, 32);
            Kiralik.TabIndex = 18;
            Kiralik.TabStop = true;
            Kiralik.Text = "Kiralık";
            Kiralik.UseVisualStyleBackColor = true;
            Kiralik.CheckedChanged += Kiralik_CheckedChanged;
            // 
            // Kaydet
            // 
            Kaydet.BackColor = Color.RosyBrown;
            Kaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Kaydet.Location = new Point(211, 254);
            Kaydet.Name = "Kaydet";
            Kaydet.Size = new Size(151, 50);
            Kaydet.TabIndex = 19;
            Kaydet.Text = "Kaydet";
            Kaydet.UseVisualStyleBackColor = false;
            Kaydet.Click += Kaydet_Click;
            // 
            // Kat_Numarasi
            // 
            Kat_Numarasi.Location = new Point(575, 219);
            Kat_Numarasi.Name = "Kat_Numarasi";
            Kat_Numarasi.Size = new Size(151, 27);
            Kat_Numarasi.TabIndex = 20;
            Kat_Numarasi.KeyPress += KeyPress;
            // 
            // Oda_Sayisi
            // 
            Oda_Sayisi.Location = new Point(575, 319);
            Oda_Sayisi.Name = "Oda_Sayisi";
            Oda_Sayisi.Size = new Size(151, 27);
            Oda_Sayisi.TabIndex = 21;
            Oda_Sayisi.KeyPress += KeyPress;
            // 
            // tDepozito
            // 
            tDepozito.Location = new Point(211, 156);
            tDepozito.Name = "tDepozito";
            tDepozito.Size = new Size(151, 27);
            tDepozito.TabIndex = 23;
            tDepozito.Visible = false;
            tDepozito.KeyPress += KeyPress;
            // 
            // Kira
            // 
            Kira.Location = new Point(211, 205);
            Kira.Name = "Kira";
            Kira.Size = new Size(151, 27);
            Kira.TabIndex = 25;
            Kira.Visible = false;
            Kira.KeyPress += KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(54, 204);
            label10.Name = "label10";
            label10.Size = new Size(67, 28);
            label10.TabIndex = 24;
            label10.Text = "Kira : ";
            label10.Visible = false;
            // 
            // Geri
            // 
            Geri.BackColor = Color.RosyBrown;
            Geri.Location = new Point(54, 254);
            Geri.Name = "Geri";
            Geri.Size = new Size(151, 50);
            Geri.TabIndex = 26;
            Geri.Text = "Geri";
            Geri.UseVisualStyleBackColor = false;
            Geri.Click += Geri_Click;
            // 
            // Ekleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(774, 462);
            Controls.Add(Geri);
            Controls.Add(Kira);
            Controls.Add(label10);
            Controls.Add(tDepozito);
            Controls.Add(Oda_Sayisi);
            Controls.Add(Kat_Numarasi);
            Controls.Add(Kaydet);
            Controls.Add(Kiralik);
            Controls.Add(Satilik);
            Controls.Add(Ev_Turu);
            Controls.Add(label9);
            Controls.Add(tFiyat);
            Controls.Add(label8);
            Controls.Add(Yapim);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tAlan);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ILCE);
            Controls.Add(IL);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ekleme";
            Text = "Ekleme";
            ResumeLayout(false);
            PerformLayout();
        }

        private void Kat_Numarasi_SelectedValueChanged1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        public Label label1;
        public Label label2;
        public System.Windows.Forms.ComboBox ILCE;
        public System.Windows.Forms.ComboBox IL;
        public Label label3;
        public Label label4;
        public System.Windows.Forms.TextBox tAlan;
        public Label label5;
        public Label label6;
        public System.Windows.Forms.TextBox Yapim;
        public Label label7;
        public System.Windows.Forms.TextBox tFiyat;
        public Label label8;
        public ComboBox Ev_Turu;
        public Label label9;
        public System.Windows.Forms.RadioButton Satilik;
        public System.Windows.Forms.RadioButton Kiralik;
        public System.Windows.Forms.Button Kaydet;
        public System.Windows.Forms.TextBox Kat_Numarasi;
        public System.Windows.Forms.TextBox Oda_Sayisi;
        public TextBox tDepozito;
        public TextBox Kira;
        public Label label10;
        private Button Geri;
    }
}