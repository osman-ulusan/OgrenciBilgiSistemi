using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OgrenciBilgiSistemi.Fonksiyonlar;

namespace OgrenciBilgiSistemi
{
    public partial class frmGiris : Form
    {
        Formlar F = new Formlar();
        ogrenciIsleriDataContext db = new ogrenciIsleriDataContext();
        public frmGiris()
        {
            InitializeComponent();
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            
        }
        private bool kullanicidogrula(string kAdi, string kParola)
        {
            var sorgu = from p in db.tblGiris
                        where p.kullaniciAdi == txtKullaniciAdi.Text
                         && p.sifre == txtSifre.Text
                        select p;
            if (sorgu.Any())
            {
                return true;
            }

            else
            {
                return false;
            }

        }
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            MainPage frm = new MainPage();
            if (kullanicidogrula(txtKullaniciAdi.Text, txtSifre.Text))
            {
                MainPage.IAktar = Convert.ToInt32(db.tblGiris.First(x => x.kullaniciAdi == txtKullaniciAdi.Text).mode);
                MainPage.sAktar = db.tblGiris.First(x => x.kullaniciAdi == txtKullaniciAdi.Text).kullaniciAdi;
                frm.Show();
                Hide();
                
            }
            else
            {
                MessageBox.Show("Hatalı giriş");
            }
                
        }

        private void frmGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Çıkmak İstediğinizden Emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
        }
    }
}
