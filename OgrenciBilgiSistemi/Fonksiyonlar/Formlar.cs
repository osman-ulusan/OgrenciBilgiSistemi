using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OgrenciBilgiSistemi.Sayfalar;

namespace OgrenciBilgiSistemi.Fonksiyonlar
{
    class Formlar
    {
        public void OgrenciKayit()
        {
            ogrenciKayit frm = new ogrenciKayit();
            frm.MdiParent = Form.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            MainPage.SayfaKontrol = true;
            frm.Show();
        }
        public void DersKayit()
        {
            dersKayit frm = new dersKayit();
            frm.MdiParent = Form.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            MainPage.SayfaKontrol = true;
            frm.Show();
        }
        public void DersSecim()
        {
            dersSecim frm = new dersSecim();
            frm.MdiParent = Form.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            MainPage.SayfaKontrol = true;
            frm.Show();
        }
        public void Giris()
        {
            MainPage frm = new MainPage();
            MainPage.SayfaKontrol = true;
            frm.Show();
        }
        public void OgrenciListele()
        {
            ogrenciListele frm = new ogrenciListele();
            frm.ShowDialog();
        }
        public void dersListele()
        {
            dersListele frm = new dersListele();
            frm.ShowDialog();
        }
        public void dersSecimListele()
        {
            dersSecimListele frm = new dersSecimListele();
            frm.ShowDialog();
        }
        public void ogretmenKayit()
        {
            ogretmenKayit frm = new ogretmenKayit();
            frm.MdiParent = Form.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            MainPage.SayfaKontrol = true;
            frm.Show();
        }
        public void ogrtListele()
        {
            ogrtListele frm = new ogrtListele();
            frm.ShowDialog();
        }
    }
}
