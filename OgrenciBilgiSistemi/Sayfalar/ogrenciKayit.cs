using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OgrenciBilgiSistemi.Fonksiyonlar;


namespace OgrenciBilgiSistemi.Sayfalar
{
    public partial class ogrenciKayit : Form
    {
        ogrenciIsleriDataContext db = new ogrenciIsleriDataContext();
        Formlar F = new Formlar();
        OpenFileDialog dosya = new OpenFileDialog();
        Resimler R = new Resimler();
        OgrNumara N = new OgrNumara();

        //bool resim = false;
        bool edit = false;
        int ogrenciNo = -1;
        bool bosmuDolumu;

        public ogrenciKayit()
        {
            InitializeComponent();
        }

        private void ogrenciKayit_Load(object sender, EventArgs e)
        {
            comboBolum();
            txtOgrNo.Text = N.OgrenciNumara();
        }

        private void ogrenciKayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainPage.SayfaKontrol = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            foreach (Control item in gbOgrenci.Controls)
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
            }

            if (edit == false && bosmuDolumu == false)
            {
                Kaydet();
            }
            else if (edit && ogrenciNo > 0 && MessageBox.Show("Seçili olan kayıt guncellenecektir\n Güncelleme işlemini onaylıyormusunuz ?", "Güncelleme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Guncelle();
            }
            else
            {
                MessageBox.Show("Guncelleme İptal Edildi");
            }

        }

        private void Kaydet()
        {
            try
            {
                tblOgrenci ogr = new tblOgrenci();
                string fullName = txtAdSoyad.Text;
                fullName = fullName.Trim();
                string firstName = string.Empty;
                string lastName = string.Empty;

                if (!fullName.Contains(" "))
                {
                    //ad-soyad alanında boşluk karakteri yok ise 
                    MessageBox.Show("Adınız ile soyadınız arasında boşluk olmalı");
                    return; //bitir
                }
                else
                {
                    firstName = fullName.Substring(0, fullName.IndexOf(" "));   //başlangıçtan boşluk karakterine kadar olan değeri al
                    lastName = fullName.Substring(fullName.IndexOf(" ") + 1);   //boşluktan bir sonraki karakterden itibaren al
                }
                ogr.OgrAdiSoyadi = txtAdSoyad.Text;
                ogr.OgrNumara = txtOgrNo.Text;
                ogr.Adres = txtAdres.Text;
                ogr.Email = txtEmail.Text;
                ogr.TcKimlik = txtTcKimlik.Text;
                ogr.Telefon = txtTel.Text;
                ogr.BolumId = cbBolum.Text != "" ? db.tblBolums.First(x => x.BolumAdi == cbBolum.Text).Id : -1;
                ogr.DogumTarihi = DateTime.Parse(txtDogumTarihi.Text);
                ogr.KayıtTarihi = DateTime.Parse(txtKayitTarihi.Text);
                if (pbResim.Image != null)
                {
                     ogr.Resim = new Binary(R.ResimYukleme(pbResim.Image));
                }
                   
                db.tblOgrencis.InsertOnSubmit(ogr);
                tblGiri grs = new tblGiri();
                grs.kullaniciAdi = txtOgrNo.Text;
                grs.sifre = firstName;
                grs.mode = 2;
                db.tblGiris.InsertOnSubmit(grs);


                db.SubmitChanges();

                MessageBox.Show("Öğrenci Kaydı Tamamlandı");
                //temizle();
                Close();
                F.OgrenciKayit();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata");
            }
        }
        private void Guncelle()
        {
            try
            {
                ogrenciIsleriDataContext db = new ogrenciIsleriDataContext();

                tblOgrenci ogr = db.tblOgrencis.First(x => x.OgrNumara == ogrenciNo.ToString());
                ogr.OgrAdiSoyadi = txtAdSoyad.Text;
                ogr.OgrNumara = txtOgrNo.Text;
                ogr.Adres = txtAdres.Text;
                ogr.Email = txtEmail.Text;
                ogr.TcKimlik = txtTcKimlik.Text;
                ogr.Telefon = txtTel.Text;
                ogr.BolumId = cbBolum.Text != "" ? db.tblBolums.First(x => x.BolumAdi == cbBolum.Text).Id : -1;
                if (pbResim.Image != null)
                {
                    ogr.Resim = new Binary(R.ResimYukleme(pbResim.Image));
                }
                ogr.DogumTarihi = DateTime.Parse(txtDogumTarihi.Text);
                ogr.KayıtTarihi = DateTime.Parse(txtKayitTarihi.Text);
                db.SubmitChanges();
                MessageBox.Show("Guncelleme Basarılı");
                //temizle();
                Close();
                F.OgrenciKayit();
            }
            catch (Exception e)
            {

                MessageBox.Show("Hata Kodu : A180 / Guncelleme Hatası" + e.Message);
            }
        }
        void comboBolum()
        {
            cbBolum.ValueMember = "Id";
            cbBolum.DisplayMember = "BolumAdi";
            cbBolum.DataSource = db.tblBolums.OrderBy(x => x.BolumAdi).ToList(); // orderbydescendig diyede direk cıkıyor.
            cbBolum.SelectedIndex = -1; // listenin boş gelmesini sağlıyor ilk gelen veri boş gozukuyor
        }

        private void temizle()
        {
            foreach (Control ct in gbOgrenci.Controls) // groupbox ıcındekı  controlleri -> controllere aktar
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

            txtOgrNo.Text = N.OgrenciNumara(); // yeni cari kodu almamızı saglıyor

            edit = false;
            ogrenciNo = -1;
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            ResimSec();
        }

        private void ResimSec()
        {
            dosya.Filter = "Jpg(*.jpg)|*.jpg|Jpeg(*.jpeg)|*.jpeg";
            if (dosya.ShowDialog() == DialogResult.OK) // resimi seçtim tamama bastıgımın sonrası ıcın
            {
                pbResim.ImageLocation = dosya.FileName;
                //resim = true;
            }
        }

        protected override void OnLoad(EventArgs e) // override -> üzerine yaz
        {
            var btnOgrenciler = new Button(); // yeni bir buton olusturduk
            btnOgrenciler.Size = new Size(25, txtOgrNo.ClientSize.Height + 2);
            btnOgrenciler.Location = new Point(txtOgrNo.ClientSize.Width - btnOgrenciler.Width, -1); //carikod un genişliğinin oldugu yere yenı buton oranın dısında olsun dıye -1 dedık farklı olsun anlamında

            btnOgrenciler.Cursor = Cursors.Default;
            btnOgrenciler.BackgroundImageLayout = ImageLayout.Stretch;
            btnOgrenciler.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            txtOgrNo.Controls.Add(btnOgrenciler);


            base.OnLoad(e); // initial compantten once çalısmasını saglıyor üst tarafa yazdıklarımız

            btnOgrenciler.Click += btnOgrenciler_Click;
        }

        private void btnOgrenciler_Click(object sender, EventArgs e)
        {
            F.OgrenciListele();
            int ogrNo = MainPage.IAktar;
            if (ogrNo > 0)
            {
                ogrenciListeleAc(ogrNo);
            }
            MainPage.IAktar = -1;
        }

        private void ogrenciListeleAc(int ogrNo)
        {
            try
            {
                edit = true;
                ogrenciNo = ogrNo;
                tblOgrenci ogr = db.tblOgrencis.First(x => x.OgrNumara == ogrenciNo.ToString());

                txtAdSoyad.Text = ogr.OgrAdiSoyadi;
                txtOgrNo.Text = ogr.OgrNumara;
                txtTcKimlik.Text = ogr.TcKimlik;
                txtEmail.Text = ogr.Email;
                cbBolum.Text = ogr.tblBolum.BolumAdi;
                txtAdres.Text = ogr.Adres;
                txtTel.Text = ogr.Telefon;
                txtDogumTarihi.Text = ogr.DogumTarihi.ToString();
                if (ogr.Resim != null)
                {
                    pbResim.Image = R.ResimGetirme(ogr.Resim.ToArray());
                }
                else
                {
                    //pbResim.Image = Resources.resimyok;
                }
                txtKayitTarihi.Text = ogr.KayıtTarihi.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Kodu : OgrenciListeleAc");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (edit && ogrenciNo > 0 && MessageBox.Show("Seçili olan kayıt silinecektir\n Silme işlemini onaylıyormusunuz ?", "Silme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Sil();
            }
        }
        private void Sil()
        {
            db.tblOgrencis.DeleteAllOnSubmit(db.tblOgrencis.Where(x => x.OgrNumara == ogrenciNo.ToString()));
            db.SubmitChanges();
            MessageBox.Show("Silme İşlemi Başarılı");
            temizle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gbOgrenci_Enter(object sender, EventArgs e)
        {

        }
    }
}
