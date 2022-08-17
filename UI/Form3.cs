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
    public partial class Form3 : Form
    {
        Form2 IletisimBilgisiForm;
        Context db;
        public Form3(Form2 frm2)
        {
            IletisimBilgisiForm = frm2;
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (Metotlar.BosAlanVarMi(grpPersonelBul))
            {
                MessageBox.Show("Lutfen aranacak sozcuk ve arama secenegini bos birakmayiniz!");
            }
            else
            {
                switch (cmbAranacak.SelectedIndex)
                {
                    case 0:
                        //ile baslayan
                        List<Personel> ileBaslayanPersoneller = db.Personeller.Where(x => x.Isim.StartsWith(txtAranacakMetin.Text) || x.Soyisim.StartsWith(txtAranacakMetin.Text)).ToList();
                        lbxPersoneller.DataSource = ileBaslayanPersoneller;
                        lbxPersoneller.DisplayMember = "isimSoysisim";
                        lbxPersoneller.ValueMember = "PersonelID";
                        /*
                        foreach (Personel item in ileBaslayanPersoneller)
                        {
                            lbxPersoneller.Items.Add(item.isimSoysisim)
                        }
                        */
                        break;


                    case 1:
                        //iceren
                        List<Personel> icerennPersoneller = db.Personeller.Where(x => x.Isim.Contains(txtAranacakMetin.Text) || x.Soyisim.Contains(txtAranacakMetin.Text)).ToList();
                        lbxPersoneller.DataSource = icerennPersoneller;
                        lbxPersoneller.DisplayMember = "isimSoysisim";
                        lbxPersoneller.ValueMember = "PersonelID";
                        break;

                    case 2:
                        //ile biten
                        List<Personel> ileBitenPersoneller = db.Personeller.Where(x => x.Isim.EndsWith(txtAranacakMetin.Text) || x.Soyisim.EndsWith(txtAranacakMetin.Text)).ToList();
                        lbxPersoneller.DataSource = ileBitenPersoneller;
                        lbxPersoneller.DisplayMember = "isimSoysisim";
                        lbxPersoneller.ValueMember = "PersonelID";
                        break;


                    default:
                        break;
                }
            }
        }

        private void lbxPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnTemizleBilgiler_Click(object sender, EventArgs e)
        {
            Metotlar.Temizle(grpPersonel);
        }

        private void btnTemizleBul_Click(object sender, EventArgs e)
        {
            Metotlar.Temizle(grpPersonelBul);
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 anaForm = new Form1();
            anaForm.Show();
            this.Hide();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            IletisimBilgisiForm.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            db = new Context();
        }

        private void lbxPersoneller_DoubleClick(object sender, EventArgs e)
        {

            Personel secilenPersonel = db.Personeller.Find((int)lbxPersoneller.SelectedValue);
            IletisimBilgisi secilenIletisimBilgisi = db.IletisimBilgisileri.Find((int)lbxPersoneller.SelectedValue);

            if (secilenPersonel != null && secilenIletisimBilgisi != null)
            {
                lblPerosnelBilgiler.Text ="          PERSONEL BILGILERI"+
                "\nAdi: " + secilenPersonel.Isim +
                "\nSoyadi: " + secilenPersonel.Soyisim +
                "\nTc Kilmlik No: " + secilenPersonel.TCKimlikNo +
                "\nDogum Tarihi: " + secilenPersonel.DogumTarihi.ToLongDateString() +
                "\nCinsiyet: " + (secilenPersonel.Cinsiyet ? "Erkek" : "Kadin") +
                "\nBirim:" + secilenPersonel.Birim +
                "\nE-Posta: " + secilenIletisimBilgisi.Eposta +
                "\nTelefon: " + secilenIletisimBilgisi.Telefon +
                "\nAdres: " + secilenIletisimBilgisi.Adres;
            }
            else if (secilenPersonel != null && secilenIletisimBilgisi == null)
            {
                lblPerosnelBilgiler.Text = "          PERSONEL BILGILERI" +
                                "\nAdi: " + secilenPersonel.Isim +
                                "\nSoyadi: " + secilenPersonel.Soyisim +
                                "\nTc Kilmlik No: " + secilenPersonel.TCKimlikNo +
                                "\nDogum Tarihi: " + secilenPersonel.DogumTarihi.ToLongDateString() +
                                "\nCinsiyet: " + (secilenPersonel.Cinsiyet ? "Erkek" : "Kadin") +
                                "\nBirim:" + secilenPersonel.Birim;
            }



        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Personel silinecekPersonel = db.Personeller.Find((int)lbxPersoneller.SelectedValue);
            IletisimBilgisi silinecenkPersonelIletisimBilgileri = db.IletisimBilgisileri.Find((int)lbxPersoneller.SelectedValue);

           DialogResult result= MessageBox.Show("Personel Bilgisini Silmek Istediginize Emin Misiniz?","Uyari",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (silinecenkPersonelIletisimBilgileri != null)
                {
                    db.IletisimBilgisileri.Remove(silinecenkPersonelIletisimBilgileri);
                    db.Personeller.Remove(silinecekPersonel);
                }
                else
                    db.Personeller.Remove(silinecekPersonel);
                db.SaveChanges();
                MessageBox.Show("Personel Bilgisi Silinmistir Geri alinamaz");
                Metotlar.Temizle(grpPersonel);
                Metotlar.Temizle(grpPersonelBul);
            }
            else if(result == DialogResult.No)
            {
                MessageBox.Show("Personel Bilgisi Silinmemistir.");
                Metotlar.Temizle(grpPersonel);
                Metotlar.Temizle(grpPersonelBul);
            }

            


            
            

            

            
        }
    }
}
