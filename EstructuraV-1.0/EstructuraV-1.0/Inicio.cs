using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // LIBRERIA PARA MOVER BARRA SUPERIOR

namespace EstructuraV_1._0
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        // PALABRAS RESERVADAS PARA MOVER BARRA
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        // FIN PALABRAS RESERVADAS

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panMenuLat.Width == 227) // SI PANELMENU MIDE 227 ENTRA
            {
                panMenuLat.Width = 41; // ENTONCES CAMBIA EL TAMAÑO A MAS CHICO
                btnMenu.Location = new Point(3, 3); // BOTON MENU SE MUEVE
            }
            else
            {
                panMenuLat.Width = 227; // PANELMENU SE QUEDA IGUAL
                btnMenu.Location = new Point(189, 4); // BTN MENU QUEDA DONDE ESTABA 
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // CERRAR APP
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // MINIMIZAR FORMA
        }

        int LX, LY;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized; // MAXIMIZA FORMA
            LX = this.Location.X; // GUARDA LA ULTIMA POSICION EN X
            LY = this.Location.Y; // GUARDA LA ULTIMA POSICION EN Y
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;// DEJAR QUE SE VEA BARRA DE TAREAS
            this.Location = Screen.PrimaryScreen.WorkingArea.Location; // DEJAR QUE SE VEA BARRA DE TAREAS
            btnMaximizar.Visible = false; // OCULTA BOTON MAXIMIZAR
            btnRestaurar.Visible = true; // MUESTRA ICONO RESTAURAR
            picLogo.Location = new Point(659, 216); // MUEVE PICLOGO
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal; // MANTIENE NORMAL LA FORMA
            this.Size = new Size(1270, 638); // ESTABLECER NUEVO TAMAÑO DE FORM 
            this.Location = new Point(LX, LY); // RESTAURA LA ULTIMA POSICION ANTES DE MAXIZAR
            btnMaximizar.Visible = true; // MUESTRA ICONO MAXIMIZAR
            btnRestaurar.Visible = false; // OCULTA BOTON
            picLogo.Location = new Point(609, 166); // REGRESA PICLOGO A POSICION INICIAL
        }

        private void panBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); // MANDAR A LLAMAR METODOS CREADOS DE PALABRAS RESERVADAS
            SendMessage(this.Handle, 0x112,0xf012,0); // MANDAR A LLAMAR METODOS CREADOS DE PALABRAS RESERVADAS
        }

        //// CODIGO PARA ABRIR FORM DENTRO DE PANEL
        //private void AbrirFormInPanel(object FormHijo)
        //{
        //    if (this.panContenedor.Controls.Count > 0)
        //    {
        //        this.panContenedor.Controls.RemoveAt(0);
        //        Form fh = FormHijo as Form;
        //        fh.TopLevel = false;
        //        fh.Dock = DockStyle.Fill;
        //        this.panContenedor.Controls.Add(fh);
        //        this.panContenedor.Tag = fh;
        //        fh.Show();
        //    }
        //}

        private void btnUnidadI_Click(object sender, EventArgs e)
        {
            UnidadI frmUI = new UnidadI();
            AddOwnedForm(frmUI); // ABRIR DENTRO DEL PANEL
            frmUI.TopLevel = false; // ESTABLECER QUE NO SERA TOPLEVEL
            frmUI.Dock = DockStyle.Fill; // ESTABLECER DOCK DE TIPO FILL
            this.Controls.Add(frmUI); // AGREGAR CONTROLES EN ESTE CASO FORMA
            this.Tag = frmUI; // ESPECIFICAR EL TAG SOBRE FORM 
            frmUI.BringToFront(); // COLOCAR FORM AL PRINCIPIO
            frmUI.Show(); // MANDAR A LLAMAR FORM
        }
    }
}
