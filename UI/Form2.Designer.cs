
namespace UI
{
    partial class Form2
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
            this.btnTumKayitlar = new System.Windows.Forms.Button();
            this.btnYeniPersonel = new System.Windows.Forms.Button();
            this.grbIletisimGirisEkrani = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEvAdresi = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGirGuncelle = new System.Windows.Forms.Button();
            this.cmbPersoneller = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbIletisimGirisEkrani.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTumKayitlar
            // 
            this.btnTumKayitlar.Location = new System.Drawing.Point(190, 396);
            this.btnTumKayitlar.Name = "btnTumKayitlar";
            this.btnTumKayitlar.Size = new System.Drawing.Size(120, 39);
            this.btnTumKayitlar.TabIndex = 14;
            this.btnTumKayitlar.Text = "TUM KAYITLAR";
            this.btnTumKayitlar.UseVisualStyleBackColor = true;
            this.btnTumKayitlar.Click += new System.EventHandler(this.btnTumKayitlar_Click);
            // 
            // btnYeniPersonel
            // 
            this.btnYeniPersonel.Location = new System.Drawing.Point(15, 396);
            this.btnYeniPersonel.Name = "btnYeniPersonel";
            this.btnYeniPersonel.Size = new System.Drawing.Size(118, 39);
            this.btnYeniPersonel.TabIndex = 13;
            this.btnYeniPersonel.Text = "YENI PERSONEL";
            this.btnYeniPersonel.UseVisualStyleBackColor = true;
            this.btnYeniPersonel.Click += new System.EventHandler(this.btnYeniPersonel_Click_1);
            // 
            // grbIletisimGirisEkrani
            // 
            this.grbIletisimGirisEkrani.Controls.Add(this.btnKaydet);
            this.grbIletisimGirisEkrani.Controls.Add(this.label4);
            this.grbIletisimGirisEkrani.Controls.Add(this.txtEvAdresi);
            this.grbIletisimGirisEkrani.Controls.Add(this.txtTelefon);
            this.grbIletisimGirisEkrani.Controls.Add(this.label3);
            this.grbIletisimGirisEkrani.Controls.Add(this.txtEposta);
            this.grbIletisimGirisEkrani.Controls.Add(this.label2);
            this.grbIletisimGirisEkrani.Location = new System.Drawing.Point(3, 147);
            this.grbIletisimGirisEkrani.Name = "grbIletisimGirisEkrani";
            this.grbIletisimGirisEkrani.Size = new System.Drawing.Size(323, 243);
            this.grbIletisimGirisEkrani.TabIndex = 12;
            this.grbIletisimGirisEkrani.TabStop = false;
            this.grbIletisimGirisEkrani.Text = "Iletisim Bilgisi Giris Ekrani";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(207, 192);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 39);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ev Adresi:";
            // 
            // txtEvAdresi
            // 
            this.txtEvAdresi.Location = new System.Drawing.Point(87, 86);
            this.txtEvAdresi.Multiline = true;
            this.txtEvAdresi.Name = "txtEvAdresi";
            this.txtEvAdresi.Size = new System.Drawing.Size(220, 100);
            this.txtEvAdresi.TabIndex = 4;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(87, 60);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(220, 20);
            this.txtTelefon.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefonu:";
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(87, 30);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(220, 20);
            this.txtEposta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "E-Posta Adersi:";
            // 
            // btnGirGuncelle
            // 
            this.btnGirGuncelle.Location = new System.Drawing.Point(15, 67);
            this.btnGirGuncelle.Name = "btnGirGuncelle";
            this.btnGirGuncelle.Size = new System.Drawing.Size(295, 49);
            this.btnGirGuncelle.TabIndex = 11;
            this.btnGirGuncelle.Text = "GIRIS VEYA GUNCELLEME YAP";
            this.btnGirGuncelle.UseVisualStyleBackColor = true;
            this.btnGirGuncelle.Click += new System.EventHandler(this.btnGirGuncelle_Click_1);
            // 
            // cmbPersoneller
            // 
            this.cmbPersoneller.FormattingEnabled = true;
            this.cmbPersoneller.Location = new System.Drawing.Point(15, 40);
            this.cmbPersoneller.Name = "cmbPersoneller";
            this.cmbPersoneller.Size = new System.Drawing.Size(295, 21);
            this.cmbPersoneller.TabIndex = 10;
            this.cmbPersoneller.SelectedIndexChanged += new System.EventHandler(this.cmbPersoneller_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Iletisim Bilgilerini Tamamlamak icin Bir Personel Seciniz";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 450);
            this.Controls.Add(this.btnTumKayitlar);
            this.Controls.Add(this.btnYeniPersonel);
            this.Controls.Add(this.grbIletisimGirisEkrani);
            this.Controls.Add(this.btnGirGuncelle);
            this.Controls.Add(this.cmbPersoneller);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.grbIletisimGirisEkrani.ResumeLayout(false);
            this.grbIletisimGirisEkrani.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTumKayitlar;
        private System.Windows.Forms.Button btnYeniPersonel;
        private System.Windows.Forms.GroupBox grbIletisimGirisEkrani;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEvAdresi;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGirGuncelle;
        private System.Windows.Forms.ComboBox cmbPersoneller;
        private System.Windows.Forms.Label label1;
    }
}