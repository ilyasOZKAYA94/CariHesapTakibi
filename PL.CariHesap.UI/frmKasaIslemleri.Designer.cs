namespace PL.CariHesap.UI
{
    partial class frmKasaIslemleri
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKasaTuru = new System.Windows.Forms.TextBox();
            this.dgvHareketler = new System.Windows.Forms.DataGridView();
            this.txtDevirGiren = new System.Windows.Forms.TextBox();
            this.txtDevirCikan = new System.Windows.Forms.TextBox();
            this.txtDevirBakiye = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGirenToplam = new System.Windows.Forms.TextBox();
            this.txtCikanToplam = new System.Windows.Forms.TextBox();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.txtGiren = new System.Windows.Forms.TextBox();
            this.txtCikan = new System.Windows.Forms.TextBox();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.txtBelge = new System.Windows.Forms.TextBox();
            this.cbIslemTurleri = new System.Windows.Forms.ComboBox();
            this.txtMusteriUnvan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCariBul = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHareketler)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 53);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(752, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kasa İşlemleri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tarih";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(108, 18);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(146, 26);
            this.dtpTarih.TabIndex = 1;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kasa Türü";
            // 
            // txtKasaTuru
            // 
            this.txtKasaTuru.Location = new System.Drawing.Point(108, 54);
            this.txtKasaTuru.Name = "txtKasaTuru";
            this.txtKasaTuru.ReadOnly = true;
            this.txtKasaTuru.Size = new System.Drawing.Size(146, 26);
            this.txtKasaTuru.TabIndex = 3;
            this.txtKasaTuru.Text = "Merkez Kasa";
            this.txtKasaTuru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvHareketler
            // 
            this.dgvHareketler.AllowUserToAddRows = false;
            this.dgvHareketler.AllowUserToDeleteRows = false;
            this.dgvHareketler.BackgroundColor = System.Drawing.Color.White;
            this.dgvHareketler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHareketler.Location = new System.Drawing.Point(23, 158);
            this.dgvHareketler.Name = "dgvHareketler";
            this.dgvHareketler.ReadOnly = true;
            this.dgvHareketler.Size = new System.Drawing.Size(638, 158);
            this.dgvHareketler.TabIndex = 4;
            // 
            // txtDevirGiren
            // 
            this.txtDevirGiren.Location = new System.Drawing.Point(341, 48);
            this.txtDevirGiren.Name = "txtDevirGiren";
            this.txtDevirGiren.ReadOnly = true;
            this.txtDevirGiren.Size = new System.Drawing.Size(90, 26);
            this.txtDevirGiren.TabIndex = 5;
            this.txtDevirGiren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDevirCikan
            // 
            this.txtDevirCikan.Location = new System.Drawing.Point(431, 48);
            this.txtDevirCikan.Name = "txtDevirCikan";
            this.txtDevirCikan.ReadOnly = true;
            this.txtDevirCikan.Size = new System.Drawing.Size(90, 26);
            this.txtDevirCikan.TabIndex = 6;
            this.txtDevirCikan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDevirBakiye
            // 
            this.txtDevirBakiye.Location = new System.Drawing.Point(521, 48);
            this.txtDevirBakiye.Name = "txtDevirBakiye";
            this.txtDevirBakiye.ReadOnly = true;
            this.txtDevirBakiye.Size = new System.Drawing.Size(90, 26);
            this.txtDevirBakiye.TabIndex = 7;
            this.txtDevirBakiye.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Devirler";
            // 
            // txtGirenToplam
            // 
            this.txtGirenToplam.Location = new System.Drawing.Point(431, 322);
            this.txtGirenToplam.Name = "txtGirenToplam";
            this.txtGirenToplam.ReadOnly = true;
            this.txtGirenToplam.Size = new System.Drawing.Size(90, 26);
            this.txtGirenToplam.TabIndex = 9;
            this.txtGirenToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCikanToplam
            // 
            this.txtCikanToplam.Location = new System.Drawing.Point(522, 322);
            this.txtCikanToplam.Name = "txtCikanToplam";
            this.txtCikanToplam.ReadOnly = true;
            this.txtCikanToplam.Size = new System.Drawing.Size(90, 26);
            this.txtCikanToplam.TabIndex = 10;
            this.txtCikanToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(613, 322);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(72, 26);
            this.txtBakiye.TabIndex = 11;
            this.txtBakiye.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGiren
            // 
            this.txtGiren.Location = new System.Drawing.Point(431, 126);
            this.txtGiren.Name = "txtGiren";
            this.txtGiren.Size = new System.Drawing.Size(90, 26);
            this.txtGiren.TabIndex = 12;
            this.txtGiren.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCikan
            // 
            this.txtCikan.Location = new System.Drawing.Point(521, 126);
            this.txtCikan.Name = "txtCikan";
            this.txtCikan.Size = new System.Drawing.Size(90, 26);
            this.txtCikan.TabIndex = 13;
            this.txtCikan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(611, 126);
            this.txtPara.Name = "txtPara";
            this.txtPara.ReadOnly = true;
            this.txtPara.Size = new System.Drawing.Size(50, 26);
            this.txtPara.TabIndex = 14;
            this.txtPara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBelge
            // 
            this.txtBelge.Location = new System.Drawing.Point(282, 126);
            this.txtBelge.Name = "txtBelge";
            this.txtBelge.Size = new System.Drawing.Size(149, 26);
            this.txtBelge.TabIndex = 15;
            // 
            // cbIslemTurleri
            // 
            this.cbIslemTurleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIslemTurleri.FormattingEnabled = true;
            this.cbIslemTurleri.Items.AddRange(new object[] {
            "Tahsilat",
            "Ödeme"});
            this.cbIslemTurleri.Location = new System.Drawing.Point(30, 124);
            this.cbIslemTurleri.Name = "cbIslemTurleri";
            this.cbIslemTurleri.Size = new System.Drawing.Size(99, 28);
            this.cbIslemTurleri.TabIndex = 16;
            this.cbIslemTurleri.SelectedIndexChanged += new System.EventHandler(this.cbIslemTurleri_SelectedIndexChanged);
            // 
            // txtMusteriUnvan
            // 
            this.txtMusteriUnvan.Location = new System.Drawing.Point(130, 126);
            this.txtMusteriUnvan.Name = "txtMusteriUnvan";
            this.txtMusteriUnvan.ReadOnly = true;
            this.txtMusteriUnvan.Size = new System.Drawing.Size(152, 26);
            this.txtMusteriUnvan.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "İşlem Türü";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Müşteri Ünvan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Belge";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(453, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Giren";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(539, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Çıkan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(600, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Para Brm";
            // 
            // btnCariBul
            // 
            this.btnCariBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCariBul.Location = new System.Drawing.Point(245, 98);
            this.btnCariBul.Name = "btnCariBul";
            this.btnCariBul.Size = new System.Drawing.Size(37, 27);
            this.btnCariBul.TabIndex = 24;
            this.btnCariBul.Text = "...";
            this.btnCariBul.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnYeni);
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Controls.Add(this.btnDegistir);
            this.panel2.Controls.Add(this.btnKaydet);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btnCariBul);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtMusteriUnvan);
            this.panel2.Controls.Add(this.cbIslemTurleri);
            this.panel2.Controls.Add(this.txtBelge);
            this.panel2.Controls.Add(this.txtPara);
            this.panel2.Controls.Add(this.txtCikan);
            this.panel2.Controls.Add(this.txtGiren);
            this.panel2.Controls.Add(this.txtBakiye);
            this.panel2.Controls.Add(this.txtCikanToplam);
            this.panel2.Controls.Add(this.txtGirenToplam);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtDevirBakiye);
            this.panel2.Controls.Add(this.txtDevirCikan);
            this.panel2.Controls.Add(this.txtDevirGiren);
            this.panel2.Controls.Add(this.dgvHareketler);
            this.panel2.Controls.Add(this.txtKasaTuru);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dtpTarih);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(752, 376);
            this.panel2.TabIndex = 3;
            // 
            // btnYeni
            // 
            this.btnYeni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnYeni.BackColor = System.Drawing.Color.Black;
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeni.ForeColor = System.Drawing.Color.White;
            this.btnYeni.Location = new System.Drawing.Point(27, 321);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(81, 29);
            this.btnYeni.TabIndex = 47;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSil.BackColor = System.Drawing.Color.Black;
            this.btnSil.Enabled = false;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(270, 321);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(81, 29);
            this.btnSil.TabIndex = 46;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDegistir.BackColor = System.Drawing.Color.Black;
            this.btnDegistir.Enabled = false;
            this.btnDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDegistir.ForeColor = System.Drawing.Color.White;
            this.btnDegistir.Location = new System.Drawing.Point(189, 321);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(81, 29);
            this.btnDegistir.TabIndex = 45;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKaydet.BackColor = System.Drawing.Color.Black;
            this.btnKaydet.Enabled = false;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(108, 321);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(81, 29);
            this.btnKaydet.TabIndex = 44;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(354, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Toplamlar";
            // 
            // frmKasaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 453);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKasaIslemleri";
            this.Text = "frmKasaIslemleri";
            this.Load += new System.EventHandler(this.frmKasaIslemleri_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHareketler)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKasaTuru;
        private System.Windows.Forms.DataGridView dgvHareketler;
        private System.Windows.Forms.TextBox txtDevirGiren;
        private System.Windows.Forms.TextBox txtDevirCikan;
        private System.Windows.Forms.TextBox txtDevirBakiye;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGirenToplam;
        private System.Windows.Forms.TextBox txtCikanToplam;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.TextBox txtGiren;
        private System.Windows.Forms.TextBox txtCikan;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.TextBox txtBelge;
        private System.Windows.Forms.ComboBox cbIslemTurleri;
        private System.Windows.Forms.TextBox txtMusteriUnvan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCariBul;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnKaydet;
    }
}