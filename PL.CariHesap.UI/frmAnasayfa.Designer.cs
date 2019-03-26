namespace PL.CariHesap.UI
{
    partial class frmAnasayfa
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
            this.pnlLeftMenu = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnKasa = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnStok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlHeader11 = new PL.CariHesap.UI.pnlHeader11();
            this.pnlLeftMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeftMenu
            // 
            this.pnlLeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlLeftMenu.Controls.Add(this.btnCikis);
            this.pnlLeftMenu.Controls.Add(this.btnRaporlar);
            this.pnlLeftMenu.Controls.Add(this.btnKategori);
            this.pnlLeftMenu.Controls.Add(this.btnKasa);
            this.pnlLeftMenu.Controls.Add(this.btnCari);
            this.pnlLeftMenu.Controls.Add(this.btnStok);
            this.pnlLeftMenu.Controls.Add(this.label1);
            this.pnlLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftMenu.Location = new System.Drawing.Point(0, 130);
            this.pnlLeftMenu.Name = "pnlLeftMenu";
            this.pnlLeftMenu.Size = new System.Drawing.Size(265, 413);
            this.pnlLeftMenu.TabIndex = 2;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Black;
            this.btnCikis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(0, 269);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(265, 39);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "Programdan Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            this.btnCikis.MouseLeave += new System.EventHandler(this.btnStok_MouseLeave);
            this.btnCikis.MouseHover += new System.EventHandler(this.btnStok_MouseHover);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.BackColor = System.Drawing.Color.Black;
            this.btnRaporlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRaporlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaporlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaporlar.ForeColor = System.Drawing.Color.White;
            this.btnRaporlar.Location = new System.Drawing.Point(0, 230);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(265, 39);
            this.btnRaporlar.TabIndex = 7;
            this.btnRaporlar.Text = "Raporlar";
            this.btnRaporlar.UseVisualStyleBackColor = false;
            this.btnRaporlar.MouseLeave += new System.EventHandler(this.btnStok_MouseLeave);
            this.btnRaporlar.MouseHover += new System.EventHandler(this.btnStok_MouseHover);
            // 
            // btnKategori
            // 
            this.btnKategori.BackColor = System.Drawing.Color.Black;
            this.btnKategori.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKategori.ForeColor = System.Drawing.Color.White;
            this.btnKategori.Location = new System.Drawing.Point(0, 191);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(265, 39);
            this.btnKategori.TabIndex = 6;
            this.btnKategori.Text = "Kategoriler";
            this.btnKategori.UseVisualStyleBackColor = false;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            this.btnKategori.MouseLeave += new System.EventHandler(this.btnStok_MouseLeave);
            this.btnKategori.MouseHover += new System.EventHandler(this.btnStok_MouseHover);
            // 
            // btnKasa
            // 
            this.btnKasa.BackColor = System.Drawing.Color.Black;
            this.btnKasa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKasa.ForeColor = System.Drawing.Color.White;
            this.btnKasa.Location = new System.Drawing.Point(0, 152);
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.Size = new System.Drawing.Size(265, 39);
            this.btnKasa.TabIndex = 3;
            this.btnKasa.Text = "Kasa İşlemleri";
            this.btnKasa.UseVisualStyleBackColor = false;
            this.btnKasa.Click += new System.EventHandler(this.btnKasa_Click);
            this.btnKasa.MouseLeave += new System.EventHandler(this.btnStok_MouseLeave);
            this.btnKasa.MouseHover += new System.EventHandler(this.btnStok_MouseHover);
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.Black;
            this.btnCari.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.Location = new System.Drawing.Point(0, 113);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(265, 39);
            this.btnCari.TabIndex = 2;
            this.btnCari.Text = "Müşteri-Cari İşlemleri";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            this.btnCari.MouseLeave += new System.EventHandler(this.btnStok_MouseLeave);
            this.btnCari.MouseHover += new System.EventHandler(this.btnStok_MouseHover);
            // 
            // btnStok
            // 
            this.btnStok.BackColor = System.Drawing.Color.Black;
            this.btnStok.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStok.ForeColor = System.Drawing.Color.White;
            this.btnStok.Location = new System.Drawing.Point(0, 74);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(265, 39);
            this.btnStok.TabIndex = 1;
            this.btnStok.Text = "Stok İşlemleri";
            this.btnStok.UseVisualStyleBackColor = false;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            this.btnStok.MouseLeave += new System.EventHandler(this.btnStok_MouseLeave);
            this.btnStok.MouseHover += new System.EventHandler(this.btnStok_MouseHover);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "İşlemler";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(265, 130);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(668, 413);
            this.pnlContent.TabIndex = 3;
            // 
            // pnlHeader11
            // 
            this.pnlHeader11.BackColor = System.Drawing.Color.Black;
            this.pnlHeader11.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader11.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHeader11.Name = "pnlHeader11";
            this.pnlHeader11.Size = new System.Drawing.Size(933, 130);
            this.pnlHeader11.TabIndex = 0;
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 543);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlLeftMenu);
            this.Controls.Add(this.pnlHeader11);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAnasayfa";
            this.Text = "Cari Hesap Yönetimi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            this.pnlLeftMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private pnlHeader11 pnlHeader11;
        private System.Windows.Forms.Panel pnlLeftMenu;
        private System.Windows.Forms.Button btnKasa;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Button btnKategori;
    }
}