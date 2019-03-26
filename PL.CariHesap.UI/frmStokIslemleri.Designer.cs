namespace PL.CariHesap.UI
{
    partial class frmStokIslemleri
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpUrunler = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYeni = new System.Windows.Forms.Button();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cbKategoriler = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.txtKritikSeviye = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.tpStok = new System.Windows.Forms.TabPage();
            this.tpSorgulama = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpUrunler.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 56);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(817, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stok İşlemleri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 463);
            this.panel2.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpUrunler);
            this.tabControl1.Controls.Add(this.tpStok);
            this.tabControl1.Controls.Add(this.tpSorgulama);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(817, 344);
            this.tabControl1.TabIndex = 0;
            // 
            // tpUrunler
            // 
            this.tpUrunler.Controls.Add(this.panel3);
            this.tpUrunler.Location = new System.Drawing.Point(4, 29);
            this.tpUrunler.Name = "tpUrunler";
            this.tpUrunler.Padding = new System.Windows.Forms.Padding(3);
            this.tpUrunler.Size = new System.Drawing.Size(809, 311);
            this.tpUrunler.TabIndex = 0;
            this.tpUrunler.Text = "Ürün Kartları";
            this.tpUrunler.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(806, 305);
            this.panel3.TabIndex = 55;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.txtFiyat);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.btnYeni);
            this.panel5.Controls.Add(this.txtUrunAdi);
            this.panel5.Controls.Add(this.btnSil);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.btnDegistir);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.btnKaydet);
            this.panel5.Controls.Add(this.cbKategoriler);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtKategori);
            this.panel5.Controls.Add(this.txtKritikSeviye);
            this.panel5.Controls.Add(this.txtMiktar);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(16, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(288, 214);
            this.panel5.TabIndex = 66;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiyat.Location = new System.Drawing.Point(99, 75);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(165, 23);
            this.txtFiyat.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Fiyat";
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.Black;
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYeni.ForeColor = System.Drawing.Color.White;
            this.btnYeni.Location = new System.Drawing.Point(5, 173);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(69, 29);
            this.btnYeni.TabIndex = 64;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // txtUrunAdi
            // 
            this.errorProvider1.SetError(this.txtUrunAdi, "Ürün Adı boş geçilemez.");
            this.txtUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrunAdi.Location = new System.Drawing.Point(99, 7);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(165, 23);
            this.txtUrunAdi.TabIndex = 49;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Black;
            this.btnSil.Enabled = false;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(215, 173);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(69, 29);
            this.btnSil.TabIndex = 63;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Ürün Adı";
            // 
            // btnDegistir
            // 
            this.btnDegistir.BackColor = System.Drawing.Color.Black;
            this.btnDegistir.Enabled = false;
            this.btnDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDegistir.ForeColor = System.Drawing.Color.White;
            this.btnDegistir.Location = new System.Drawing.Point(145, 173);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(69, 29);
            this.btnDegistir.TabIndex = 62;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Kategori";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Black;
            this.btnKaydet.Enabled = false;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(75, 173);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(69, 29);
            this.btnKaydet.TabIndex = 61;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cbKategoriler
            // 
            this.cbKategoriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategoriler.DropDownWidth = 110;
            this.cbKategoriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKategoriler.FormattingEnabled = true;
            this.cbKategoriler.Location = new System.Drawing.Point(242, 41);
            this.cbKategoriler.Name = "cbKategoriler";
            this.cbKategoriler.Size = new System.Drawing.Size(22, 24);
            this.cbKategoriler.TabIndex = 45;
            this.cbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cbKategoriler_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 60;
            this.label6.Text = "Kritik Seviye";
            // 
            // txtKategori
            // 
            this.txtKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKategori.Location = new System.Drawing.Point(99, 41);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.ReadOnly = true;
            this.txtKategori.Size = new System.Drawing.Size(144, 23);
            this.txtKategori.TabIndex = 54;
            // 
            // txtKritikSeviye
            // 
            this.txtKritikSeviye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKritikSeviye.Location = new System.Drawing.Point(100, 143);
            this.txtKritikSeviye.Name = "txtKritikSeviye";
            this.txtKritikSeviye.Size = new System.Drawing.Size(165, 23);
            this.txtKritikSeviye.TabIndex = 59;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiktar.Location = new System.Drawing.Point(99, 109);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(165, 23);
            this.txtMiktar.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "Stok Miktarı";
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.dgvUrunler);
            this.panel4.Location = new System.Drawing.Point(310, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(379, 214);
            this.panel4.TabIndex = 65;
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AllowUserToAddRows = false;
            this.dgvUrunler.AllowUserToDeleteRows = false;
            this.dgvUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvUrunler.BackgroundColor = System.Drawing.Color.White;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(0, 3);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.ReadOnly = true;
            this.dgvUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunler.Size = new System.Drawing.Size(374, 195);
            this.dgvUrunler.TabIndex = 47;
            // 
            // tpStok
            // 
            this.tpStok.Location = new System.Drawing.Point(4, 29);
            this.tpStok.Name = "tpStok";
            this.tpStok.Padding = new System.Windows.Forms.Padding(3);
            this.tpStok.Size = new System.Drawing.Size(809, 311);
            this.tpStok.TabIndex = 1;
            this.tpStok.Text = "Stok Giriş-Çıkış";
            this.tpStok.UseVisualStyleBackColor = true;
            // 
            // tpSorgulama
            // 
            this.tpSorgulama.Location = new System.Drawing.Point(4, 29);
            this.tpSorgulama.Name = "tpSorgulama";
            this.tpSorgulama.Size = new System.Drawing.Size(809, 311);
            this.tpSorgulama.TabIndex = 2;
            this.tpSorgulama.Text = "Stok Sorgulama";
            this.tpSorgulama.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmStokIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStokIslemleri";
            this.Text = "frmStokIslemleri";
            this.Load += new System.EventHandler(this.frmStokIslemleri_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpUrunler.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpUrunler;
        private System.Windows.Forms.TabPage tpStok;
        private System.Windows.Forms.TabPage tpSorgulama;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbKategoriler;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKritikSeviye;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}