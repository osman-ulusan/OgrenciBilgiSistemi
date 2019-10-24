namespace OgrenciBilgiSistemi.Sayfalar
{
    partial class dersKayit
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
            this.gbDersKayit = new System.Windows.Forms.GroupBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cbOgretmen = new System.Windows.Forms.ComboBox();
            this.cbBolumAdi = new System.Windows.Forms.ComboBox();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbDersKayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDersKayit
            // 
            this.gbDersKayit.Controls.Add(this.btnKapat);
            this.gbDersKayit.Controls.Add(this.btnSil);
            this.gbDersKayit.Controls.Add(this.btnKaydet);
            this.gbDersKayit.Controls.Add(this.cbOgretmen);
            this.gbDersKayit.Controls.Add(this.cbBolumAdi);
            this.gbDersKayit.Controls.Add(this.txtDersAdi);
            this.gbDersKayit.Controls.Add(this.label3);
            this.gbDersKayit.Controls.Add(this.label2);
            this.gbDersKayit.Controls.Add(this.label1);
            this.gbDersKayit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDersKayit.Location = new System.Drawing.Point(0, 0);
            this.gbDersKayit.Name = "gbDersKayit";
            this.gbDersKayit.Size = new System.Drawing.Size(820, 460);
            this.gbDersKayit.TabIndex = 0;
            this.gbDersKayit.TabStop = false;
            this.gbDersKayit.Text = "Ders Kayıt";
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
            // cbOgretmen
            // 
            this.cbOgretmen.FormattingEnabled = true;
            this.cbOgretmen.Location = new System.Drawing.Point(194, 129);
            this.cbOgretmen.Name = "cbOgretmen";
            this.cbOgretmen.Size = new System.Drawing.Size(128, 21);
            this.cbOgretmen.TabIndex = 2;
            // 
            // cbBolumAdi
            // 
            this.cbBolumAdi.FormattingEnabled = true;
            this.cbBolumAdi.Location = new System.Drawing.Point(194, 86);
            this.cbBolumAdi.Name = "cbBolumAdi";
            this.cbBolumAdi.Size = new System.Drawing.Size(128, 21);
            this.cbBolumAdi.TabIndex = 2;
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Location = new System.Drawing.Point(194, 44);
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(128, 20);
            this.txtDersAdi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(38, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Öğretmen Adı";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(38, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bölüm Adı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders Adı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dersKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 460);
            this.Controls.Add(this.gbDersKayit);
            this.Name = "dersKayit";
            this.Text = "dersKayit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dersKayit_FormClosing);
            this.Load += new System.EventHandler(this.dersKayit_Load);
            this.gbDersKayit.ResumeLayout(false);
            this.gbDersKayit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDersKayit;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cbBolumAdi;
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.ComboBox cbOgretmen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}