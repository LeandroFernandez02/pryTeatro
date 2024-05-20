using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTeatro
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mitQuenaken_Click(object sender, EventArgs e)
        {
            frmQuenaken frmQuenaken = new frmQuenaken();
            frmQuenaken.ShowDialog();
        }

        private void mitOnas_Click(object sender, EventArgs e)
        {
            frmOnas frmOnas = new frmOnas();
            frmOnas.ShowDialog();
        }

        private void mitTobas_Click(object sender, EventArgs e)
        {
            frmTobas frmTobas = new frmTobas();
            frmTobas.ShowDialog();
        }
    }
}
