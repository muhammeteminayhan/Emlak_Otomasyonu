namespace emlak
{
    partial class Ek_Düzenleme
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
            Geri = new Button();
            Kira = new TextBox();
            label10 = new Label();
            tDepozito = new TextBox();
            Oda_Sayisi = new TextBox();
            Kat_Numarasi = new TextBox();
            Kaydet = new Button();
            Kiralik = new RadioButton();
            Satilik = new RadioButton();
            Ev_Turu = new ComboBox();
            label9 = new Label();
            tFiyat = new TextBox();
            label8 = new Label();
            Yapim = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            tAlan = new TextBox();
            label4 = new Label();
            label3 = new Label();
            ILCE = new ComboBox();
            IL = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // Geri
            // 
            Geri.BackColor = Color.RosyBrown;
            Geri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Geri.Location = new Point(65, 244);
            Geri.Name = "Geri";
            Geri.Size = new Size(151, 50);
            Geri.TabIndex = 50;
            Geri.Text = "Geri";
            Geri.UseVisualStyleBackColor = false;
            Geri.Click += Geri_Click;
            // 
            // Kira
            // 
            Kira.Location = new Point(192, 187);
            Kira.Name = "Kira";
            Kira.Size = new Size(151, 27);
            Kira.TabIndex = 49;
            Kira.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(65, 186);
            label10.Name = "label10";
            label10.Size = new Size(67, 28);
            label10.TabIndex = 48;
            label10.Text = "Kira : ";
            label10.Visible = false;
            // 
            // tDepozito
            // 
            tDepozito.Location = new Point(192, 138);
            tDepozito.Name = "tDepozito";
            tDepozito.Size = new Size(151, 27);
            tDepozito.TabIndex = 47;
            tDepozito.Visible = false;
            // 
            // Oda_Sayisi
            // 
            Oda_Sayisi.Location = new Point(561, 328);
            Oda_Sayisi.Name = "Oda_Sayisi";
            Oda_Sayisi.Size = new Size(151, 27);
            Oda_Sayisi.TabIndex = 46;
            // 
            // Kat_Numarasi
            // 
            Kat_Numarasi.Location = new Point(561, 232);
            Kat_Numarasi.Name = "Kat_Numarasi";
            Kat_Numarasi.Size = new Size(151, 27);
            Kat_Numarasi.TabIndex = 45;
            // 
            // Kaydet
            // 
            Kaydet.BackColor = Color.RosyBrown;
            Kaydet.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Kaydet.Location = new Point(222, 244);
            Kaydet.Name = "Kaydet";
            Kaydet.Size = new Size(151, 50);
            Kaydet.TabIndex = 44;
            Kaydet.Text = "Kaydet";
            Kaydet.UseVisualStyleBackColor = false;
            Kaydet.Click += Kaydet_Click;
            // 
            // Kiralik
            // 
            Kiralik.AutoSize = true;
            Kiralik.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Kiralik.Location = new Point(222, 89);
            Kiralik.Name = "Kiralik";
            Kiralik.Size = new Size(94, 32);
            Kiralik.TabIndex = 43;
            Kiralik.TabStop = true;
            Kiralik.Text = "Kiralık";
            Kiralik.UseVisualStyleBackColor = true;
            Kiralik.CheckedChanged += Kiralik_CheckedChanged;
            // 
            // Satilik
            // 
            Satilik.AutoSize = true;
            Satilik.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Satilik.Location = new Point(81, 87);
            Satilik.Name = "Satilik";
            Satilik.Size = new Size(98, 32);
            Satilik.TabIndex = 42;
            Satilik.TabStop = true;
            Satilik.Text = "Satılık ";
            Satilik.UseVisualStyleBackColor = true;
            Satilik.CheckedChanged += Satilik_CheckedChanged;
            // 
            // Ev_Turu
            // 
            Ev_Turu.FormattingEnabled = true;
            Ev_Turu.Items.AddRange(new object[] { "Daire", "Bahçeli", "Dubleks", "Mustakil", "Villa" });
            Ev_Turu.Location = new Point(561, 373);
            Ev_Turu.Name = "Ev_Turu";
            Ev_Turu.Size = new Size(151, 28);
            Ev_Turu.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(455, 377);
            label9.Name = "label9";
            label9.Size = new Size(100, 28);
            label9.TabIndex = 40;
            label9.Text = "Ev Türü : ";
            // 
            // tFiyat
            // 
            tFiyat.Location = new Point(192, 137);
            tFiyat.Name = "tFiyat";
            tFiyat.Size = new Size(151, 27);
            tFiyat.TabIndex = 39;
            tFiyat.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(65, 138);
            label8.Name = "label8";
            label8.Size = new Size(75, 28);
            label8.TabIndex = 38;
            label8.Text = "Fiyat : ";
            label8.Visible = false;
            // 
            // Yapim
            // 
            Yapim.Location = new Point(561, 278);
            Yapim.Name = "Yapim";
            Yapim.Size = new Size(151, 27);
            Yapim.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(442, 277);
            label7.Name = "label7";
            label7.Size = new Size(113, 28);
            label7.TabIndex = 36;
            label7.Text = "Bina Yaşı : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(397, 228);
            label6.Name = "label6";
            label6.Size = new Size(158, 28);
            label6.TabIndex = 35;
            label6.Text = "Kat Numarası : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(428, 324);
            label5.Name = "label5";
            label5.Size = new Size(127, 28);
            label5.TabIndex = 34;
            label5.Text = "Oda Sayısı : ";
            // 
            // tAlan
            // 
            tAlan.Location = new Point(561, 183);
            tAlan.Name = "tAlan";
            tAlan.Size = new Size(151, 27);
            tAlan.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(438, 179);
            label4.Name = "label4";
            label4.Size = new Size(117, 28);
            label4.TabIndex = 32;
            label4.Text = "Alan(M2) : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(276, 38);
            label3.Name = "label3";
            label3.Size = new Size(165, 31);
            label3.TabIndex = 31;
            label3.Text = "HOŞGELDİNİZ";
            // 
            // ILCE
            // 
            ILCE.Enabled = false;
            ILCE.FormattingEnabled = true;
            ILCE.Location = new Point(561, 137);
            ILCE.Name = "ILCE";
            ILCE.Size = new Size(151, 28);
            ILCE.TabIndex = 30;
            // 
            // IL
            // 
            IL.Cursor = Cursors.NoMoveVert;
            IL.FormattingEnabled = true;
            IL.Items.AddRange(new object[] { "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa ", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" });
            IL.Location = new Point(561, 87);
            IL.Name = "IL";
            IL.Size = new Size(151, 28);
            IL.TabIndex = 28;
            IL.SelectedValueChanged += IL_SelectedValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(487, 133);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 29;
            label2.Text = "İLÇE : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(510, 83);
            label1.Name = "label1";
            label1.Size = new Size(45, 28);
            label1.TabIndex = 27;
            label1.Text = "İL : ";
            // 
            // Ek_Düzenleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(766, 457);
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
            Name = "Ek_Düzenleme";
            Text = "Ek_Düzenleme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Geri;
        public TextBox Kira;
        public Label label10;
        public TextBox tDepozito;
        public TextBox Oda_Sayisi;
        public TextBox Kat_Numarasi;
        public Button Kaydet;
        public RadioButton Kiralik;
        public RadioButton Satilik;
        public ComboBox Ev_Turu;
        public Label label9;
        public TextBox tFiyat;
        public Label label8;
        public TextBox Yapim;
        public Label label7;
        public Label label6;
        public Label label5;
        public TextBox tAlan;
        public Label label4;
        public Label label3;
        public ComboBox ILCE;
        public ComboBox IL;
        public Label label2;
        public Label label1;
    }
}