namespace EstructuraV_1._0
{
    partial class UnidadI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnidadI));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panMemoria = new System.Windows.Forms.Panel();
            this.lblMemoria = new System.Windows.Forms.Label();
            this.picMemoria = new System.Windows.Forms.PictureBox();
            this.panPuntero = new System.Windows.Forms.Panel();
            this.lblPuntero = new System.Windows.Forms.Label();
            this.picPuntero = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panMemoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMemoria)).BeginInit();
            this.panPuntero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPuntero)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCerrar);
            this.panel3.Controls.Add(this.panMemoria);
            this.panel3.Controls.Add(this.panPuntero);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1270, 638);
            this.panel3.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(1221, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(37, 37);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panMemoria
            // 
            this.panMemoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
            this.panMemoria.Controls.Add(this.lblMemoria);
            this.panMemoria.Controls.Add(this.picMemoria);
            this.panMemoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panMemoria.Location = new System.Drawing.Point(610, 46);
            this.panMemoria.Name = "panMemoria";
            this.panMemoria.Size = new System.Drawing.Size(386, 209);
            this.panMemoria.TabIndex = 2;
            this.panMemoria.MouseEnter += new System.EventHandler(this.panMemoria_MouseEnter);
            this.panMemoria.MouseLeave += new System.EventHandler(this.panMemoria_MouseLeave);
            // 
            // lblMemoria
            // 
            this.lblMemoria.AutoSize = true;
            this.lblMemoria.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemoria.ForeColor = System.Drawing.Color.White;
            this.lblMemoria.Location = new System.Drawing.Point(108, 157);
            this.lblMemoria.Name = "lblMemoria";
            this.lblMemoria.Size = new System.Drawing.Size(190, 25);
            this.lblMemoria.TabIndex = 1;
            this.lblMemoria.Text = "Memoria dinámica";
            // 
            // picMemoria
            // 
            this.picMemoria.Image = ((System.Drawing.Image)(resources.GetObject("picMemoria.Image")));
            this.picMemoria.Location = new System.Drawing.Point(150, 24);
            this.picMemoria.Name = "picMemoria";
            this.picMemoria.Size = new System.Drawing.Size(100, 100);
            this.picMemoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMemoria.TabIndex = 0;
            this.picMemoria.TabStop = false;
            // 
            // panPuntero
            // 
            this.panPuntero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
            this.panPuntero.Controls.Add(this.lblPuntero);
            this.panPuntero.Controls.Add(this.picPuntero);
            this.panPuntero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panPuntero.Location = new System.Drawing.Point(95, 46);
            this.panPuntero.Name = "panPuntero";
            this.panPuntero.Size = new System.Drawing.Size(386, 209);
            this.panPuntero.TabIndex = 0;
            this.panPuntero.Click += new System.EventHandler(this.panPuntero_Click);
            this.panPuntero.MouseEnter += new System.EventHandler(this.panPuntero_MouseEnter);
            this.panPuntero.MouseLeave += new System.EventHandler(this.panPuntero_MouseLeave);
            // 
            // lblPuntero
            // 
            this.lblPuntero.AutoSize = true;
            this.lblPuntero.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntero.ForeColor = System.Drawing.Color.White;
            this.lblPuntero.Location = new System.Drawing.Point(148, 157);
            this.lblPuntero.Name = "lblPuntero";
            this.lblPuntero.Size = new System.Drawing.Size(87, 25);
            this.lblPuntero.TabIndex = 1;
            this.lblPuntero.Text = "Puntero";
            // 
            // picPuntero
            // 
            this.picPuntero.Image = ((System.Drawing.Image)(resources.GetObject("picPuntero.Image")));
            this.picPuntero.Location = new System.Drawing.Point(150, 24);
            this.picPuntero.Name = "picPuntero";
            this.picPuntero.Size = new System.Drawing.Size(100, 100);
            this.picPuntero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPuntero.TabIndex = 0;
            this.picPuntero.TabStop = false;
            // 
            // UnidadI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1270, 638);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UnidadI";
            this.Text = "UnidadI";
            this.panel3.ResumeLayout(false);
            this.panMemoria.ResumeLayout(false);
            this.panMemoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMemoria)).EndInit();
            this.panPuntero.ResumeLayout(false);
            this.panPuntero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPuntero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panPuntero;
        private System.Windows.Forms.Label lblPuntero;
        private System.Windows.Forms.PictureBox picPuntero;
        private System.Windows.Forms.Panel panMemoria;
        private System.Windows.Forms.Label lblMemoria;
        private System.Windows.Forms.PictureBox picMemoria;
        private System.Windows.Forms.Button btnCerrar;
    }
}