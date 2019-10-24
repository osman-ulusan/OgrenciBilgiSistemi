namespace OgrenciBilgiSistemi.Sayfalar
{
    partial class dersListele
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
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DersAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BolumId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgrtAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUst.SuspendLayout();
            this.pnlAlt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlUst.Controls.Add(this.txtBul);
            this.pnlUst.Controls.Add(this.btnKapat);
            this.pnlUst.Controls.Add(this.btnBul);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1067, 123);
            this.pnlUst.TabIndex = 0;
            // 
            // txtBul
            // 
            this.txtBul.Location = new System.Drawing.Point(313, 44);
            this.txtBul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBul.Name = "txtBul";
            this.txtBul.Size = new System.Drawing.Size(397, 22);
            this.txtBul.TabIndex = 1;
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.Location = new System.Drawing.Point(919, 0);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(148, 123);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnBul
            // 
            this.btnBul.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBul.Location = new System.Drawing.Point(0, 0);
            this.btnBul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(127, 123);
            this.btnBul.TabIndex = 0;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // pnlAlt
            // 
            this.pnlAlt.Controls.Add(this.liste);
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAlt.Location = new System.Drawing.Point(0, 123);
            this.pnlAlt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(1067, 431);
            this.pnlAlt.TabIndex = 1;
            // 
            // liste
            // 
            this.liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DersAdi,
            this.BolumId,
            this.OgrtAdi});
            this.liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liste.Location = new System.Drawing.Point(0, 0);
            this.liste.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(1067, 431);
            this.liste.TabIndex = 0;
            this.liste.DoubleClick += new System.EventHandler(this.liste_DoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // DersAdi
            // 
            this.DersAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DersAdi.HeaderText = "Ders Adı";
            this.DersAdi.Name = "DersAdi";
            // 
            // BolumId
            // 
            this.BolumId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.BolumId.HeaderText = "Bolum Adı";
            this.BolumId.Name = "BolumId";
            // 
            // OgrtAdi
            // 
            this.OgrtAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.OgrtAdi.HeaderText = "Öğretim Görevlisi";
            this.OgrtAdi.Name = "OgrtAdi";
            this.OgrtAdi.Width = 134;
            // 
            // dersListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.pnlUst);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "dersListele";
            this.Text = "dersListele";
            this.Load += new System.EventHandler(this.dersListele_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            this.pnlAlt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.DataGridView liste;
        private System.Windows.Forms.TextBox txtBul;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DersAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BolumId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgrtAdi;
    }
}