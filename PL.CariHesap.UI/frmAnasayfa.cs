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
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }
        CariContext ent = new CariContext();
        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            //ent.Database.CreateIfNotExists();

        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            frmKategoriler frm = new frmKategoriler();
            FormAc(frm);
        }
        private void FormAc(Form AF)
        {
            foreach (Control F in this.pnlContent.Controls)
            {
                if (F is Form)
                {
                    Form MF = (Form)F;
                    MF.Close();
                }
            }
            AF.TopLevel = false;
            this.pnlContent.Controls.Add(AF);
            AF.Dock = DockStyle.Fill;
            AF.Show();
        }

        private void btnStok_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Silver;
            btn.ForeColor = Color.Black;
        }

        private void btnStok_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Black;
            btn.ForeColor = Color.White;
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            frmStokIslemleri frm = new frmStokIslemleri();
            FormAc(frm);
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            frmKasaIslemleri frm = new frmKasaIslemleri();
            FormAc(frm);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            frmCariSorgulama frm = new frmCariSorgulama();
            FormAc(frm);
        }
    }
}
