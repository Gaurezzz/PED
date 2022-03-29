namespace Aerolinea
{
    partial class frmPais
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLocalizacion = new System.Windows.Forms.Label();
            this.lblaristas = new System.Windows.Forms.Label();
            this.lblvertices = new System.Windows.Forms.Label();
            this.pnlDibujo = new System.Windows.Forms.PictureBox();
            this.lblprueba = new System.Windows.Forms.Label();
            this.pnlEntrada = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDibujo)).BeginInit();
            this.pnlEntrada.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLocalizacion);
            this.panel1.Controls.Add(this.lblaristas);
            this.panel1.Controls.Add(this.lblvertices);
            this.panel1.Controls.Add(this.pnlDibujo);
            this.panel1.Controls.Add(this.lblprueba);
            this.panel1.Controls.Add(this.pnlEntrada);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 457);
            this.panel1.TabIndex = 3;
            // 
            // lblLocalizacion
            // 
            this.lblLocalizacion.AutoSize = true;
            this.lblLocalizacion.Location = new System.Drawing.Point(646, 135);
            this.lblLocalizacion.Name = "lblLocalizacion";
            this.lblLocalizacion.Size = new System.Drawing.Size(0, 15);
            this.lblLocalizacion.TabIndex = 10;
            // 
            // lblaristas
            // 
            this.lblaristas.AutoSize = true;
            this.lblaristas.Location = new System.Drawing.Point(12, 433);
            this.lblaristas.Name = "lblaristas";
            this.lblaristas.Size = new System.Drawing.Size(58, 15);
            this.lblaristas.TabIndex = 7;
            this.lblaristas.Text = "ARISTAS:";
            // 
            // lblvertices
            // 
            this.lblvertices.AutoSize = true;
            this.lblvertices.Location = new System.Drawing.Point(12, 408);
            this.lblvertices.Name = "lblvertices";
            this.lblvertices.Size = new System.Drawing.Size(69, 15);
            this.lblvertices.TabIndex = 6;
            this.lblvertices.Text = "VERTICES:";
            // 
            // pnlDibujo
            // 
            this.pnlDibujo.Image = global::Aerolinea.Properties.Resources.mapabase1;
            this.pnlDibujo.Location = new System.Drawing.Point(0, 118);
            this.pnlDibujo.Name = "pnlDibujo";
            this.pnlDibujo.Size = new System.Drawing.Size(749, 339);
            this.pnlDibujo.TabIndex = 5;
            this.pnlDibujo.TabStop = false;
            this.pnlDibujo.VisibleChanged += new System.EventHandler(this.pnlDibujo_VisibleChanged);
            this.pnlDibujo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDibujo_Paint);
            this.pnlDibujo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDibujo_MouseDown);
            this.pnlDibujo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDibujo_MouseMove);
            // 
            // lblprueba
            // 
            this.lblprueba.AutoSize = true;
            this.lblprueba.ForeColor = System.Drawing.Color.White;
            this.lblprueba.Location = new System.Drawing.Point(686, 433);
            this.lblprueba.Name = "lblprueba";
            this.lblprueba.Size = new System.Drawing.Size(0, 15);
            this.lblprueba.TabIndex = 1;
            // 
            // pnlEntrada
            // 
            this.pnlEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.pnlEntrada.Controls.Add(this.panel2);
            this.pnlEntrada.Location = new System.Drawing.Point(0, 0);
            this.pnlEntrada.Name = "pnlEntrada";
            this.pnlEntrada.Size = new System.Drawing.Size(749, 118);
            this.pnlEntrada.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtPais);
            this.panel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(23, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 40);
            this.panel2.TabIndex = 1;
            // 
            // txtPais
            // 
            this.txtPais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPais.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPais.ForeColor = System.Drawing.Color.Gray;
            this.txtPais.Location = new System.Drawing.Point(15, 11);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(527, 18);
            this.txtPais.TabIndex = 0;
            this.txtPais.Text = "Introduzca el nombre del país a agregar";
            this.txtPais.Enter += new System.EventHandler(this.txtPais_Enter);
            // 
            // frmPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(749, 457);
            this.Controls.Add(this.panel1);
            this.Name = "frmPais";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDibujo)).EndInit();
            this.pnlEntrada.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlEntrada;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPais;
        public System.Windows.Forms.Label lblprueba;
        public System.Windows.Forms.PictureBox pnlDibujo;
        private System.Windows.Forms.Label lblaristas;
        private System.Windows.Forms.Label lblvertices;
        private System.Windows.Forms.Label lblLocalizacion;
    }
}
