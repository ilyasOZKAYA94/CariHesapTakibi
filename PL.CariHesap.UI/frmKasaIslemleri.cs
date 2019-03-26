using BLL.CariHesap.Cl.Repositories;
using DAL.CariHesap.Cl.Context;
using DAL.CariHesap.Cl.Models;
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
    public partial class frmKasaIslemleri : Form
    {
        public frmKasaIslemleri()
        {
            InitializeComponent();
        }
        KasaRepository kRepo = new KasaRepository();
        CariHareketRepository chRepo = new CariHareketRepository();
        CariRepository cRepo = new CariRepository();
        private void frmKasaIslemleri_Load(object sender, EventArgs e)
        {
            dtpTarih.Value = DateTime.Now;
        }
        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            List<Decimal> liste = kRepo.KasaDevirleriToTarih(dtpTarih.Value);
            txtDevirGiren.Text = string.Format("{0:#,##0}", liste[0]);
            txtDevirCikan.Text = string.Format("{0:#,##0}", liste[1]);
            txtDevirBakiye.Text = string.Format("{0:#,##0}", liste[2]);

            dgvHareketler.DataSource = kRepo.KasaHareketlerByTarih(dtpTarih.Value);
            GunlukToplamlariGoster();
        }
        private void GunlukToplamlariGoster()
        {
            decimal GirenToplam = 0;
            decimal CikanToplam = 0;
            foreach (DataGridViewRow dr in dgvHareketler.Rows)
            {
                GirenToplam += Convert.ToDecimal(dr.Cells[6].Value);
                CikanToplam += Convert.ToDecimal(dr.Cells[7].Value);
                //dr.Cells[6].Value = Convert.ToDecimal(string.Format("{0:#,##0}", Convert.ToDecimal(dr.Cells[6].Value)));
                //dr.Cells[7].Value = Convert.ToDecimal(string.Format("{0:#,##0}", Convert.ToDecimal(dr.Cells[7].Value)));
            }
            txtGirenToplam.Text = string.Format("{0:#,##0}", GirenToplam);
            txtCikanToplam.Text = string.Format("{0:#,##0}", CikanToplam);
            txtBakiye.Text = string.Format("{0:#,##0}", GirenToplam - CikanToplam);
        }

        private void cbIslemTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIslemTurleri.SelectedItem.ToString() == "Tahsilat")
            {
                Genel.cariTipi = "Alıcı";
                txtGiren.ReadOnly = false;
                txtCikan.ReadOnly = true;
            }
            else if (cbIslemTurleri.SelectedItem.ToString() == "Ödeme")
            {
                Genel.cariTipi = "Satıcı";
                txtCikan.ReadOnly = false;
                txtGiren.ReadOnly = true;
            }
            frmCariSorgulama frm = new frmCariSorgulama();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            txtMusteriUnvan.Text = Genel.cariUnvan;
            txtBelge.Focus();
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            cbIslemTurleri.DroppedDown = true;
            Temizle();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(txtMusteriUnvan.Text.Trim() == "" || cbIslemTurleri.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Firma Bilgisi ve İşlem Türü seçilmelidir!", "Dikkat Eksik Bilgi!");
                txtMusteriUnvan.Focus();
            }
            else
            {
                //KasaHareket eklenmeli.
                KasaHareket kh = new KasaHareket();
                kh.KasaTuru = txtKasaTuru.Text;
                kh.Tarih = dtpTarih.Value;
                kh.IslemTuru = cbIslemTurleri.SelectedItem.ToString();
                kh.CariId = Genel.cariId;
                kh.Belge = txtBelge.Text;
                try
                {
                    kh.Giren = Convert.ToDecimal(txtGiren.Text);
                }
                catch (Exception)
                {
                    kh.Giren = 0;
                }
                try
                {
                    kh.Cikan = Convert.ToDecimal(txtCikan.Text);
                }
                catch (Exception)
                {
                    kh.Cikan = 0;
                }
                if(kh.Giren == 0 && kh.Cikan == 0)
                {
                    if (cbIslemTurleri.SelectedItem.ToString() == "Tahsilat")
                    {
                        MessageBox.Show("Giren Tutar bilgisi girilmelidir!", "Dikkat Eksik Bilgi!");
                        txtGiren.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Çıkan Tutar bilgisi girilmelidir!", "Dikkat Eksik Bilgi!");
                        txtCikan.Focus();
                    }
                }
                else
                {
                    kh.ParaBirimi = txtPara.Text;
                    //KasaCariHareketEkle içine kh(KasaHareket) gönderilecek,
                    //KasaHareket için, CariHareket için, Cari için,
                    //tüm SaveChanges()'ler Transaction içinde yaptırılacak.
                    if(kRepo.KasaCariHareketEkle(kh))
                    {
                        MessageBox.Show("Tüm Hareketler işlendi.", "Cari Hesaplar güncellendi.");
                        dgvHareketler.DataSource = kRepo.KasaHareketlerByTarih(dtpTarih.Value);
                        GunlukToplamlariGoster();
                        btnKaydet.Enabled = false;
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("İşlemler iptal edildi!", "İşlemler Tamamlanamadı!");
                    }

                    //if(kRepo.KasaHareketEkle(kh))
                    //{
                    //    //CariHareket eklenmeli.
                    //    CariHareket ch = new CariHareket();
                    //    ch.IslemTuru = kh.IslemTuru;
                    //    ch.Tarih = kh.Tarih;
                    //    ch.CariId = kh.CariId;
                    //    ch.Belge = kh.Belge;
                    //    ch.Borc = kh.Cikan;
                    //    ch.Alacak = kh.Giren;
                    //    //ch.KasaHareketId = kh.Id;
                    //    ch.KasaHareketId = 22;
                    //    if (chRepo.CariHareketEkle(ch))
                    //    {
                    //        //Cari Toplamlar güncellenmeli.
                    //        Cari c = new Cari();
                    //        if(cRepo.CariToplamlariGuncelle(kh.CariId, ch.Borc, ch.Alacak))
                    //        {
                    //            MessageBox.Show("Tüm Hareketler işlendi.", "Cari Hesaplar güncellendi.");
                    //            dgvHareketler.DataSource = kRepo.KasaHareketlerByTarih(dtpTarih.Value);
                    //            GunlukToplamlariGoster();
                    //            btnKaydet.Enabled = false;
                    //            Temizle();
                    //        }
                    //        else { MessageBox.Show("Cari Toplamlar güncellenemedi!", "Cari Hesaplar düzenlenemedi!"); }
                    //    }
                    //    else { MessageBox.Show("Cari Hareket eklenemedi!", "Cari Hareket kaydedilemedi!"); }
                    //}
                    //else { MessageBox.Show("Kasa Hareket eklenemedi!", "Kasa Hareket düzenlenemedi!"); }
                }
            }
        }
        private void Temizle()
        {
            dtpTarih.Value = DateTime.Now;
            txtMusteriUnvan.Clear();
            txtBelge.Clear();
            txtGiren.Clear();
            txtCikan.Clear();
            txtPara.Text = "TL.";
        }


    }
}
