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
    public partial class dersSecim : Form
    {
        ogrenciIsleriDataContext db = new ogrenciIsleriDataContext();
        Formlar F = new Formlar();
        int secimId = -1;
        bool edit = true;
        bool sEdit = false;
        bool sonuc;
        public dersSecim()
        {
            InitializeComponent();
        }

        private void dersSecim_Load(object sender, EventArgs e)
        {
            Combo();
            OgrNoGel();
        }
        private void OgrNoGel()
        {
            int girisKimYaptı = MainPage.IAktar;
            string adiBul = MainPage.sAktar;
            int ogrenci = db.tblOgrencis.First(x => x.OgrNumara == adiBul).Id;
            txtOgrNo.Text = ogrenci.ToString();
        }
        private void Combo()
        {
            OgrNoGel();
            int gel = int.Parse(txtOgrNo.Text);
            string tut = db.tblOgrencis.First(x => x.Id == gel).BolumId.ToString();
            int cek = int.Parse(tut);
            cbBolumAdi.DataSource = db.tblBolums.Where(x => x.Id == cek).ToList(); /*db.tblBolums.ToList();*/
            cbBolumAdi.ValueMember = "Id";
            cbBolumAdi.DisplayMember = "BolumAdi";
            //cbBolumAdi.SelectedIndex = -1; // listenin boş gelmesini sağlıyor ilk gelen veri boş gozukuyor
        }

        private void dersSecim_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainPage.SayfaKontrol = false;
        }

        private void cbBolumAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            liste.Rows.Clear();
            int secilenid = (cbBolumAdi.SelectedItem as tblBolum).Id;

            var lst = (from i in db.tblDersKayits
                       where i.BolumId == secilenid
                       select i).ToList();


            int r = 0;
            foreach (var k in lst)
            {
                liste.Rows.Add();
                liste.Rows[r].Cells[2].Value = k.DersAdi;
                liste.Rows[r].Cells[3].Value = k.tblOgrtGorevlisi.OgrtAdi;
                r++;
            }
            liste.AllowUserToAddRows = false;

            /* 2 combobox ornegi
              if (cbBolumAdi.SelectedIndex != -1)
            {
                var dersler = from i in db.tblDersKayits
                                   where i.BolumId == Convert.ToInt32(cbBolumAdi.SelectedValue)
                                   select i;
                comboBox2.ValueMember = "Id";
                comboBox2.DisplayMember = "DersAdi";
                comboBox2.DataSource = dersler;
            }
            */

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (edit && MessageBox.Show("Seçimleriniz kaydedilecektir \n Kayıt işlemini onaylıyormusunuz ?", "Kayıt işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Kaydet();
            }
            else if (sEdit && MessageBox.Show("Seçili olan kayıt silinecektir\n Silme işlemini onaylıyormusunuz ?", "Silme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Sil();
            }
        }
        //private string mukerrer()
        private void mukerrer(int ogrId, int DersId)
        {
            ogrenciIsleriDataContext vb = new ogrenciIsleriDataContext();
            var kayitVarmi = (from p in vb.tblDersSecims where p.OgrId == ogrId && p.DersId == DersId select p).ToList();
            if (kayitVarmi.Count > 0)
            {
                sonuc = false;
            }
            else
            {
                sonuc = true;
            }
        }
        private void Kaydet()
        {
            int say = 0;
            string str = "";
            string eklenen = "";
            liste.AllowUserToAddRows = false; // boş satır eklemini engelliyor yoksa hataya dusuyoruz boş satırıda kaydetmeye kalkıyor
            try
            {
                ogrenciIsleriDataContext gb = new ogrenciIsleriDataContext();

                tblDersSecim[] alt = new tblDersSecim[liste.RowCount]; // datagridden veriler geleceği için array tanımladık

                for (int i = 0; i < liste.RowCount; i++) // datagrid deki verileri tek tek okuyarak listeden kaydediyoruz oyuzden i'nci değeri tanımladık.
                {
                    int blmId = gb.tblBolums.First(x => x.BolumAdi == cbBolumAdi.Text).Id;
                    int drsId = gb.tblDersKayits.First(x => x.DersAdi == liste.Rows[i].Cells[2].Value.ToString()).Id;

                    bool isChecked = Convert.ToBoolean(liste.Rows[i].Cells["secim"].Value);

                    int ogrId = int.Parse(txtOgrNo.Text);
                    int DersId = gb.tblDersKayits.First(x => x.DersAdi == liste.Rows[i].Cells[2].Value.ToString()).Id;

                    mukerrer(ogrId, DersId);

                    if (isChecked == true && sonuc == true)
                    {
                        alt[i] = new tblDersSecim();
                        alt[i].BolumId = cbBolumAdi.Text != "" ? blmId : -1;
                        alt[i].DersId = liste.Rows[i].Cells[2].Value.ToString() != "" ? drsId : -1;
                        alt[i].OgrId = int.Parse(txtOgrNo.Text);
                        gb.tblDersSecims.InsertOnSubmit(alt[i]); //kaydediyorz
                        gb.SubmitChanges();

                        eklenen += liste.Rows[i].Cells[2].Value.ToString() + " ";

                    }
                    else if (isChecked == true && sonuc == false)
                    {
                        str += liste.Rows[i].Cells[2].Value.ToString() + " ";
                    }

                }
                if (!string.IsNullOrEmpty(str))
                {
                    if (!string.IsNullOrEmpty(eklenen))
                    {
                        MessageBox.Show("Seçimleriniz Alındı \n " + eklenen + " Adlı Derlsler Eklendi, \n" + str + " Adlı Dersler Zaten Var oldugundan tekrar eklenmedi!!!");
                    }
                    else
                    {
                        MessageBox.Show(str + " Adlı Dersler Zaten Var oldugundan tekrar eklenmedi!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Seçimleriniz Alındı");
                }
                //MessageBox.Show("secımler var zaten.com");
                //veritabınında tum isleri halledecek kaydedecek en sonunda

            }
            catch (Exception)
            {

                MessageBox.Show("Hata Seçim Alınamadı");
            }
        }

        protected override void OnLoad(EventArgs e) // override -> üzerine yaz
        {
            var btnDersSecim = new Button(); // yeni bir buton olusturduk
            btnDersSecim.Size = new Size(25, txtOgrNo.ClientSize.Height + 2);
            btnDersSecim.Location = new Point(txtOgrNo.ClientSize.Width - btnDersSecim.Width, -1); //carikod un genişliğinin oldugu yere yenı buton oranın dısında olsun dıye -1 dedık farklı olsun anlamında

            btnDersSecim.Cursor = Cursors.Default;
            btnDersSecim.BackgroundImageLayout = ImageLayout.Stretch;
            btnDersSecim.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            txtOgrNo.Controls.Add(btnDersSecim);


            base.OnLoad(e); // initial compantten once çalısmasını saglıyor üst tarafa yazdıklarımız

            btnDersSecim.Click += btnDersSecim_Click;
        }

        private void btnDersSecim_Click(object sender, EventArgs e)
        {
            MainPage.IAktar = int.Parse(txtOgrNo.Text);
            F.dersSecimListele();
            secimId = MainPage.IAktar;
            if (secimId > 0)
            {
                DersSecimAc(secimId);
            }
        }

        private void DersSecimAc(int de)
        {
            liste.AllowUserToAddRows = false;
            try
            {
                edit = true;
                ogrenciIsleriDataContext db = new ogrenciIsleriDataContext();
                tblDersSecim drs = db.tblDersSecims.First(x => x.Id == secimId);
                liste.Visible = false;
                liste2.Visible = true;
                sEdit = true;
                edit = false;
                txtOgrNo.Text = drs.OgrId.ToString();
                cbBolumAdi.Text = drs.tblBolum.BolumAdi;
                btnKaydet.Text = "Sil";
                liste2.Rows[0].Cells[0].Value = drs.Id; // yeni bir liste2 adında dgridw açtım ki otomatik doldurmadan kaçalım diye. (seçilen ders gelsin sadece işlem için)
                liste2.Rows[0].Cells[2].Value = drs.tblDersKayit.DersAdi.ToString();
                liste2.Rows[0].Cells[3].Value = drs.tblDersKayit.tblOgrtGorevlisi.OgrtAdi;
            }
            catch (Exception)
            {
                //MessageBox.Show("Geri Getirme Hata Ders Secim Ac");

            }

        }

        private void temizle()
        {
            foreach (Control ct in liste.Controls) // groupbox ıcındekı  controlleri -> controllere aktar
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
            secimId = -1;
        }

        private void Sil()
        {
            liste2.AllowUserToAddRows = false;
            try
            {
                int silinenId = int.Parse(liste2.Rows[0].Cells[0].Value.ToString());
                bool isChecked = Convert.ToBoolean(liste2.Rows[0].Cells[1].Value);
                if (isChecked == true)
                {
                    db.tblDersSecims.DeleteAllOnSubmit(db.tblDersSecims.Where(x => x.Id == silinenId));
                    db.SubmitChanges(); //veritabınında tum isleri halledecek kaydedecek en sonunda
                    MessageBox.Show("Silme İşlemi Başarılı");
                    liste2.Visible = false;
                    liste.Visible = true;
                    sEdit = false;
                    edit = true;
                    btnKaydet.Text = "Kaydet";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Silme İşlemi Yapılamadı / Lutfen Secim Yapınız");
            }


        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            /*if (secimId > 0 && MessageBox.Show("Seçili olan kayıt silinecektir\n Silme işlemini onaylıyormusunuz ?", "Silme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Sil();
            }*/
        }
    }
}
