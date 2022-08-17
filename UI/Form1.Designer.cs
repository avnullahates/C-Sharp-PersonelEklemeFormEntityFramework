
namespace UI
{
    partial class Form1
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
            this.btnIletisimBilgileriniGor = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.grpPersonelKayit = new System.Windows.Forms.GroupBox();
            this.cmbBirimi = new System.Windows.Forms.ComboBox();
            this.rdoKadin = new System.Windows.Forms.RadioButton();
            this.rdoErkek = new System.Windows.Forms.RadioButton();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPersonelKayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIletisimBilgileriniGor
            // 
            this.btnIletisimBilgileriniGor.Location = new System.Drawing.Point(12, 329);
            this.btnIletisimBilgileriniGor.Name = "btnIletisimBilgileriniGor";
            this.btnIletisimBilgileriniGor.Size = new System.Drawing.Size(322, 40);
            this.btnIletisimBilgileriniGor.TabIndex = 7;
            this.btnIletisimBilgileriniGor.Text = "ILETISIM BILGILERINI GOR";
            this.btnIletisimBilgileriniGor.UseVisualStyleBackColor = true;
            this.btnIletisimBilgileriniGor.Click += new System.EventHandler(this.btnIletisimBilgileriniGor_Click_1);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(227, 283);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(107, 40);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click_1);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(12, 283);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(107, 40);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "TEMIZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click_1);
            // 
            // grpPersonelKayit
            // 
            this.grpPersonelKayit.Controls.Add(this.cmbBirimi);
            this.grpPersonelKayit.Controls.Add(this.rdoKadin);
            this.grpPersonelKayit.Controls.Add(this.rdoErkek);
            this.grpPersonelKayit.Controls.Add(this.dtpDogumTarihi);
            this.grpPersonelKayit.Controls.Add(this.label6);
            this.grpPersonelKayit.Controls.Add(this.label5);
            this.grpPersonelKayit.Controls.Add(this.label4);
            this.grpPersonelKayit.Controls.Add(this.txtTcNo);
            this.grpPersonelKayit.Controls.Add(this.label3);
            this.grpPersonelKayit.Controls.Add(this.txtSoyadi);
            this.grpPersonelKayit.Controls.Add(this.label2);
            this.grpPersonelKayit.Controls.Add(this.txtAdi);
            this.grpPersonelKayit.Controls.Add(this.label1);
            this.grpPersonelKayit.Location = new System.Drawing.Point(12, 12);
            this.grpPersonelKayit.Name = "grpPersonelKayit";
            this.grpPersonelKayit.Size = new System.Drawing.Size(322, 256);
            this.grpPersonelKayit.TabIndex = 4;
            this.grpPersonelKayit.TabStop = false;
            this.grpPersonelKayit.Text = "Personel Kayit Ekrani";
            // 
            // cmbBirimi
            // 
            this.cmbBirimi.FormattingEnabled = true;
            this.cmbBirimi.Items.AddRange(new object[] {
            "Yazilim",
            "Muhasebe",
            "ERP",
            "Yonetim",
            "Insan Kaynaklari",
            "IT",
            "Pazarlama",
            "Satis"});
            this.cmbBirimi.Location = new System.Drawing.Point(84, 156);
            this.cmbBirimi.Name = "cmbBirimi";
            this.cmbBirimi.Size = new System.Drawing.Size(200, 21);
            this.cmbBirimi.TabIndex = 15;
            // 
            // rdoKadin
            // 
            this.rdoKadin.AutoSize = true;
            this.rdoKadin.Location = new System.Drawing.Point(175, 133);
            this.rdoKadin.Name = "rdoKadin";
            this.rdoKadin.Size = new System.Drawing.Size(52, 17);
            this.rdoKadin.TabIndex = 14;
            this.rdoKadin.TabStop = true;
            this.rdoKadin.Text = "Kadin";
            this.rdoKadin.UseVisualStyleBackColor = true;
            // 
            // rdoErkek
            // 
            this.rdoErkek.AutoSize = true;
            this.rdoErkek.Location = new System.Drawing.Point(84, 133);
            this.rdoErkek.Name = "rdoErkek";
            this.rdoErkek.Size = new System.Drawing.Size(53, 17);
            this.rdoErkek.TabIndex = 13;
            this.rdoErkek.TabStop = true;
            this.rdoErkek.Text = "Erkek";
            this.rdoErkek.UseVisualStyleBackColor = true;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(84, 104);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpDogumTarihi.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Birimi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cinsiyet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dogum Tarihi";
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(84, 78);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(200, 20);
            this.txtTcNo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "TC Kimlik  No:";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(84, 52);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(200, 20);
            this.txtSoyadi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SoyAdi:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(84, 26);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(200, 20);
            this.txtAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adi:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 377);
            this.Controls.Add(this.btnIletisimBilgileriniGor);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.grpPersonelKayit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.grpPersonelKayit.ResumeLayout(false);
            this.grpPersonelKayit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIletisimBilgileriniGor;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.GroupBox grpPersonelKayit;
        private System.Windows.Forms.ComboBox cmbBirimi;
        private System.Windows.Forms.RadioButton rdoKadin;
        private System.Windows.Forms.RadioButton rdoErkek;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label1;
    }
}

