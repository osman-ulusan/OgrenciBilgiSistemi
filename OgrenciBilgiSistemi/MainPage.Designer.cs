namespace OgrenciBilgiSistemi
{
    partial class MainPage
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
            this.btnOgrenciKayıt = new System.Windows.Forms.Button();
            this.btnDersKayıt = new System.Windows.Forms.Button();
            this.btnDersSecim = new System.Windows.Forms.Button();
            this.btnOgrtKayit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAktif = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOgrenciKayıt
            // 
            this.btnOgrenciKayıt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOgrenciKayıt.BackColor = System.Drawing.Color.Transparent;
            this.btnOgrenciKayıt.BackgroundImage = global::OgrenciBilgiSistemi.Properties.Resources.ogrenciKayit2;
            this.btnOgrenciKayıt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOgrenciKayıt.Location = new System.Drawing.Point(18, 12);
            this.btnOgrenciKayıt.Name = "btnOgrenciKayıt";
            this.btnOgrenciKayıt.Size = new System.Drawing.Size(124, 87);
            this.btnOgrenciKayıt.TabIndex = 0;
            this.btnOgrenciKayıt.UseVisualStyleBackColor = false;
            this.btnOgrenciKayıt.Click += new System.EventHandler(this.btnOgrenciKayıt_Click);
            // 
            // btnDersKayıt
            // 
            this.btnDersKayıt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDersKayıt.BackColor = System.Drawing.Color.Transparent;
            this.btnDersKayıt.BackgroundImage = global::OgrenciBilgiSistemi.Properties.Resources.dersSecim;
            this.btnDersKayıt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDersKayıt.Location = new System.Drawing.Point(18, 114);
            this.btnDersKayıt.Name = "btnDersKayıt";
            this.btnDersKayıt.Size = new System.Drawing.Size(124, 78);
            this.btnDersKayıt.TabIndex = 0;
            this.btnDersKayıt.UseVisualStyleBackColor = false;
            this.btnDersKayıt.Click += new System.EventHandler(this.btnDersKayıt_Click);
            // 
            // btnDersSecim
            // 
            this.btnDersSecim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDersSecim.BackColor = System.Drawing.Color.Transparent;
            this.btnDersSecim.BackgroundImage = global::OgrenciBilgiSistemi.Properties.Resources.dersKayıt;
            this.btnDersSecim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDersSecim.Location = new System.Drawing.Point(18, 207);
            this.btnDersSecim.Name = "btnDersSecim";
            this.btnDersSecim.Size = new System.Drawing.Size(124, 75);
            this.btnDersSecim.TabIndex = 0;
            this.btnDersSecim.UseVisualStyleBackColor = false;
            this.btnDersSecim.Click += new System.EventHandler(this.btnDersSecim_Click_1);
            // 
            // btnOgrtKayit
            // 
            this.btnOgrtKayit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOgrtKayit.BackColor = System.Drawing.Color.Transparent;
            this.btnOgrtKayit.BackgroundImage = global::OgrenciBilgiSistemi.Properties.Resources.ogretımGorevlisi2;
            this.btnOgrtKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOgrtKayit.Location = new System.Drawing.Point(18, 301);
            this.btnOgrtKayit.Name = "btnOgrtKayit";
            this.btnOgrtKayit.Size = new System.Drawing.Size(124, 78);
            this.btnOgrtKayit.TabIndex = 0;
            this.btnOgrtKayit.UseVisualStyleBackColor = false;
            this.btnOgrtKayit.Click += new System.EventHandler(this.btnOgrtKayit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOgrenciKayıt);
            this.panel1.Controls.Add(this.btnOgrtKayit);
            this.panel1.Controls.Add(this.btnDersKayıt);
            this.panel1.Controls.Add(this.btnDersSecim);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 407);
            this.panel1.TabIndex = 1;
            // 
            // lblAktif
            // 
            this.lblAktif.Location = new System.Drawing.Point(191, 24);
            this.lblAktif.Name = "lblAktif";
            this.lblAktif.Size = new System.Drawing.Size(147, 17);
            this.lblAktif.TabIndex = 3;
            this.lblAktif.Text = "label1";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OgrenciBilgiSistemi.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 407);
            this.Controls.Add(this.lblAktif);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "MainPage";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenciKayıt;
        private System.Windows.Forms.Button btnDersKayıt;
        private System.Windows.Forms.Button btnDersSecim;
        private System.Windows.Forms.Button btnOgrtKayit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAktif;
    }
}

