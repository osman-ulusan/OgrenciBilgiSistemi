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

namespace OgrenciBilgiSistemi.Sayfalar
{
    public partial class dersListele : Form
    {
        ogrenciIsleriDataContext db = new ogrenciIsleriDataContext();
        int secimId = -1;
        public dersListele()
        {
            InitializeComponent();
        }

        private void dersListele_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            liste.Rows.Clear();
            int i=0;
            var lst = (from s in db.tblDersKayits where s.DersAdi.Contains(txtBul.Text) select s).ToList();
            foreach (var a in lst)
            {
                liste.Rows.Add();
                liste.Rows[i].Cells[0].Value = a.Id;
                liste.Rows[i].Cells[1].Value=a.DersAdi;
                liste.Rows[i].Cells[2].Value=a.tblBolum.BolumAdi;
                liste.Rows[i].Cells[3].Value=a.OgrtId;
                i++;
            }
            liste.AllowUserToAddRows = false;

        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
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
                secimId = int.Parse(liste.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                secimId = -1;
            }
        }
    }
}
