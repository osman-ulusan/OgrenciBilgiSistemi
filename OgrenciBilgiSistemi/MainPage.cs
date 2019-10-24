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
    public partial class MainPage : Form
    {
        Formlar F = new Formlar();
        ogrenciIsleriDataContext db = new ogrenciIsleriDataContext();
        public static bool SayfaKontrol = false;
        public static bool girisKontrol = false;
        public static int IAktar;
        public static string sAktar;
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            int girisKimYaptı = MainPage.IAktar;
            string girisKulAdi = MainPage.sAktar;

            string adiBul = db.tblGiris.First(x => x.kullaniciAdi == girisKulAdi).kullaniciAdi;
            var lst = (from i in db.tblOgrencis
                       where i.OgrNumara == adiBul
                       select i).ToList();
            foreach (var k in lst)
            {
                if (girisKimYaptı == 2)
                {
                    btnOgrenciKayıt.Visible = false;
                    btnDersKayıt.Visible = false;
                    btnOgrtKayit.Visible = false;
                    btnDersSecim.Visible = true;
                    lblAktif.Text = " Hoşgeldin : " + k.OgrAdiSoyadi;
                }
            }
            if (girisKimYaptı == 1)
            {
                btnOgrenciKayıt.Visible = true;
                btnDersKayıt.Visible = true;
                btnOgrtKayit.Visible = true;
                btnDersSecim.Visible = false;
                lblAktif.Text = " Hoşgeldin : " + db.tblGiris.First(x=>x.kullaniciAdi == girisKulAdi).kullaniciAdi;
            }
        }

        private void btnOgrenciKayıt_Click(object sender, EventArgs e)
        {
            if(SayfaKontrol == false)
            {
                F.OgrenciKayit();
            }
        }
        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmGiris frm = new frmGiris();
            frm.Show();
        }

        private void btnDersKayıt_Click(object sender, EventArgs e)
        {
            if (SayfaKontrol == false)
            {
                F.DersKayit();
            }
        }

        private void btnDersSecim_Click_1(object sender, EventArgs e)
        {
            if (SayfaKontrol == false)
            {
                F.DersSecim();
            }
        }

        private void btnOgrtKayit_Click(object sender, EventArgs e)
        {
            if (SayfaKontrol == false)
            {
                F.ogretmenKayit();
            }
        }
    }
}
