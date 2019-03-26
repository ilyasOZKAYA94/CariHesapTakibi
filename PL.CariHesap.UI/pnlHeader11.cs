using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.CariHesap.UI
{
    public partial class pnlHeader11 : UserControl
    {
        public pnlHeader11()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Parent.FindForm().Close();
        }
    }
}
