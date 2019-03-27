using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraV_1._0
{
    public partial class UnidadI : Form
    {
        public UnidadI()
        {
            InitializeComponent();
        }

        private void panPuntero_MouseEnter(object sender, EventArgs e)
        {
            panPuntero.BackColor = Color.FromArgb(226, 204, 0); // CAMBIA COLOR AL PASAR MOUSE POR ENCIMA
        }

        private void panPuntero_MouseLeave(object sender, EventArgs e)
        {
            panPuntero.BackColor = Color.FromArgb(40, 45, 54); // CAMBIAR COLOR AL NO ESTAR MOUSE ENCIMA
        }

        private void panMemoria_MouseEnter(object sender, EventArgs e)
        {
            panMemoria.BackColor = Color.FromArgb(226, 204, 0); // CAMBIA COLOR AL PASAR MOUSE POR ENCIMA
        }

        private void panMemoria_MouseLeave(object sender, EventArgs e)
        {
            panMemoria.BackColor = Color.FromArgb(40, 45, 54); // CAMBIAR COLOR AL NO ESTAR MOUSE ENCIMA
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); // CIERRA FORM INCRUSTADO EN PANEL
        }

        private void panPuntero_Click(object sender, EventArgs e)
        {
            FrPuntero frmPuntero = new FrPuntero();
            AddOwnedForm(frmPuntero);
            frmPuntero.TopLevel = false; // ESTABLECER QUE NO SERA TOPLEVEL
            frmPuntero.Dock = DockStyle.Fill; // ESTABLECER DOCK DE TIPO FILL
            this.Controls.Add(frmPuntero); // AGREGAR CONTROLES EN ESTE CASO FORMA
            this.Tag = frmPuntero; // ESPECIFICAR EL TAG SOBRE FORM 
            frmPuntero.BringToFront(); // COLOCAR FORM AL PRINCIPIO
            frmPuntero.Show(); // MANDAR A LLAMAR FORM

        }
    }
}
