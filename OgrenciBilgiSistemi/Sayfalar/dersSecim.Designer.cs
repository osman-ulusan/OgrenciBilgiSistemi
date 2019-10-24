namespace OgrenciBilgiSistemi.Sayfalar
{
    partial class dersSecim
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
            this.gbDersSecim = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cbBolumAdi = new System.Windows.Forms.ComboBox();
            this.txtOgrNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secim = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DersAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgrtAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.liste2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDersSecim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liste2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDersSecim
            // 
            this.gbDersSecim.Controls.Add(this.btnSil);
            this.gbDersSecim.Controls.Add(this.btnKaydet);
            this.gbDersSecim.Controls.Add(this.cbBolumAdi);
            this.gbDersSecim.Controls.Add(this.txtOgrNo);
            this.gbDersSecim.Controls.Add(this.label2);
            this.gbDersSecim.Controls.Add(this.label3);
            this.gbDersSecim.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDersSecim.Location = new System.Drawing.Point(0, 0);
            this.gbDersSecim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDersSecim.Name = "gbDersSecim";
            this.gbDersSecim.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDersSecim.Size = new System.Drawing.Size(1053, 171);
            this.gbDersSecim.TabIndex = 0;
            this.gbDersSecim.TabStop = false;
            this.gbDersSecim.Text = "Ders Seçim";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(1022, 45);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(10, 78);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Seçili Dersi Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(680, 45);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(196, 78);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cbBolumAdi
            // 
            this.cbBolumAdi.FormattingEnabled = true;
            this.cbBolumAdi.Location = new System.Drawing.Point(147, 103);
            this.cbBolumAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBolumAdi.Name = "cbBolumAdi";
            this.cbBolumAdi.Size = new System.Drawing.Size(139, 24);
            this.cbBolumAdi.TabIndex = 2;
            this.cbBolumAdi.SelectedIndexChanged += new System.EventHandler(this.cbBolumAdi_SelectedIndexChanged);
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.Location = new System.Drawing.Point(147, 60);
            this.txtOgrNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.ReadOnly = true;
            this.txtOgrNo.Size = new System.Drawing.Size(205, 22);
            this.txtOgrNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bölüm Adi:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Öğrenci No:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // liste
            // 
            this.liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.secim,
            this.DersAdi,
            this.OgrtAdi});
            this.liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liste.Location = new System.Drawing.Point(0, 0);
            this.liste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.liste.Name = "liste";
            this.liste.RowTemplate.Height = 24;
            this.liste.Size = new System.Drawing.Size(1053, 430);
            this.liste.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 48;
            // 
            // secim
            // 
            this.secim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.secim.HeaderText = "secim";
            this.secim.Name = "secim";
            this.secim.Width = 50;
            // 
            // DersAdi
            // 
            this.DersAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DersAdi.HeaderText = "DersAdi";
            this.DersAdi.Name = "DersAdi";
            // 
            // OgrtAdi
            // 
            this.OgrtAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.OgrtAdi.HeaderText = "Ogretmen Adi";
            this.OgrtAdi.Name = "OgrtAdi";
            this.OgrtAdi.Width = 114;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.liste);
            this.panel1.Controls.Add(this.liste2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 171);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 430);
            this.panel1.TabIndex = 1;
            // 
            // liste2
            // 
            this.liste2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.liste2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liste2.Location = new System.Drawing.Point(0, 0);
            this.liste2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.liste2.Name = "liste2";
            this.liste2.RowTemplate.Height = 24;
            this.liste2.Size = new System.Drawing.Size(1053, 430);
            this.liste2.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 48;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewCheckBoxColumn1.HeaderText = "secim2";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 58;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "DersAdi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Ogretmen Adi";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 114;
            // 
            // dersSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 601);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbDersSecim);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "dersSecim";
            this.Text = "dersSecim";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dersSecim_FormClosing);
            this.Load += new System.EventHandler(this.dersSecim_Load);
            this.gbDersSecim.ResumeLayout(false);
            this.gbDersSecim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.liste2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDersSecim;
        private System.Windows.Forms.DataGridView liste;
        private System.Windows.Forms.ComboBox cbBolumAdi;
        private System.Windows.Forms.TextBox txtOgrNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn secim;
        private System.Windows.Forms.DataGridViewTextBoxColumn DersAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgrtAdi;
        private System.Windows.Forms.DataGridView liste2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnSil;
    }
}