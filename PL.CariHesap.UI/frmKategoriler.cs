using BLL.CariHesap.Cl.Repositories;
using DAL.CariHesap.Cl.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.CariHesap.UI
{
    public partial class frmKategoriler : Form
    {
        public frmKategoriler()
        {
            InitializeComponent();
        }
        KategoriRepository Krepo = new KategoriRepository();
        int ID;
        private void frmKategoriler_Load(Object sender, EventArgs e)
        {
            dgvKategoriler.DataSource = Krepo.KategoriListele();
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            txtKategori.Focus();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKategori.Text))
            {
                Kategori yeni = new Kategori();
                yeni.KategoriAdi = txtKategori.Text;
                if (Krepo.KategoriKontrol(yeni))
                {
                    MessageBox.Show("Bu kategori kayıtlı!", "Aynı kategori zaten var!");
                }
                else
                {
                    yeni.Aciklama = txtAciklama.Text;
                    if (Krepo.KategoriEkle(yeni))
                    {
                        MessageBox.Show("Yeni kategori eklendi.", "Kayıt gerçekleşti.");
                        dgvKategoriler.DataSource = Krepo.KategoriListele();
                        btnKaydet.Enabled = false;
                        Temizle();
                    }
                }
            }
            else
            {
                MessageBox.Show("Kategori ismi girilmelidir!", "Dikkat! Eksik Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtKategori.Focus();
        }
        private void Temizle()
        {
            txtKategori.Clear();
            txtAciklama.Clear();
        }
        private void dgvKategoriler_DoubleClick(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(dgvKategoriler.SelectedRows[0].Cells[0].Value);
            txtKategori.Text = dgvKategoriler.SelectedRows[0].Cells[1].Value.ToString();
            txtAciklama.Text = dgvKategoriler.SelectedRows[0].Cells[2].Value == null ? "" : dgvKategoriler.SelectedRows[0].Cells[2].Value.ToString();
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            txtKategori.Focus();
        }
        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKategori.Text))
            {
                Kategori degisen = Krepo.KategoriGetirByID(ID);
                degisen.KategoriAdi = txtKategori.Text;
                degisen.Aciklama = txtAciklama.Text;
                if (Krepo.KategoriKontrolFromDegistir(degisen))
                {
                    MessageBox.Show("Bu kategori kayıtlı!", "Aynı kategori zaten var!");
                }
                else
                {
                    if (Krepo.KategoriGuncelle())
                    {
                        MessageBox.Show("Kategori bilgileri değiştirildi.", "Update gerçekleşti.");
                        dgvKategoriler.DataSource = Krepo.KategoriListele();
                        btnDegistir.Enabled = false;
                        btnSil.Enabled = false;
                        Temizle();
                    }
                }
            }
            else
            {
                MessageBox.Show("Kategori ismi girilmelidir!", "Dikkat! Eksik Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtKategori.Focus();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(Krepo.KategoriSil(ID))
                {
                    MessageBox.Show("Kategori bilgileri silindi.", "Silme gerçekleşti.");
                    dgvKategoriler.DataSource = Krepo.KategoriListele();
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                    Temizle();
                }
            }
        }
    }
}
