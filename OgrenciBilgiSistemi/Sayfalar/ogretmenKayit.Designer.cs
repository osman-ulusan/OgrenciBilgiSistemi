namespace OgrenciBilgiSistemi.Sayfalar
{
    partial class ogretmenKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbOgrtKayit = new System.Windows.Forms.GroupBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cbBolum = new System.Windows.Forms.ComboBox();
            this.txtOgrtAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtOgrtSoyadi = new System.Windows.Forms.TextBox();
            this.gbOgrtKayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOgrtKayit
            // 
            this.gbOgrtKayit.Controls.Add(this.btnKapat);
            this.gbOgrtKayit.Controls.Add(this.btnSil);
            this.gbOgrtKayit.Controls.Add(this.btnKaydet);
            this.gbOgrtKayit.Controls.Add(this.cbBolum);
            this.gbOgrtKayit.Controls.Add(this.txtOgrtSoyadi);
            this.gbOgrtKayit.Controls.Add(this.txtOgrtAdi);
            this.gbOgrtKayit.Controls.Add(this.label3);
            this.gbOgrtKayit.Controls.Add(this.label2);
            this.gbOgrtKayit.Controls.Add(this.label1);
            this.gbOgrtKayit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOgrtKayit.Location = new System.Drawing.Point(0, 0);
            this.gbOgrtKayit.Name = "gbOgrtKayit";
            this.gbOgrtKayit.Size = new System.Drawing.Size(800, 450);
            this.gbOgrtKayit.TabIndex = 1;
            this.gbOgrtKayit.TabStop = false;
            this.gbOgrtKayit.Text = "Öğretim Gorevlisi Kayıt";
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(549, 196);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(151, 52);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(320, 196);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(151, 52);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(79, 196);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(151, 52);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cbBolum
            // 
            this.cbBolum.FormattingEnabled = true;
            this.cbBolum.Location = new System.Drawing.Point(194, 129);
            this.cbBolum.Name = "cbBolum";
            this.cbBolum.Size = new System.Drawing.Size(128, 21);
            this.cbBolum.TabIndex = 2;
            // 
            // txtOgrtAdi
            // 
            this.txtOgrtAdi.Location = new System.Drawing.Point(194, 44);
            this.txtOgrtAdi.Name = "txtOgrtAdi";
            this.txtOgrtAdi.Size = new System.Drawing.Size(128, 20);
            this.txtOgrtAdi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(38, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ö.Grv Bölümü:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ö.Görevlisi Soyadı:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ö.Görevlisi Adı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtOgrtSoyadi
            // 
            this.txtOgrtSoyadi.Location = new System.Drawing.Point(194, 86);
            this.txtOgrtSoyadi.Name = "txtOgrtSoyadi";
            this.txtOgrtSoyadi.Size = new System.Drawing.Size(128, 20);
            this.txtOgrtSoyadi.TabIndex = 1;
            // 
            // ogretmenKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbOgrtKayit);
            this.Name = "ogretmenKayit";
            this.Text = "ogretmenKayit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ogretmenKayit_FormClosing);
            this.Load += new System.EventHandler(this.ogretmenKayit_Load);
            this.gbOgrtKayit.ResumeLayout(false);
            this.gbOgrtKayit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOgrtKayit;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cbBolum;
        private System.Windows.Forms.TextBox txtOgrtAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtOgrtSoyadi;
    }
}