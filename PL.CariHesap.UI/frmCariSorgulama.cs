using BLL.CariHesap.Cl.Repositories;
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
    public partial class frmCariSorgulama : Form
    {
        public frmCariSorgulama()
        {
            InitializeComponent();
        }
        CariRepository cRepo = new CariRepository();
        private void frmCariSorgulama_Load(object sender, EventArgs e)
        {
            if (Genel.cariTipi == "Alıcı")
                rbAlicilar.Checked = true;
            else if (Genel.cariTipi == "Satıcı")
                rbSaticilar.Checked = true;
            else
                rbTumu.Checked = true;
        }
        private void txtUnvanaGore_TextChanged(object sender, EventArgs e)
        {
            if(rbTumu.Checked)
                dgvCariler.DataSource = cRepo.CarileriListeleByUnvan(txtUnvanaGore.Text);
            else
                dgvCariler.DataSource = cRepo.CarileriListeleByUnvanAndCariTipi(txtUnvanaGore.Text, Genel.cariTipi);
        }
        private void rbAlicilar_CheckedChanged(object sender, EventArgs e)
        {
            Genel.cariTipi = "Alıcı";
            txtUnvanaGore.Text = "";
            dgvCariler.DataSource = cRepo.CarileriListeleByCariTipi(Genel.cariTipi);
        }
        private void rbSaticilar_CheckedChanged(object sender, EventArgs e)
        {
            Genel.cariTipi = "Satıcı";
            txtUnvanaGore.Text = "";
            dgvCariler.DataSource = cRepo.CarileriListeleByCariTipi(Genel.cariTipi);
        }
        private void rbTumu_CheckedChanged(object sender, EventArgs e)
        {
            dgvCariler.DataSource = cRepo.CarileriListele();
        }

        private void dgvCariler_DoubleClick(object sender, EventArgs e)
        {
            Genel.cariId = Convert.ToInt32(dgvCariler.SelectedRows[0].Cells[0].Value);
            Genel.cariUnvan = dgvCariler.SelectedRows[0].Cells[2].Value.ToString();
            this.Close();
        }
    }
}
