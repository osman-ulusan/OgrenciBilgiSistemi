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
    public partial class ogretmenKayit : Form
    {
        ogrenciIsleriDataContext db = new ogrenciIsleriDataContext();
        Formlar F = new Formlar();
        bool bosmuDolumu;
        int ogrtId = -1;
        bool edit = false;
        public ogretmenKayit()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            foreach (Control item in gbOgrtKayit.Controls)
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

            if (edit && ogrtId > 0 && MessageBox.Show("Seçili olan kayıt guncellenecektir\n Güncelleme işlemini onaylıyormusunuz ?", "Güncelleme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Guncelle();
            }
            else if (edit == false)
            {
                if (bosmuDolumu == false)
                {
                    Kaydet();
                }
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
                tblOgrtGorevlisi drs = new tblOgrtGorevlisi();
                drs.OgrtAdi = txtOgrtAdi.Text;
                drs.OgrtSoyadi = txtOgrtSoyadi.Text;
                drs.DersId   = cbBolum.Text != "" ? db.tblBolums.First(x => x.BolumAdi == cbBolum.Text).Id : -1;
                db.tblOgrtGorevlisis.InsertOnSubmit(drs);
                db.SubmitChanges();
                MessageBox.Show("Öğretim Gorevlisi Kaydı Tamamlandı");
                temizle();
            }
            catch (Exception e)
            {

                MessageBox.Show("Hata" + e);
            }
        }

        private void temizle()
        {
            foreach (Control ct in gbOgrtKayit.Controls) // groupbox ıcındekı  controlleri -> controllere aktar
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
            ogrtId = -1;
        }

        private void Guncelle()
        {
             try
            {
                ogrenciIsleriDataContext db = new ogrenciIsleriDataContext();
                tblOgrtGorevlisi ogrtKayit = db.tblOgrtGorevlisis.First(x => x.Id == ogrtId);
                ogrtKayit.OgrtAdi = txtOgrtAdi.Text;
                ogrtKayit.OgrtSoyadi = txtOgrtSoyadi.Text;
                ogrtKayit.DersId =  cbBolum.Text != "" ? db.tblBolums.First(x => x.BolumAdi == cbBolum.Text).Id : -1;
                db.SubmitChanges();
                MessageBox.Show("Ogretim Görevlisi Guncelleme Basarılı");
                temizle();
                Close();
                F.ogretmenKayit();
            }
            catch (Exception)
            {

                MessageBox.Show("Guncelleme Hatası");
            }
        }

        protected override void OnLoad(EventArgs e) // override -> üzerine yaz
        {
            var btnOgrt = new Button(); // yeni bir buton olusturduk
            btnOgrt.Size = new Size(25, txtOgrtAdi.ClientSize.Height + 2);
            btnOgrt.Location = new Point(txtOgrtAdi.ClientSize.Width - btnOgrt.Width, -1); //carikod un genişliğinin oldugu yere yenı buton oranın dısında olsun dıye -1 dedık farklı olsun anlamında

            btnOgrt.Cursor = Cursors.Default;
            btnOgrt.BackgroundImageLayout = ImageLayout.Stretch;
            btnOgrt.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            txtOgrtAdi.Controls.Add(btnOgrt);


            base.OnLoad(e); // initial compantten once çalısmasını saglıyor üst tarafa yazdıklarımız

            btnOgrt.Click += btnOgrt_Click;
        }

        private void btnOgrt_Click(object sender, EventArgs e)
        {
            F.ogrtListele();
            ogrtId = MainPage.IAktar;
            if (ogrtId > 0)
            {
                DersKayitAc(ogrtId);
            }
        }

        private void DersKayitAc(int ogrtId)
        {
            try
            {
                edit = true;
                ogrenciIsleriDataContext db = new ogrenciIsleriDataContext();
                tblOgrtGorevlisi drs = db.tblOgrtGorevlisis.First(x => x.Id == ogrtId);
                txtOgrtAdi.Text = drs.OgrtAdi;
                txtOgrtSoyadi.Text = drs.OgrtSoyadi;
                int? getir = drs.DersId;
                string srg = db.tblBolums.First(x => x.Id == getir).BolumAdi;
                cbBolum.Text = srg;
            }
            catch (Exception)
            {

            }

        }


        private void ogretmenKayit_Load(object sender, EventArgs e)
        {
            Combo();
        }
        void Combo()
        {
            cbBolum.ValueMember = "Id";
            cbBolum.DisplayMember = "BolumAdi";
            cbBolum.DataSource = db.tblBolums.OrderBy(x => x.BolumAdi).ToList();
            cbBolum.SelectedIndex = -1; // listenin boş gelmesini sağlıyor ilk gelen veri boş gozukuyor
        }

        private void ogretmenKayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainPage.SayfaKontrol = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (edit && ogrtId > 0 && MessageBox.Show("Seçili olan kayıt silinecektir\n Silme işlemini onaylıyormusunuz ?", "Silme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Sil();
            }
        }

        private void Sil()
        {
            db.tblOgrtGorevlisis.DeleteAllOnSubmit(db.tblOgrtGorevlisis.Where(x => x.Id == ogrtId));
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
