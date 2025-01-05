
namespace emlak
{
    partial class Giris
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
            giris_button = new Button();
            label1 = new Label();
            Kullanici_Adi = new TextBox();
            Sifre = new TextBox();
            label2 = new Label();
            yeni_kayit = new Button();
            SuspendLayout();
            // 
            // giris_button
            // 
            giris_button.BackColor = Color.RosyBrown;
            giris_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            giris_button.Location = new Point(211, 138);
            giris_button.Name = "giris_button";
            giris_button.Size = new Size(176, 35);
            giris_button.TabIndex = 0;
            giris_button.Text = "Giriş";
            giris_button.UseVisualStyleBackColor = false;
            giris_button.Click += giris_button_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(36, 27);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı adı :";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Kullanici_Adi
            // 
            Kullanici_Adi.Location = new Point(176, 30);
            Kullanici_Adi.Name = "Kullanici_Adi";
            Kullanici_Adi.Size = new Size(194, 27);
            Kullanici_Adi.TabIndex = 2;
            // 
            // Sifre
            // 
            Sifre.Location = new Point(176, 87);
            Sifre.Name = "Sifre";
            Sifre.Size = new Size(194, 27);
            Sifre.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(101, 86);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 3;
            label2.Text = "Şifre :";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // yeni_kayit
            // 
            yeni_kayit.BackColor = SystemColors.AppWorkspace;
            yeni_kayit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            yeni_kayit.Location = new Point(36, 138);
            yeni_kayit.Name = "yeni_kayit";
            yeni_kayit.Size = new Size(169, 35);
            yeni_kayit.TabIndex = 5;
            yeni_kayit.Text = "Yeni Kayıt";
            yeni_kayit.UseVisualStyleBackColor = false;
            yeni_kayit.Click += yeni_kayit_Click;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(415, 197);
            Controls.Add(yeni_kayit);
            Controls.Add(Sifre);
            Controls.Add(label2);
            Controls.Add(Kullanici_Adi);
            Controls.Add(label1);
            Controls.Add(giris_button);
            Name = "Giris";
            Text = "Giris";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button giris_button;
        private Label label1;
        private TextBox Kullanici_Adi;
        private TextBox Sifre;
        private Label label2;
        private Button yeni_kayit;
    }
}