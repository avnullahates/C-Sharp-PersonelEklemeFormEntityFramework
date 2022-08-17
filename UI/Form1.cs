using DAL;
using DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Context db;
        

      

       

       

        private void btnIletisimBilgileriniGor_Click_1(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(this); // geriye donmek(YENI PERSONEL butonuna tiklandiginda) icin bu formadn bir ornegi Form2 nin Constructor ina gonderiyoruz

            this.Hide();
            frm2.Show();
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            if (Metotlar.BosAlanVarMi(grpPersonelKayit))
            {
                MessageBox.Show("Lutfen tum alanlari doldurunuz. Yada Dogum Tarih bilgisini bugun girmeyiniz !!!");
            }
            else
            {
                Personel personel = db.Personeller.FirstOrDefault(x => x.TCKimlikNo == txtTcNo.Text);// Bu TC Kimlik ile kayit var mi? Varsa eklemez!


                if (personel == null)
                {

                    personel = new Personel()
                    {
                        Isim = txtAdi.Text,
                        Soyisim = txtSoyadi.Text,
                        TCKimlikNo = txtTcNo.Text,
                        DogumTarihi = dtpDogumTarihi.Value,
                        Cinsiyet = rdoErkek.Checked,
                        Birim = cmbBirimi.Text

                    };
                    db.Personeller.Add(personel);
                    db.SaveChanges();
                    btnTemizle.Enabled = btnIletisimBilgileriniGor.Enabled = true;

                    MessageBox.Show("Kaydetme islemi basarili :)");
                }
                else
                {
                    MessageBox.Show("Ayni Tc Kimlik No ile Personel Eklenmez");
                }

            }
        }

        private void btnTemizle_Click_1(object sender, EventArgs e)
        {
            Metotlar.Temizle(grpPersonelKayit);
            btnTemizle.Enabled = false;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            db = new Context();
            rdoErkek.Checked = true;
            btnTemizle.Enabled = false;
            btnIletisimBilgileriniGor.Enabled = db.Personeller.ToList().Count > 0 ? true : false;
        }
    }
}
