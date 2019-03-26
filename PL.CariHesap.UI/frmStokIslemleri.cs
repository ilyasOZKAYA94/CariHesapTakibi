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
    public partial class frmStokIslemleri : Form
    {
        public frmStokIslemleri()
        {
            InitializeComponent();
        }
        KategoriRepository kRepo = new KategoriRepository();
        UrunRepository uRepo = new UrunRepository();
        int KategoriId;
        private void frmStokIslemleri_Load(object sender, EventArgs e)
        {
            dgvUrunler.DataSource = uRepo.UrunListele();
            dgvUrunler.Columns[0].Visible = false;
            dgvUrunler.Columns[2].Visible = false;

            cbKategoriler.DisplayMember = "KategoriAdi";
            cbKategoriler.ValueMember = "Id";
            cbKategoriler.DataSource = kRepo.KategoriListele();

            errorProvider1.Clear();
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            errorProvider1.Clear();
            txtUrunAdi.Focus();
        }
        private void cbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtKategori.Text = cbKategoriler.Text;
            //KategoriId = Convert.ToInt32(cbKategoriler.SelectedValue);
            Kategori secilen = (Kategori)cbKategoriler.SelectedItem;
            txtKategori.Text = secilen.KategoriAdi;
            KategoriId = secilen.Id;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrunAdi.Text) && !string.IsNullOrEmpty(txtKategori.Text))
            {
                errorProvider1.Clear();
                Urun yeni = new Urun();
                yeni.UrunAdi = txtUrunAdi.Text;
                yeni.KategoriId = KategoriId;
                if (uRepo.UrunKontrol(yeni))
                {
                    MessageBox.Show("Bu ürün kayıtlı!", "Aynı ürün zaten var!");
                }
                else
                {
                    if (Decimal.TryParse(txtFiyat.Text, out decimal fiyat))
                        yeni.Fiyat = fiyat;
                    else
                    {
                        MessageBox.Show("Fiyat için sayısal değer girmelisiniz!", "Dikkat! Yanlış bilgi girişi!");
                        txtFiyat.Focus(); return;
                    }
                    if (int.TryParse(txtMiktar.Text, out int miktar))
                        yeni.Miktar = miktar;
                    else
                    {
                        MessageBox.Show("Miktar için sayısal değer girmelisiniz!", "Dikkat! Yanlış bilgi girişi!");
                        txtMiktar.Focus(); return;
                    }
                    if (int.TryParse(txtKritikSeviye.Text, out int kritik))
                        yeni.KritikSeviye = kritik;
                    else
                    {
                        MessageBox.Show("Kritik Seviye için sayısal değer girmelisiniz!", "Dikkat! Yanlış bilgi girişi!");
                        txtKritikSeviye.Focus(); return;
                    }
                    if (uRepo.UrunEkle(yeni))
                    {
                        MessageBox.Show("Yeni ürün eklendi.", "Kayıt gerçekleşti.");
                        dgvUrunler.DataSource = uRepo.UrunListele();
                        dgvUrunler.Columns[0].Visible = false;
                        dgvUrunler.Columns[2].Visible = false;
                        btnKaydet.Enabled = false;
                        Temizle();
                    }
                }
            }
            else
            {
                /*                MessageBox.Show("Ürün Adı ve Kategorisi mutlaka seçilmelidir.")*/
                ;
                errorProvider1.SetError(txtUrunAdi, "Ürün Adı girmelisiniz!");
            }
        }
        private void Temizle()
        {
            txtUrunAdi.Clear();
            txtFiyat.Clear();
            txtMiktar.Clear();
            txtKritikSeviye.Clear();
            txtUrunAdi.Focus();
        }
    }
}