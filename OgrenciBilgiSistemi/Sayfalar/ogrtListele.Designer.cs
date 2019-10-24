namespace OgrenciBilgiSistemi.Sayfalar
{
    partial class ogrtListele
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
            this.ogrtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgrtAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgrtSoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrtBolum = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pnlUst.Size = new System.Drawing.Size(898, 87);
            this.pnlUst.TabIndex = 2;
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
            this.pnlAlt.Location = new System.Drawing.Point(0, 0);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(898, 450);
            this.pnlAlt.TabIndex = 3;
            // 
            // liste
            // 
            this.liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrtId,
            this.OgrtAdi,
            this.OgrtSoyadi,
            this.ogrtBolum});
            this.liste.Location = new System.Drawing.Point(0, 87);
            this.liste.Name = "liste";
            this.liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.liste.Size = new System.Drawing.Size(899, 363);
            this.liste.TabIndex = 0;
            this.liste.DoubleClick += new System.EventHandler(this.liste_DoubleClick);
            // 
            // ogrtId
            // 
            this.ogrtId.HeaderText = "Id";
            this.ogrtId.Name = "ogrtId";
            // 
            // OgrtAdi
            // 
            this.OgrtAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OgrtAdi.HeaderText = "Öğretim Görevlisi Adi";
            this.OgrtAdi.Name = "OgrtAdi";
            // 
            // OgrtSoyadi
            // 
            this.OgrtSoyadi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OgrtSoyadi.HeaderText = "Öğretim Görevlisi Soyadi";
            this.OgrtSoyadi.Name = "OgrtSoyadi";
            // 
            // ogrtBolum
            // 
            this.ogrtBolum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ogrtBolum.HeaderText = "Bölüm Adı";
            this.ogrtBolum.Name = "ogrtBolum";
            this.ogrtBolum.Width = 79;
            // 
            // ogrtListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.pnlUst);
            this.Controls.Add(this.pnlAlt);
            this.Name = "ogrtListele";
            this.Text = "ogrtListele";
            this.Load += new System.EventHandler(this.ogrtListele_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgrtAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgrtSoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrtBolum;
    }
}