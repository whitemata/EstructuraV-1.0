﻿using System;
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
    public partial class UnidadII : Form
    {
        public UnidadII()
        {
            InitializeComponent();
        }

        private void panAlebrto_Click(object sender, EventArgs e)
        {
            FrAlberto frmAlb = new FrAlberto(); // INSTANCIA DE UNIDADI
            AddOwnedForm(frmAlb); // ABRIR DENTRO DEL PANEL
            frmAlb.TopLevel = false; // ESTABLECER QUE NO SERA TOPLEVEL
            frmAlb.Dock = DockStyle.Fill; // ESTABLECER DOCK DE TIPO FILL
            this.Controls.Add(frmAlb); // AGREGAR CONTROLES EN ESTE CASO FORMA
            this.Tag = frmAlb; // ESPECIFICAR EL TAG SOBRE FORM 
            frmAlb.BringToFront(); // COLOCAR FORM AL PRINCIPIO
            frmAlb.Show(); // MANDAR A LLAMAR FORM
        }

        private void panAlonso_Click(object sender, EventArgs e)
        {
            FrAlonso frmAlo = new FrAlonso(); // INSTANCIA DE UNIDADI
            AddOwnedForm(frmAlo); // ABRIR DENTRO DEL PANEL
            frmAlo.TopLevel = false; // ESTABLECER QUE NO SERA TOPLEVEL
            frmAlo.Dock = DockStyle.Fill; // ESTABLECER DOCK DE TIPO FILL
            this.Controls.Add(frmAlo); // AGREGAR CONTROLES EN ESTE CASO FORMA
            this.Tag = frmAlo; // ESPECIFICAR EL TAG SOBRE FORM 
            frmAlo.BringToFront(); // COLOCAR FORM AL PRINCIPIO
            frmAlo.Show(); // MANDAR A LLAMAR FORM
        }

        private void panLeopoldo_Click(object sender, EventArgs e)
        {
            FrLeopoldo frmLeo = new FrLeopoldo(); // INSTANCIA DE UNIDADI
            AddOwnedForm(frmLeo); // ABRIR DENTRO DEL PANEL
            frmLeo.TopLevel = false; // ESTABLECER QUE NO SERA TOPLEVEL
            frmLeo.Dock = DockStyle.Fill; // ESTABLECER DOCK DE TIPO FILL
            this.Controls.Add(frmLeo); // AGREGAR CONTROLES EN ESTE CASO FORMA
            this.Tag = frmLeo; // ESPECIFICAR EL TAG SOBRE FORM 
            frmLeo.BringToFront(); // COLOCAR FORM AL PRINCIPIO
            frmLeo.Show(); // MANDAR A LLAMAR FORM
        }

        private void panBlanco_Click(object sender, EventArgs e)
        {
            FrBlanco frmBla = new FrBlanco(); // INTANCIA BLANCO
            AddOwnedForm(frmBla); //  ABRIR DENTRO DEL PANEL
            frmBla.TopLevel = false; // ESTABLECER QUE NO SERA TOPLEVEL
            frmBla.Dock = DockStyle.Fill; // ESTABLECER DOCK DE TIPO FILL
            this.Controls.Add(frmBla); // AGREGAR CONTROLES EN ESTE CASO FORMA
            this.Tag = frmBla; // ESPECIFICAR EL TAG SOBRE FORM 
            frmBla.BringToFront(); // COLOCAR FORM AL PRINCIPIO
            frmBla.Show(); // MANDAR A LLAMAR FORM
        }

        private void panBlanco_MouseEnter(object sender, EventArgs e)
        {
            panBlanco.BackColor = Color.FromArgb(226, 204, 0); // CAMBIA COLOR AL PASAR MOUSE POR ENCIMA
        }

        private void panBlanco_MouseLeave(object sender, EventArgs e)
        {
            panBlanco.BackColor = Color.FromArgb(40, 45, 54); // CAMBIAR COLOR AL NO ESTAR MOUSE ENCIMA
        }
    }
}
