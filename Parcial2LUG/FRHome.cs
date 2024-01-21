using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2LUG
{
    public partial class FRHome : Form
    {
        public FRHome()
        {
            InitializeComponent();
        }

        private void jugadoresABMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 JugadoresABM = new Form1();

            JugadoresABM.MdiParent = this;

            JugadoresABM.Show();
        }

        private void taTeTiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRTTT TaTaTi = new FRTTT();

            TaTaTi.MdiParent = this;

            TaTaTi.Show();
        }

        private void piedraPapelTijeraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRPPT PPT = new FRPPT();

            PPT.MdiParent = this;

            PPT.Show();
        }

        private void reportesDesempeñoYUsoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRReporte Reportes = new FRReporte();

            Reportes.MdiParent = this;

            Reportes.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.Application.Exit();
        }
    }
}
