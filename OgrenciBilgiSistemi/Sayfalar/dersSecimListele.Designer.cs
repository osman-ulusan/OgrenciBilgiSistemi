namespace OgrenciBilgiSistemi.Sayfalar
{
    partial class dersSecimListele
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
            this.liste = new System.Windows.Forms.DataGridView();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.btnExcel = new System.Windows.Forms.Button();
            this.txtBul = new System.Windows.Forms.TextBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgrId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DersId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BolumId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            this.pnlUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // liste
            // 
            this.liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.OgrId,
            this.DersId,
            this.BolumId});
            this.liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.liste.Location = new System.Drawing.Point(0, 87);
            this.liste.Name = "liste";
            this.liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.liste.Size = new System.Drawing.Size(896, 369);
            this.liste.TabIndex = 1;
            this.liste.DoubleClick += new System.EventHandler(this.liste_DoubleClick);
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlUst.Controls.Add(this.btnExcel);
            this.pnlUst.Controls.Add(this.txtBul);
            this.pnlUst.Controls.Add(this.btnKapat);
            this.pnlUst.Controls.Add(this.btnBul);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(896, 87);
            this.pnlUst.TabIndex = 2;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(583, 23);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(142, 41);
            this.btnExcel.TabIndex = 2;
            this.btnExcel.Text = "Ders Programını İndir";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // txtBul
            // 
            this.txtBul.Location = new System.Drawing.Point(234, 34);
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
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 41;
            // 
            // OgrId
            // 
            this.OgrId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.OgrId.HeaderText = "Ogrenci Adi";
            this.OgrId.Name = "OgrId";
            this.OgrId.Width = 87;
            // 
            // DersId
            // 
            this.DersId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DersId.HeaderText = "Ders Adı";
            this.DersId.Name = "DersId";
            // 
            // BolumId
            // 
            this.BolumId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.BolumId.HeaderText = "Öğretmen Adi";
            this.BolumId.Name = "BolumId";
            this.BolumId.Width = 96;
            // 
            // dersSecimListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 456);
            this.Controls.Add(this.pnlUst);
            this.Controls.Add(this.liste);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "dersSecimListele";
            this.Text = "dersSecimListele";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dersSecimListele_FormClosing);
            this.Load += new System.EventHandler(this.dersSecimListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.liste)).EndInit();
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView liste;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.TextBox txtBul;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgrId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DersId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BolumId;
    }
}