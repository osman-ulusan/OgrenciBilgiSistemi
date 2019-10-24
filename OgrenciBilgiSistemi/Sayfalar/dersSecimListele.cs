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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace OgrenciBilgiSistemi.Sayfalar
{
    public partial class dersSecimListele : Form
    {

        ogrenciIsleriDataContext db = new ogrenciIsleriDataContext();
        int secimId = -1;
        public dersSecimListele()
        {
            InitializeComponent();
        }

        private void dersSecimListele_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private string OgrtAdiBul(int ogrtAdi1)
        {
            string srg = db.tblOgrtGorevlisis.First(x => x.Id == ogrtAdi1).OgrtAdi;
            return srg;
        }

        private void Listele()
        {
            liste.Rows.Clear();
            int i = 0;

               int gelenOgrId = MainPage.IAktar;
               var lst = (from s in db.tblDersSecims where s.OgrId == gelenOgrId && s.tblDersKayit.DersAdi.Contains(txtBul.Text) select s).ToList();

            foreach (var k in lst)
            {
                liste.Rows.Add();
                liste.Rows[i].Cells[0].Value = k.Id;
                liste.Rows[i].Cells[1].Value = k.tblOgrenci.OgrAdiSoyadi;
                liste.Rows[i].Cells[2].Value = k.tblDersKayit.DersAdi;
                int gonder= k.tblDersKayit.OgrtId.Value;
                liste.Rows[i].Cells[3].Value = OgrtAdiBul(gonder);
                i++;
            }
            liste.AllowUserToAddRows = false; // iş bittikten sonra kullanıcının yazmasını engelliyor.

        }

        private void dersSecimListele_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainPage.SayfaKontrol = false;
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

        private void btnBul_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < liste.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = liste.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < liste.Rows.Count; i++)
            {
                for (int j = 0; j < liste.Columns.Count; j++)
                {
                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = liste[j, i].Value == null ? "" : liste[j, i].Value;
                    myRange.Select();
                }
            }
        }
    }
}
