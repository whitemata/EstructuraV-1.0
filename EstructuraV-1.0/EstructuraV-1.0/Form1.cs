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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBlanco_MouseEnter(object sender, EventArgs e)
        {
            btnBlanco.BackColor = Color.FromArgb(226, 204, 0); // CAMBIAR COLOR AL PASAR MOUSE POR ENCIMA
        }

        private void btnBlanco_MouseLeave(object sender, EventArgs e)
        {
            btnBlanco.BackColor = Color.FromArgb(40, 45, 54); // AL NO ESTAR MOUSE ENCIMA SE CAMBIA EL COLOR
        }

        private void btnLeopoldo_MouseEnter(object sender, EventArgs e)
        {
            btnLeopoldo.BackColor = Color.FromArgb(226, 204, 0); // CAMBIAR COLOR AL PASAR MOUSE POR ENCIMA
        }

        private void btnLeopoldo_MouseLeave(object sender, EventArgs e)
        {
            btnLeopoldo.BackColor = Color.FromArgb(40, 45, 54); // AL NO ESTAR MOUSE ENCIMA SE CAMBIA EL COLOR
        }

        private void btnAlberto_MouseEnter(object sender, EventArgs e)
        {
            btnAlberto.BackColor = Color.FromArgb(226, 204, 0); // CAMBIAR COLOR AL PASAR MOUSE POR ENCIMA
        }

        private void btnAlberto_MouseLeave(object sender, EventArgs e)
        {
            btnAlberto.BackColor = Color.FromArgb(40, 45, 54); // AL NO ESTAR MOUSE ENCIMA SE CAMBIA EL COLOR
        }

        private void btnAlonso_MouseEnter(object sender, EventArgs e)
        {
            btnAlonso.BackColor = Color.FromArgb(226, 204, 0); // CAMBIAR COLOR AL PASAR MOUSE POR ENCIMA
        }

        private void btnAlonso_MouseLeave(object sender, EventArgs e)
        {
            btnAlonso.BackColor = Color.FromArgb(40, 45, 54); // AL NO ESTAR MOUSE ENCIMA SE CAMBIA EL COLOR
        }
    }
}
