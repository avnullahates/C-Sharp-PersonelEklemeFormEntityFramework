

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
using Context = DAL.Context;

namespace UI
{
    public partial class Form2 : Form
    {
        Form1 anaform;
        public Form2(Form1 frm1)
        {
            anaform = frm1; //Buraya iletilen frm1 i bu class ta farkli scope larda kullanmak icin global degiskene aktardim.
            InitializeComponent();
        }
        Context db;     

        private void cmbPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPersoneller.SelectedIndex == 1)
            {
                btnGirGuncelle.Enabled = true;
            }
        }

        private void btnYeniPersonel_Click(object sender, EventArgs e)
        {
            anaform.Show();
            this.Hide();
        }

        private void btnTumKayitlar_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(this);
            this.Hide();
            frm3.Show();

        }

        private void btnYeniPersonel_Click_1(object sender, EventArgs e)
        {
            anaform.Show();
            this.Hide();
        }
        IletisimBilgisi iletisimBilgisi;
        private void btnGirGuncelle_Click_1(object sender, EventArgs e)
        {
            iletisimBilgisi = db.IletisimBilgisileri.FirstOrDefault(x => x.PersonelID == (int)cmbPersoneller.SelectedValue);
            if (iletisimBilgisi != null)
            {
                txtEposta.Text = iletisimBilgisi.Eposta;
                txtTelefon.Text = iletisimBilgisi.Telefon;
                txtEvAdresi.Text = iletisimBilgisi.Adres;
            }
            else
            {
                MessageBox.Show("Iletisim bilgisi yoktur. Lutfen ekleyiniz");
            }

            cmbPersoneller.Enabled = false;
            btnGirGuncelle.Enabled = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (iletisimBilgisi ==null) //Secilen kisiye ait herhangi bir iletisim bilgisi yoksa
            {
                iletisimBilgisi = new IletisimBilgisi()
                {
                    PersonelID = (int)cmbPersoneller.SelectedValue,
                    Eposta = txtEposta.Text,
                    Adres = txtEvAdresi.Text,
                    Telefon = txtTelefon.Text
                };

                db.IletisimBilgisileri.Add(iletisimBilgisi);
            }
            else // Secilen kisiye ait  bir iletisim bilgisi varsa
            {
                iletisimBilgisi.Eposta = txtEposta.Text;
                iletisimBilgisi.Telefon = txtTelefon.Text;
                iletisimBilgisi.Adres = txtEvAdresi.Text;
            }
            db.SaveChanges();
            MessageBox.Show("Iletisim bilgileri eklenmistir/guncellenmistir");
            cmbPersoneller.Enabled = true;
            cmbPersoneller.SelectedIndex = -1;
            btnGirGuncelle.Enabled = true;
            Metotlar.Temizle(grbIletisimGirisEkrani);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaform.Show();
        }

        private void cmbPersoneller_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbPersoneller.SelectedIndex == -1)
                return;

            btnGirGuncelle.Enabled = true;
            
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            db = new Context();
            cmbPersoneller.DataSource = db.Personeller.ToList();
            cmbPersoneller.DisplayMember = "isimSoysisim";
            cmbPersoneller.ValueMember = "PersonelID";

            cmbPersoneller.SelectedIndex = -1; //Herhangi bir sey secili gelmesin(Bosluk gozuksun)
            btnGirGuncelle.Enabled = false;
        }
    }
}
