namespace EstructuraV_1._0
{
    partial class FrBlanco
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerPaneles = new System.Windows.Forms.Timer(this.components);
            this.timerConteo = new System.Windows.Forms.Timer(this.components);
            this.panContenedor = new System.Windows.Forms.Panel();
            this.lblConteo = new System.Windows.Forms.Label();
            this.lblReiniciotimer = new System.Windows.Forms.Label();
            this.lblTiempoPunt = new System.Windows.Forms.Label();
            this.lblTiempoConteo = new System.Windows.Forms.Label();
            this.progres = new System.Windows.Forms.ProgressBar();
            this.pan6 = new System.Windows.Forms.Panel();
            this.pan5 = new System.Windows.Forms.Panel();
            this.pan4 = new System.Windows.Forms.Panel();
            this.pan3 = new System.Windows.Forms.Panel();
            this.pan2 = new System.Windows.Forms.Panel();
            this.pan1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBoxNombre = new System.Windows.Forms.ListBox();
            this.lblEstadisicas = new System.Windows.Forms.Label();
            this.panNivel = new System.Windows.Forms.Panel();
            this.chkListo = new System.Windows.Forms.CheckBox();
            this.chkDetener = new System.Windows.Forms.CheckBox();
            this.btnRadDificil = new System.Windows.Forms.RadioButton();
            this.btnRadMedio = new System.Windows.Forms.RadioButton();
            this.btnRadFacil = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panContenedor.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panNivel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerPaneles
            // 
            this.timerPaneles.Interval = 1000;
            this.timerPaneles.Tick += new System.EventHandler(this.timerPaneles_Tick);
            // 
            // timerConteo
            // 
            this.timerConteo.Interval = 1000;
            this.timerConteo.Tick += new System.EventHandler(this.timerConteo_Tick);
            // 
            // panContenedor
            // 
            this.panContenedor.Controls.Add(this.lblConteo);
            this.panContenedor.Controls.Add(this.lblReiniciotimer);
            this.panContenedor.Controls.Add(this.lblTiempoPunt);
            this.panContenedor.Controls.Add(this.lblTiempoConteo);
            this.panContenedor.Controls.Add(this.progres);
            this.panContenedor.Controls.Add(this.pan6);
            this.panContenedor.Controls.Add(this.pan5);
            this.panContenedor.Controls.Add(this.pan4);
            this.panContenedor.Controls.Add(this.pan3);
            this.panContenedor.Controls.Add(this.pan2);
            this.panContenedor.Controls.Add(this.pan1);
            this.panContenedor.Controls.Add(this.panel2);
            this.panContenedor.Controls.Add(this.panNivel);
            this.panContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContenedor.Location = new System.Drawing.Point(0, 0);
            this.panContenedor.Name = "panContenedor";
            this.panContenedor.Size = new System.Drawing.Size(1270, 638);
            this.panContenedor.TabIndex = 0;
            // 
            // lblConteo
            // 
            this.lblConteo.AutoSize = true;
            this.lblConteo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConteo.ForeColor = System.Drawing.Color.White;
            this.lblConteo.Location = new System.Drawing.Point(300, 483);
            this.lblConteo.Name = "lblConteo";
            this.lblConteo.Size = new System.Drawing.Size(140, 27);
            this.lblConteo.TabIndex = 12;
            this.lblConteo.Text = "Estadisticas";
            // 
            // lblReiniciotimer
            // 
            this.lblReiniciotimer.AutoSize = true;
            this.lblReiniciotimer.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReiniciotimer.ForeColor = System.Drawing.Color.White;
            this.lblReiniciotimer.Location = new System.Drawing.Point(280, 599);
            this.lblReiniciotimer.Name = "lblReiniciotimer";
            this.lblReiniciotimer.Size = new System.Drawing.Size(155, 27);
            this.lblReiniciotimer.TabIndex = 20;
            this.lblReiniciotimer.Text = "ReinicioTimer";
            this.lblReiniciotimer.Visible = false;
            // 
            // lblTiempoPunt
            // 
            this.lblTiempoPunt.AutoSize = true;
            this.lblTiempoPunt.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoPunt.ForeColor = System.Drawing.Color.White;
            this.lblTiempoPunt.Location = new System.Drawing.Point(300, 527);
            this.lblTiempoPunt.Name = "lblTiempoPunt";
            this.lblTiempoPunt.Size = new System.Drawing.Size(97, 27);
            this.lblTiempoPunt.TabIndex = 22;
            this.lblTiempoPunt.Text = "Tiempo:";
            this.lblTiempoPunt.Visible = false;
            // 
            // lblTiempoConteo
            // 
            this.lblTiempoConteo.AutoSize = true;
            this.lblTiempoConteo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoConteo.ForeColor = System.Drawing.Color.White;
            this.lblTiempoConteo.Location = new System.Drawing.Point(403, 527);
            this.lblTiempoConteo.Name = "lblTiempoConteo";
            this.lblTiempoConteo.Size = new System.Drawing.Size(90, 27);
            this.lblTiempoConteo.TabIndex = 18;
            this.lblTiempoConteo.Text = "Tiempo";
            // 
            // progres
            // 
            this.progres.Location = new System.Drawing.Point(444, 438);
            this.progres.Name = "progres";
            this.progres.Size = new System.Drawing.Size(482, 23);
            this.progres.TabIndex = 21;
            // 
            // pan6
            // 
            this.pan6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pan6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pan6.Location = new System.Drawing.Point(835, 210);
            this.pan6.Name = "pan6";
            this.pan6.Size = new System.Drawing.Size(200, 157);
            this.pan6.TabIndex = 19;
            this.pan6.Click += new System.EventHandler(this.pan6_Click);
            // 
            // pan5
            // 
            this.pan5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pan5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pan5.Location = new System.Drawing.Point(835, 12);
            this.pan5.Name = "pan5";
            this.pan5.Size = new System.Drawing.Size(200, 157);
            this.pan5.TabIndex = 17;
            this.pan5.Click += new System.EventHandler(this.pan5_Click);
            // 
            // pan4
            // 
            this.pan4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pan4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pan4.Location = new System.Drawing.Point(590, 210);
            this.pan4.Name = "pan4";
            this.pan4.Size = new System.Drawing.Size(200, 157);
            this.pan4.TabIndex = 16;
            this.pan4.Click += new System.EventHandler(this.pan4_Click);
            // 
            // pan3
            // 
            this.pan3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pan3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pan3.Location = new System.Drawing.Point(590, 12);
            this.pan3.Name = "pan3";
            this.pan3.Size = new System.Drawing.Size(200, 157);
            this.pan3.TabIndex = 15;
            this.pan3.Click += new System.EventHandler(this.pan3_Click);
            // 
            // pan2
            // 
            this.pan2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pan2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pan2.Location = new System.Drawing.Point(340, 210);
            this.pan2.Name = "pan2";
            this.pan2.Size = new System.Drawing.Size(200, 157);
            this.pan2.TabIndex = 14;
            this.pan2.Click += new System.EventHandler(this.pan2_Click);
            // 
            // pan1
            // 
            this.pan1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pan1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pan1.Location = new System.Drawing.Point(340, 12);
            this.pan1.Name = "pan1";
            this.pan1.Size = new System.Drawing.Size(200, 157);
            this.pan1.TabIndex = 13;
            this.pan1.Click += new System.EventHandler(this.pan1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.listBoxNombre);
            this.panel2.Controls.Add(this.lblEstadisicas);
            this.panel2.Location = new System.Drawing.Point(12, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 266);
            this.panel2.TabIndex = 11;
            // 
            // listBoxNombre
            // 
            this.listBoxNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNombre.FormattingEnabled = true;
            this.listBoxNombre.ItemHeight = 18;
            this.listBoxNombre.Location = new System.Drawing.Point(3, 45);
            this.listBoxNombre.Name = "listBoxNombre";
            this.listBoxNombre.Size = new System.Drawing.Size(252, 202);
            this.listBoxNombre.TabIndex = 9;
            // 
            // lblEstadisicas
            // 
            this.lblEstadisicas.AutoSize = true;
            this.lblEstadisicas.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadisicas.ForeColor = System.Drawing.Color.White;
            this.lblEstadisicas.Location = new System.Drawing.Point(59, 15);
            this.lblEstadisicas.Name = "lblEstadisicas";
            this.lblEstadisicas.Size = new System.Drawing.Size(140, 27);
            this.lblEstadisicas.TabIndex = 5;
            this.lblEstadisicas.Text = "Estadisticas";
            // 
            // panNivel
            // 
            this.panNivel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panNivel.Controls.Add(this.chkListo);
            this.panNivel.Controls.Add(this.chkDetener);
            this.panNivel.Controls.Add(this.btnRadDificil);
            this.panNivel.Controls.Add(this.btnRadMedio);
            this.panNivel.Controls.Add(this.btnRadFacil);
            this.panNivel.Controls.Add(this.label1);
            this.panNivel.Location = new System.Drawing.Point(12, 12);
            this.panNivel.Name = "panNivel";
            this.panNivel.Size = new System.Drawing.Size(262, 290);
            this.panNivel.TabIndex = 10;
            // 
            // chkListo
            // 
            this.chkListo.AutoSize = true;
            this.chkListo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListo.ForeColor = System.Drawing.Color.White;
            this.chkListo.Location = new System.Drawing.Point(34, 196);
            this.chkListo.Name = "chkListo";
            this.chkListo.Size = new System.Drawing.Size(178, 29);
            this.chkListo.TabIndex = 4;
            this.chkListo.Text = "Are you ready?";
            this.chkListo.UseVisualStyleBackColor = true;
            this.chkListo.CheckedChanged += new System.EventHandler(this.chkListo_CheckedChanged);
            // 
            // chkDetener
            // 
            this.chkDetener.AutoSize = true;
            this.chkDetener.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDetener.ForeColor = System.Drawing.Color.White;
            this.chkDetener.Location = new System.Drawing.Point(34, 244);
            this.chkDetener.Name = "chkDetener";
            this.chkDetener.Size = new System.Drawing.Size(107, 29);
            this.chkDetener.TabIndex = 5;
            this.chkDetener.Text = "Detener";
            this.chkDetener.UseVisualStyleBackColor = true;
            this.chkDetener.Click += new System.EventHandler(this.timerPaneles_Tick);
            // 
            // btnRadDificil
            // 
            this.btnRadDificil.AutoSize = true;
            this.btnRadDificil.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRadDificil.ForeColor = System.Drawing.Color.White;
            this.btnRadDificil.Location = new System.Drawing.Point(34, 146);
            this.btnRadDificil.Name = "btnRadDificil";
            this.btnRadDificil.Size = new System.Drawing.Size(83, 29);
            this.btnRadDificil.TabIndex = 3;
            this.btnRadDificil.TabStop = true;
            this.btnRadDificil.Text = "Dificil";
            this.btnRadDificil.UseVisualStyleBackColor = true;
            // 
            // btnRadMedio
            // 
            this.btnRadMedio.AutoSize = true;
            this.btnRadMedio.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRadMedio.ForeColor = System.Drawing.Color.White;
            this.btnRadMedio.Location = new System.Drawing.Point(34, 101);
            this.btnRadMedio.Name = "btnRadMedio";
            this.btnRadMedio.Size = new System.Drawing.Size(91, 29);
            this.btnRadMedio.TabIndex = 2;
            this.btnRadMedio.TabStop = true;
            this.btnRadMedio.Text = "Medio";
            this.btnRadMedio.UseVisualStyleBackColor = true;
            // 
            // btnRadFacil
            // 
            this.btnRadFacil.AutoSize = true;
            this.btnRadFacil.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRadFacil.ForeColor = System.Drawing.Color.White;
            this.btnRadFacil.Location = new System.Drawing.Point(34, 57);
            this.btnRadFacil.Name = "btnRadFacil";
            this.btnRadFacil.Size = new System.Drawing.Size(75, 29);
            this.btnRadFacil.TabIndex = 1;
            this.btnRadFacil.TabStop = true;
            this.btnRadFacil.Text = "Facil";
            this.btnRadFacil.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nivel de dificultad";
            // 
            // FrBlanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1270, 638);
            this.Controls.Add(this.panContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrBlanco";
            this.Text = "FrBlanco";
            this.panContenedor.ResumeLayout(false);
            this.panContenedor.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panNivel.ResumeLayout(false);
            this.panNivel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerPaneles;
        private System.Windows.Forms.Timer timerConteo;
        private System.Windows.Forms.Panel panContenedor;
        private System.Windows.Forms.Label lblConteo;
        private System.Windows.Forms.Label lblReiniciotimer;
        private System.Windows.Forms.Label lblTiempoPunt;
        private System.Windows.Forms.Label lblTiempoConteo;
        private System.Windows.Forms.ProgressBar progres;
        private System.Windows.Forms.Panel pan6;
        private System.Windows.Forms.Panel pan5;
        private System.Windows.Forms.Panel pan4;
        private System.Windows.Forms.Panel pan3;
        private System.Windows.Forms.Panel pan2;
        private System.Windows.Forms.Panel pan1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBoxNombre;
        private System.Windows.Forms.Label lblEstadisicas;
        private System.Windows.Forms.Panel panNivel;
        private System.Windows.Forms.CheckBox chkListo;
        private System.Windows.Forms.CheckBox chkDetener;
        private System.Windows.Forms.RadioButton btnRadDificil;
        private System.Windows.Forms.RadioButton btnRadMedio;
        private System.Windows.Forms.RadioButton btnRadFacil;
        private System.Windows.Forms.Label label1;
    }
}