using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InputKey; // DLL CREADO

namespace EstructuraV_1._0
{
    public partial class FrBlanco : Form
    {
        List<string> ListaNombre = new List<string>(); // DECLARAR LISTA

        private int conteo = 0; // VARIABLE PARA INCREMENTAR TIEMPO EN TIMER
        private int conteoJuego = 0;
        public Random rnd = new Random(); // GENERADOR DE NUMEROS ALEATORIOS
        public int aleatorio = 0; // VARIABLE PARA GUARDAR NUMERO ALEATORIO
        public int marcador = 0; // INCREMENTO DE BARRA
        public string dif = "";  // GUARDA LA DIFICULTAD EN TEXTO


        public FrBlanco()
        {
            InitializeComponent();
            lblConteo.Visible = false; // INVISIBLE PORQUE CON ESTE SE APOYA EL TIMER
            lblTiempoConteo.Visible = false; // INVISIBLE PORQUE CON ESTE SE APOYA EL TIMER
        }


        private void timerPaneles_Tick(object sender, EventArgs e)
        {
            if(btnRadFacil.Checked == true) // SI ESTA SELECCIONADO BOTON FACIL
            {
                timerPaneles.Interval = 650; // LA VELOCIDAD DEL PANEL SERA DE 650 MILISEGUNDOS
                AleatorioPanel(); // MANDA A LLAMAR EL METODO ALEATORIOPANEL
            }
            else if(btnRadMedio.Checked == true) // SI ESTA SELECCIONADO EL BOTON MEDIO
            {
                timerPaneles.Interval = 250; // LA VELOCIDAD DEL PANEL SERA DE 250 MILISEGUNDOS
                AleatorioPanel(); // MANDA A LLAMAAR EL METOD
            }
            else if(btnRadDificil.Checked == true) // SI ESTA SELECCIONADO EL BOTON DIFICIL
            {
                timerPaneles.Interval = 145; // LA VELOCIDAD DEL PANEL SERA DE 155 MILISEGUNDOS
                AleatorioPanel(); // MANDA A LLAMAAR EL METOD
            }
        }

        public void AleatorioPanel() // METODO ALEATORIO PANEL
        {
            /* ESTE METODO SE APOYA CON EL TIMER PARA QUE CADA
             * 2 SEGUNDOS DEL CONTEO DE TIMER SE CAMBIE A OTRO
             * PANEL, SE USA NUMEROS ALEATORIOS PARA CAMBIAR 
             * ALEATORIAMENTE ENTRE PANELES*/

            conteo++; // SE INCREMENTA EN UNO EL CONTEO PARA EL TIMER
            lblConteo.Text = conteo.ToString(); /* SE IMPRIME EN UN LABEL CADA INCREMENTO
                                                QUE VA DE UNO EN UNO, PERO ESTA DE MANERA
                                                INVISIBLE PARA QUE NO SE MUESTRE EN PANTALLA
                                                ES NECESARIO HACER ESTO PARA PODER LLEVAR EL
                                                CONTEO CON EL PANEL*/
                                                    
            do // COMIENZA DO
            {
                aleatorio = rnd.Next(1, 6); /* CON RND CREADO ANTERIORMENTE SE USA
                                            SU PROPIEDAD NEXT PARA GENERAR NUMEROS
                                            ALEATORIOS ENTRE 1 Y 6, SE GUARDA EN LA
                                            VARIABLE ALEATORIO*/
                    if (lblConteo.Text == "2") // SI EL LABEL INVISIBLE ES IGUAL A 2 ENTRA AQUI
                    {
                        switch (aleatorio) // EVALUA EL NUMERO ALEATORIO
                        {
                            case 1: // EN CASO DE QUE EL NUMERO ALEATORIO SEA 1
                                {
                                    // SI EL PAN1 ES AZUL ENTONCES ENTRA AQUI
                                    if (pan1.BackColor == Color.FromArgb(25, 255, 255))
                                    {   // EL PAN1 LO HACE BLANCO
                                        pan1.BackColor = Color.FromArgb(255, 255, 255);
                                    }   // SI EL PAN1 ES BLANCO A LA SIGUIENTE VUELTA, POR ESO SE USO UN ELSE IF, Y NO UN IF
                                    else if (pan1.BackColor == Color.FromArgb(255, 255, 255))
                                    {   // LO HACE AZUL
                                        pan1.BackColor = Color.FromArgb(25, 255, 255);
                                    }
// ESTO ES PARA QUE SOLO UN PANEL QUEDE BLANCO Y LOS DEMAS SEAN AZULES CUANDO NO LES CORRESPONDE CAMBIARSE
// SE USA IF, IF, IF PORQUE SI NO, LA COMPUTADORA SE LOS BRINCARIA SIENDO ELSE IF
                                    if (pan2.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan2.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan3.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan3.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan4.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan4.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan5.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan5.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan6.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan6.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    if (pan2.BackColor == Color.FromArgb(25, 255, 255))
                                    {
                                        pan2.BackColor = Color.FromArgb(255, 255, 255);
                                    }
                                    else if (pan2.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan2.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan1.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan1.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan3.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan3.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan4.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan4.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan5.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan5.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan6.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan6.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    break;
                                }
                            case 3:
                                {
                                    if (pan3.BackColor == Color.FromArgb(25, 255, 255))
                                    {
                                        pan3.BackColor = Color.FromArgb(255, 255, 255);
                                    }
                                    else if (pan3.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan3.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan1.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan1.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan2.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan2.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan4.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan4.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan5.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan5.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan6.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan6.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    break;
                                }
                            case 4:
                                {
                                    if (pan4.BackColor == Color.FromArgb(25, 255, 255))
                                    {
                                        pan4.BackColor = Color.FromArgb(255, 255, 255);
                                    }
                                    else if (pan4.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan4.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan1.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan1.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan2.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan2.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan3.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan3.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan5.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan5.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan6.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan6.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    break;
                                }
                            case 5:
                                {
                                    if (pan5.BackColor == Color.FromArgb(25, 255, 255))
                                    {
                                        pan5.BackColor = Color.FromArgb(255, 255, 255);
                                    }
                                    else if (pan5.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan5.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan1.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan1.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan2.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan2.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan3.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan3.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan4.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan4.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan6.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan6.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    break;
                                }
                            case 6:
                                {
                                    if (pan6.BackColor == Color.FromArgb(25, 255, 255))
                                    {
                                        pan6.BackColor = Color.FromArgb(255, 255, 255);
                                    }
                                    else if (pan6.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan6.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan1.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan1.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan2.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan2.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan3.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan3.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan4.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan4.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    if (pan5.BackColor == Color.FromArgb(255, 255, 255))
                                    {
                                        pan5.BackColor = Color.FromArgb(25, 255, 255);
                                    }
                                    break;
                                }
                        }
                    }               
                if (conteo == 3) // EL CONTEO SIGUE INCREMENTANDOSE ASI QUE SI LLEGA A 3 ENTRA AQUI
                {
                    timerPaneles.Stop(); // DETIENE EL CONTADOR
                    timerPaneles.Start(); // VUELVE A INCIIAR CONTADOR PERO INICIA DONDE HABIA QUEDADO, EN ESTE CASO EN 3
                    conteo = 0; // VARIABLE CONTEO QUE SE APOYA DEL TIMER LA INICIAMOS EN 0 NUEVAMENTE
                    lblConteo.Text = "0"; // AL IGUAL QUE EL LABEL QUE SE APOYA DEL TIMER
                }
            } while (aleatorio == 10); // ESTE CICLO VA A TERMINAR CUANDO EL NUMERO ALEATORIO SEA 10, EL CUAL AUTOMATICAMENTE NUNCA TERMINARIA PORQUE NO EXISTE EL NUM 10 EN LA ALEATORIDAD
        }

        public void DetenerJuego() // METODO PARA DETENER EL JUEGO
        {
            timerPaneles.Stop(); // DETIENE EL TIMER DEL PANEL
            aleatorio = 10; // ASIGA 10 A ALEATORIO PARA TERMINAR JUEGO
            // TODOS LOS PANELES VUELVEN A COMO ESTABAN
            pan1.BackColor = Color.FromArgb(25, 255, 255); 
            pan2.BackColor = Color.FromArgb(25, 255, 255);
            pan3.BackColor = Color.FromArgb(25, 255, 255);
            pan4.BackColor = Color.FromArgb(25, 255, 255);
            pan5.BackColor = Color.FromArgb(25, 255, 255);
            pan6.BackColor = Color.FromArgb(25, 255, 255);
            if (progres.Value == progres.Maximum) // SI LA BARRA ESTA LLENA, SI GANO EL JUGADOR
            {
                // MANDA UN MENSAJE DE GANASTE
                MessageBox.Show("Winner ", "Ganaste!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // SE USA EL DLL CREADO
                // GUARDA EN VARIABLE NOMBRE EL TEXTO INGRESADO EN EL MENSAJE
                string Nombre = InputDialog.mostrar("Introduce tu nombre");
                ListaNombre.Add(Nombre); // AGREGA EN LA LISTA CREADA EL DATO NOMRBE
                // AGREGA DATOS AL LISTBOX CREADO CON PROPIEDAD ITEMS
                listBoxNombre.Items.Add(Nombre + " ---- " + conteoJuego + " seg" + "----" + dif);
                progres.Value = 0; // BARRA DE PROGRESO EN 0
            }          
            timerConteo.Stop(); // DETIENE EL TIMER CONTADOR QUE LLEVA LA CUENTA DEL TIEMPO QUE SE HIZO
            conteoJuego = 0; // SE REINICIA EL CONTEO
            lblReiniciotimer.Text = "0"; // LABEL INVISIBLE QUE SE APOYA DEL TIMER CONTEO            
        }

        private void chkDetener_CheckedChanged(object sender, EventArgs e)
        {
            DetenerJuego(); // MANDA A LLAMR EL METODO DETENER
        }

        private void pan1_Click(object sender, EventArgs e)
        {
            // AL DAR CLICK EN EL PANEL 1 SI ESTA EN BLANCO ENTRA
            if (pan1.BackColor == Color.FromArgb(255, 255, 255))
            {
                // INCREMENTA EL MARCADOR Y SE LO SUMA A LA BARRA DE PROGRESO
                marcador = 15;
                progres.Increment(marcador);
            }
            else // SI LE DA CLICK Y ESTABA DE OTRO COLOR
            {
                // DECREMENTA EL MARCADOR
                marcador = -25;
                progres.Increment(marcador);
                if (progres.Value == 0) // SI LA BARRA ES 0
                {
                    // MANDA MENSAJE DE PERDER Y MANDA A LLAMAR EL METODO DETENER
                    MessageBox.Show("Has perdido", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DetenerJuego();
                }
            }
            if (progres.Value == progres.Maximum) // SI LA BARRA ESTA LLENA
            {
                DetenerJuego(); // SE DETIENE EL JUEGO
            }
        }

        private void pan2_Click(object sender, EventArgs e)
        {
            if (pan2.BackColor == Color.FromArgb(255, 255, 255))
            {
                marcador = 15;
                progres.Increment(marcador);
            }
            else
            {
                marcador = -25;
                progres.Increment(marcador);
                if (progres.Value == 0)
                {
                    MessageBox.Show("Has perdido", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DetenerJuego();
                }
            }
            if (progres.Value == progres.Maximum)
            {
                DetenerJuego();
            }
        }

        private void pan3_Click(object sender, EventArgs e)
        {
            if (pan3.BackColor == Color.FromArgb(255, 255, 255))
            {
                marcador = 15;
                progres.Increment(marcador);
            }
            else
            {
                marcador = -25;
                progres.Increment(marcador);
                if (progres.Value == 0)
                {
                    MessageBox.Show("Has perdido", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DetenerJuego();
                }
            }
            if (progres.Value == progres.Maximum)
            {
                DetenerJuego();
            }
        }

        private void pan4_Click(object sender, EventArgs e)
        {
            if (pan4.BackColor == Color.FromArgb(255, 255, 255))
            {
                marcador = 15;
                progres.Increment(marcador);
            }
            else
            {
                marcador = -25;
                progres.Increment(marcador);
                if (progres.Value == 0)
                {
                    MessageBox.Show("Has perdido", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DetenerJuego();
                }
            }
            if (progres.Value == progres.Maximum)
            {
                DetenerJuego();
            }
        }

        private void pan5_Click(object sender, EventArgs e)
        {
            if (pan5.BackColor == Color.FromArgb(255, 255, 255))
            {
                marcador = 15;
                progres.Increment(marcador);
            }
            else
            {
                marcador = -25;
                progres.Increment(marcador);
                if (progres.Value == 0)
                {
                    MessageBox.Show("Has perdido", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DetenerJuego();
                }
            }
            if (progres.Value == progres.Maximum)
            {
                DetenerJuego();
            }
        }

        private void pan6_Click(object sender, EventArgs e)
        {
            if (pan6.BackColor == Color.FromArgb(255, 255, 255))
            {
                marcador = 15;
                progres.Increment(marcador);
            }
            else
            {
                marcador = -25;
                progres.Increment(marcador);
                if (progres.Value == 0)
                {
                    MessageBox.Show("Has perdido", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DetenerJuego();
                }
            }
            if (progres.Value == progres.Maximum)
            {
                DetenerJuego();
            }
        }

        private void timerConteo_Tick(object sender, EventArgs e)
        {
            conteoJuego++; // INCREMENTA EL TIEMPO QUE LLEVA LA CUENTA CUANDO SEGANE
        }

        private void chkListo_CheckedChanged(object sender, EventArgs e)
        {
            if (btnRadFacil.Checked == true) // AQUI ENTRA SI ES EN FACIL
            {
                timerPaneles.Start(); // SE INICIA EL TIMER PANELES
                timerConteo.Start(); // SE INICIA EL TIMER CONTEO
                progres.Value = 0; // LA BARRA DE PROGRESO INICIA EN 0
                dif = "facil"; // TEXTO DE DIFICULTAD
            }
            else if (btnRadMedio.Checked == true) // AQUI ENTRA SI ESTA MEDIO 
            {
                timerPaneles.Start(); // SE INICIA EL TIMER PANELES
                timerConteo.Start(); // SE INICIA EL TIMER CONTEO
                progres.Value = 0; // LA BARRA DE PROGRESO INICIA EN 0
                dif = "Medio"; // TEXTO DE DIFICULTAD
            }
            else if (btnRadDificil.Checked == true) // SI EL BOTON SELECCIONADO DIFICIL ENTRA AQUI
            {
                timerPaneles.Start(); // SE INICIA EL TIMER PANELES 
                timerConteo.Start(); // SE INICIA EL TIMER CONTEO
                progres.Value = 0; // LA BARRA DE PROGRESO INICIA EN 0
                dif = "Dificil"; // TEXTO DE DIFICULTAD
            }
            else // SI NO FUE SELECCIONADO NADA MANDA MENSAJE
            {
                MessageBox.Show("Elija nivel de dificultad");

            }
        }

       
    }
}