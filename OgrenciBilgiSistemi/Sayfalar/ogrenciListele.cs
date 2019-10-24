using OgrenciBilgiSistemi.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi.Sayfalar
{
    public partial class ogrenciListele : Form
    {
        ogrenciIsleriDataContext db = new ogrenciIsleriDataContext();
        int secimId = -1;
        public ogrenciListele()
        {
            InitializeComponent();
        }
        void Listele()
        {
            liste.Rows.Clear();
            int i = 0;

            var lst = (from s in db.tblOgrencis where s.OgrAdiSoyadi.Contains(txtBul.Text) select s).ToList();
            foreach (var k in lst)
            {
                liste.Rows.Add();
                liste.Rows[i].Cells[0].Value = k.OgrAdiSoyadi;
                liste.Rows[i].Cells[1].Value = k.OgrNumara;
                liste.Rows[i].Cells[2].Value = k.TcKimlik;
                liste.Rows[i].Cells[3].Value = k.Email;
                liste.Rows[i].Cells[4].Value = k.tblBolum.BolumAdi;
                liste.Rows[i].Cells[5].Value = k.Adres;
                liste.Rows[i].Cells[6].Value = k.DogumTarihi;
                liste.Rows[i].Cells[7].Value = k.Resim;
                liste.Rows[i].Cells[8].Value = k.KayıtTarihi;
                i++;
            }
            liste.AllowUserToAddRows = false; // iş bittikten sonra kullanıcının yazmasını engelliyor.
        }

        private void ogrenciListele_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (secimId > 0)
            {
                MainPage.IAktar = secimId;
                Close();
            }
        }

        private void Sec()
        {
            try
            {
                secimId = int.Parse(liste.CurrentRow.Cells[1].Value.ToString());
            }
            catch (Exception)
            {

                secimId = -1;
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
