namespace OgrenciBilgiSistemi.Sayfalar
{
    partial class ogrenciListele
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
            this.pnlUst = new System.Windows.Forms.Panel();
            this.txtBul = new System.Windows.Forms.TextBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.liste = new System.Windows.Forms.DataGridView();
            this.OgrAdiSoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgrNumara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TcKimlik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BolumId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KayıtTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUst.SuspendLayout();
            this.pnlAlt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlUst.Controls.Add(this.txtBul);
            this.pnlUst.Controls.Add(this.btnKapat);
            this.pnlUst.Controls.Add(this.btnBul);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(899, 81);
            this.pnlUst.TabIndex = 0;
            // 
            // txtBul
            // 
            this.txtBul.Location = new System.Drawing.Point(323, 34);
            this.txtBul.Name = "txtBul";
            this.txtBul.Size = new System.Drawing.Size(246, 20);
            this.txtBul.TabIndex = 1;
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(745, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(135, 41);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(12, 23);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(135, 41);
            this.btnBul.TabIndex = 0;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // pnlAlt
            // 
            this.pnlAlt.Controls.Add(this.liste);
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAlt.Location = new System.Drawing.Point(0, 81);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(899, 369);
            this.pnlAlt.TabIndex = 1;
            // 
            // liste
            // 
            this.liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OgrAdiSoyadi,
            this.OgrNumara,
            this.TcKimlik,
            this.Email,
            this.BolumId,
            this.Adres,
            this.DogumTarihi,
            this.Resim,
            this.KayıtTarihi});
            this.liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liste.Location = new System.Drawing.Point(0, 0);
            this.liste.Name = "liste";
            this.liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.liste.Size = new System.Drawing.Size(899, 369);
            this.liste.TabIndex = 0;
            this.liste.DoubleClick += new System.EventHandler(this.liste_DoubleClick);
            // 
            // OgrAdiSoyadi
            // 
            this.OgrAdiSoyadi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.OgrAdiSoyadi.HeaderText = "Öğrenci Adı Soyadı";
            this.OgrAdiSoyadi.Name = "OgrAdiSoyadi";
            this.OgrAdiSoyadi.Width = 83;
            // 
            // OgrNumara
            // 
            this.OgrNumara.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OgrNumara.HeaderText = "Öğrenci Numarası";
            this.OgrNumara.Name = "OgrNumara";
            // 
            // TcKimlik
            // 
            this.TcKimlik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TcKimlik.HeaderText = "TC Kimlik No";
            this.TcKimlik.Name = "TcKimlik";
            this.TcKimlik.Width = 86;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 57;
            // 
            // BolumId
            // 
            this.BolumId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.BolumId.HeaderText = "Bölüm Adı";
            this.BolumId.Name = "BolumId";
            this.BolumId.Width = 73;
            // 
            // Adres
            // 
            this.Adres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Adres.HeaderText = "Adres";
            this.Adres.Name = "Adres";
            this.Adres.Width = 59;
            // 
            // DogumTarihi
            // 
            this.DogumTarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DogumTarihi.HeaderText = "DogumTarihi";
            this.DogumTarihi.Name = "DogumTarihi";
            this.DogumTarihi.Width = 92;
            // 
            // Resim
            // 
            this.Resim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Resim.HeaderText = "Resim";
            this.Resim.Name = "Resim";
            this.Resim.Visible = false;
            this.Resim.Width = 61;
            // 
            // KayıtTarihi
            // 
            this.KayıtTarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.KayıtTarihi.HeaderText = "KayıtTarihi";
            this.KayıtTarihi.Name = "KayıtTarihi";
            this.KayıtTarihi.Width = 81;
            // 
            // ogrenciListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.pnlUst);
            this.Name = "ogrenciListele";
            this.Text = "ogrenciListele";
            this.Load += new System.EventHandler(this.ogrenciListele_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            this.pnlAlt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.TextBox txtBul;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.DataGridView liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgrAdiSoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgrNumara;
        private System.Windows.Forms.DataGridViewTextBoxColumn TcKimlik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn BolumId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resim;
        private System.Windows.Forms.DataGridViewTextBoxColumn KayıtTarihi;
    }
}