namespace PL.CariHesap.UI
{
    partial class frmCariSorgulama
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
            this.dgvCariler = new System.Windows.Forms.DataGridView();
            this.rbAlicilar = new System.Windows.Forms.RadioButton();
            this.rbSaticilar = new System.Windows.Forms.RadioButton();
            this.rbTumu = new System.Windows.Forms.RadioButton();
            this.txtUnvanaGore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 64);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Cari Sorgulama";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvCariler
            // 
            this.dgvCariler.AllowUserToAddRows = false;
            this.dgvCariler.AllowUserToDeleteRows = false;
            this.dgvCariler.BackgroundColor = System.Drawing.Color.White;
            this.dgvCariler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCariler.Location = new System.Drawing.Point(29, 149);
            this.dgvCariler.MultiSelect = false;
            this.dgvCariler.Name = "dgvCariler";
            this.dgvCariler.ReadOnly = true;
            this.dgvCariler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCariler.Size = new System.Drawing.Size(606, 253);
            this.dgvCariler.TabIndex = 2;
            this.dgvCariler.DoubleClick += new System.EventHandler(this.dgvCariler_DoubleClick);
            // 
            // rbAlicilar
            // 
            this.rbAlicilar.AutoSize = true;
            this.rbAlicilar.Location = new System.Drawing.Point(378, 117);
            this.rbAlicilar.Name = "rbAlicilar";
            this.rbAlicilar.Size = new System.Drawing.Size(72, 24);
            this.rbAlicilar.TabIndex = 3;
            this.rbAlicilar.TabStop = true;
            this.rbAlicilar.Text = "Alıcılar";
            this.rbAlicilar.UseVisualStyleBackColor = true;
            this.rbAlicilar.CheckedChanged += new System.EventHandler(this.rbAlicilar_CheckedChanged);
            // 
            // rbSaticilar
            // 
            this.rbSaticilar.AutoSize = true;
            this.rbSaticilar.Location = new System.Drawing.Point(470, 117);
            this.rbSaticilar.Name = "rbSaticilar";
            this.rbSaticilar.Size = new System.Drawing.Size(83, 24);
            this.rbSaticilar.TabIndex = 4;
            this.rbSaticilar.TabStop = true;
            this.rbSaticilar.Text = "Satıcılar";
            this.rbSaticilar.UseVisualStyleBackColor = true;
            this.rbSaticilar.CheckedChanged += new System.EventHandler(this.rbSaticilar_CheckedChanged);
            // 
            // rbTumu
            // 
            this.rbTumu.AutoSize = true;
            this.rbTumu.Location = new System.Drawing.Point(568, 117);
            this.rbTumu.Name = "rbTumu";
            this.rbTumu.Size = new System.Drawing.Size(67, 24);
            this.rbTumu.TabIndex = 5;
            this.rbTumu.TabStop = true;
            this.rbTumu.Text = "Tümü";
            this.rbTumu.UseVisualStyleBackColor = true;
            this.rbTumu.CheckedChanged += new System.EventHandler(this.rbTumu_CheckedChanged);
            // 
            // txtUnvanaGore
            // 
            this.txtUnvanaGore.Location = new System.Drawing.Point(68, 117);
            this.txtUnvanaGore.Name = "txtUnvanaGore";
            this.txtUnvanaGore.Size = new System.Drawing.Size(141, 26);
            this.txtUnvanaGore.TabIndex = 6;
            this.txtUnvanaGore.TextChanged += new System.EventHandler(this.txtUnvanaGore_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ünvana Göre";
            // 
            // frmCariSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 451);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUnvanaGore);
            this.Controls.Add(this.rbTumu);
            this.Controls.Add(this.rbSaticilar);
            this.Controls.Add(this.rbAlicilar);
            this.Controls.Add(this.dgvCariler);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCariSorgulama";
            this.Load += new System.EventHandler(this.frmCariSorgulama_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCariler;
        private System.Windows.Forms.RadioButton rbAlicilar;
        private System.Windows.Forms.RadioButton rbSaticilar;
        private System.Windows.Forms.RadioButton rbTumu;
        private System.Windows.Forms.TextBox txtUnvanaGore;
        private System.Windows.Forms.Label label2;
    }
}