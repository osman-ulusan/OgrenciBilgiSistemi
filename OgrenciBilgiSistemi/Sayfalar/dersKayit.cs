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
    public partial class dersKayit : Form
    {
        ogrenciIsleriDataContext db = new ogrenciIsleriDataContext();
        Formlar F = new Formlar();
        int DersId = -1;
        bool edit = false;
        bool bosmuDolumu;


        public dersKayit()
        {
            InitializeComponent();
        }

        private void dersKayit_Load(object sender, EventArgs e)
        {
            ComboBolum();
            ComboOgretmen();
        }
        private void temizle()
        {
            foreach (Control ct in gbDersKayit.Controls) // groupbox ıcındekı  controlleri -> controllere aktar
            {
                if (ct is TextBox) //controllerın ıcındekı textboxlar ise  //(ct is TextBox || ct is ComboBox) bu şekıldede 2 farklı tooluda alabılırız
                {
                    ct.Text = ""; // bunların textlerini boşalt
                }
                else if (ct is ComboBox) //controllerın ıcındekı textboxlar ise  //(ct is TextBox || ct is ComboBox) bu şekıldede 2 farklı tooluda alabılırız
                {
                    ct.Text = ""; // bunların textlerini boşalt
                }
            }
            edit = false;
            DersId = -1;
        }

        private void ComboBolum()
        {
            cbBolumAdi.ValueMember = "Id";
            cbBolumAdi.DisplayMember = "BolumAdi";
            cbBolumAdi.DataSource = db.tblBolums.OrderBy(x=>x.BolumAdi).ToList();
            cbBolumAdi.SelectedIndex = -1; // listenin boş gelmesini sağlıyor ilk gelen veri boş gozukuyor
        }
        private void ComboOgretmen()
        {
            cbOgretmen.ValueMember = "Id";
            cbOgretmen.DisplayMember = "OgrtAdi";
            cbOgretmen.DataSource = db.tblOgrtGorevlisis.OrderBy(x => x.OgrtAdi).ToList();
            cbOgretmen.SelectedIndex = -1; // listenin boş gelmesini sağlıyor ilk gelen veri boş gozukuyor
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            foreach (Control item in gbDersKayit.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "")
                    {
                        errorProvider1.SetError(item, "Bu alan boş olamaz!");
                        bosmuDolumu = true;
                        return;

                    }
                    else
                    {
                        bosmuDolumu = false;
                    }
                }
                if (item is ComboBox)
                {
                    if (item.Text == "")
                    {
                        errorProvider1.SetError(item, "Bu alan boş olamaz!");
                        bosmuDolumu = true;
                        return;

                    }
                    else
                    {
                        bosmuDolumu = false;
                    }
                }
            }

            if (edit && DersId > 0 && MessageBox.Show("Seçili olan kayıt guncellenecektir\n Güncelleme işlemini onaylıyormusunuz ?", "Güncelleme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Guncelle();
            }
            else if (edit == false)
            {
                if (bosmuDolumu==false)
                {
                    Kaydet();
                } 
            }
            else
            {
                MessageBox.Show("Guncelleme İptal Edildi");
            }
        }

        private void Guncelle()
        {
            try
            {
                ogrenciIsleriDataContext db = new ogrenciIsleriDataContext();
                tblDersKayit drsKayit = db.tblDersKayits.First(x => x.Id == DersId);
                drsKayit.DersAdi = txtDersAdi.Text;
                drsKayit.BolumId = cbBolumAdi.Text != "" ? db.tblBolums.First(x => x.BolumAdi == cbBolumAdi.Text).Id : -1;
                drsKayit.OgrtId =  cbOgretmen.Text != "" ? db.tblOgrtGorevlisis.First(x => x.OgrtAdi == cbOgretmen.Text).Id : -1;
                db.SubmitChanges();
                MessageBox.Show("Guncelleme Basarılı");
                temizle();
                Close();
                F.DersKayit();
            }
            catch (Exception)
            {

                MessageBox.Show("Guncelleme Hatası");
            }




        }

        void Kaydet()
        {
            try
            {
                tblDersKayit drs = new tblDersKayit();
                drs.DersAdi = txtDersAdi.Text;
                drs.BolumId = cbBolumAdi.Text != "" ? db.tblBolums.First(x => x.BolumAdi == cbBolumAdi.Text).Id : -1;
                drs.OgrtId = cbOgretmen.Text != "" ? db.tblOgrtGorevlisis.First(x => x.OgrtAdi == cbOgretmen.Text).Id : -1;
                db.tblDersKayits.InsertOnSubmit(drs);
                db.SubmitChanges();
                MessageBox.Show("Ders Kaydı Tamamlandı");
                temizle();


            }
            catch (Exception e)
            {

                MessageBox.Show("Hata" + e);
            }
        }

        protected override void OnLoad(EventArgs e) // override -> üzerine yaz
        {
            var btnDersler = new Button(); // yeni bir buton olusturduk
            btnDersler.Size = new Size(25, txtDersAdi.ClientSize.Height + 2);
            btnDersler.Location = new Point(txtDersAdi.ClientSize.Width - btnDersler.Width, -1); //carikod un genişliğinin oldugu yere yenı buton oranın dısında olsun dıye -1 dedık farklı olsun anlamında

            btnDersler.Cursor = Cursors.Default;
            btnDersler.BackgroundImageLayout = ImageLayout.Stretch;
            btnDersler.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            txtDersAdi.Controls.Add(btnDersler);


            base.OnLoad(e); // initial compantten once çalısmasını saglıyor üst tarafa yazdıklarımız

            btnDersler.Click += btnDersler_Click;
        }

        private void btnDersler_Click(object sender, EventArgs e)
        {
            F.dersListele();
            DersId = MainPage.IAktar;
            if (DersId > 0)
            {
                DersKayitAc(DersId);
            }
        }

        private void DersKayitAc(int DersAdi)
        {
            try
            {
                edit = true;
                ogrenciIsleriDataContext db = new ogrenciIsleriDataContext();
                tblDersKayit drs = db.tblDersKayits.First(x => x.Id == DersId);
                txtDersAdi.Text = drs.DersAdi;
                cbBolumAdi.Text = drs.tblBolum.BolumAdi;
                cbOgretmen.Text = drs.tblOgrtGorevlisi.OgrtAdi;
            }
            catch (Exception)
            {

            }

        }

        private void dersKayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainPage.SayfaKontrol = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (edit && DersId > 0 && MessageBox.Show("Seçili olan kayıt silinecektir\n Silme işlemini onaylıyormusunuz ?", "Silme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Sil();
            }
        }

        private void Sil()
        {
            db.tblDersKayits.DeleteAllOnSubmit(db.tblDersKayits.Where(x => x.Id == DersId));
            db.SubmitChanges();
            MessageBox.Show("Silme İşlemi Başarılı");
            temizle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
