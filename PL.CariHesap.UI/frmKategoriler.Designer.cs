namespace PL.CariHesap.UI
{
    partial class frmKategoriler
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnYeni = new System.Windows.Forms.Button();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvKategoriler = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 77);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(671, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori İşlemleri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 458);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtAciklama);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btnYeni);
            this.panel4.Controls.Add(this.txtKategori);
            this.panel4.Controls.Add(this.btnSil);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnDegistir);
            this.panel4.Controls.Add(this.btnKaydet);
            this.panel4.Location = new System.Drawing.Point(135, 214);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(410, 187);
            this.panel4.TabIndex = 45;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAciklama.Location = new System.Drawing.Point(152, 59);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(202, 72);
            this.txtAciklama.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Kategori";
            // 
            // btnYeni
            // 
            this.btnYeni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnYeni.BackColor = System.Drawing.Color.Black;
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeni.ForeColor = System.Drawing.Color.White;
            this.btnYeni.Location = new System.Drawing.Point(32, 148);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(81, 29);
            this.btnYeni.TabIndex = 43;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // txtKategori
            // 
            this.txtKategori.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKategori.Location = new System.Drawing.Point(152, 30);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(202, 26);
            this.txtKategori.TabIndex = 36;
            // 
            // btnSil
            // 
            this.btnSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSil.BackColor = System.Drawing.Color.Black;
            this.btnSil.Enabled = false;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(293, 148);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(81, 29);
            this.btnSil.TabIndex = 41;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Açıklama";
            // 
            // btnDegistir
            // 
            this.btnDegistir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDegistir.BackColor = System.Drawing.Color.Black;
            this.btnDegistir.Enabled = false;
            this.btnDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDegistir.ForeColor = System.Drawing.Color.White;
            this.btnDegistir.Location = new System.Drawing.Point(206, 148);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(81, 29);
            this.btnDegistir.TabIndex = 40;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = false;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKaydet.BackColor = System.Drawing.Color.Black;
            this.btnKaydet.Enabled = false;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(119, 148);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(81, 29);
            this.btnKaydet.TabIndex = 39;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvKategoriler);
            this.panel3.Location = new System.Drawing.Point(132, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(414, 180);
            this.panel3.TabIndex = 44;
            // 
            // dgvKategoriler
            // 
            this.dgvKategoriler.AllowUserToAddRows = false;
            this.dgvKategoriler.AllowUserToDeleteRows = false;
            this.dgvKategoriler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvKategoriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvKategoriler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvKategoriler.BackgroundColor = System.Drawing.Color.White;
            this.dgvKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategoriler.Location = new System.Drawing.Point(0, 0);
            this.dgvKategoriler.Name = "dgvKategoriler";
            this.dgvKategoriler.ReadOnly = true;
            this.dgvKategoriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKategoriler.Size = new System.Drawing.Size(414, 174);
            this.dgvKategoriler.TabIndex = 42;
            this.dgvKategoriler.DoubleClick += new System.EventHandler(this.dgvKategoriler_DoubleClick);
            // 
            // frmKategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 535);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmKategoriler";
            this.Text = "frmKategoriler";
            this.Load += new System.EventHandler(this.frmKategoriler_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.DataGridView dgvKategoriler;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}