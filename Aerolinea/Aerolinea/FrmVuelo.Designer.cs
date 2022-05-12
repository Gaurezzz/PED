namespace Aerolinea
{
    partial class FrmVuelo
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
            this.btnASQL = new System.Windows.Forms.Button();
            this.lblLocalizacion = new System.Windows.Forms.Label();
            this.pnlDibujo = new System.Windows.Forms.PictureBox();
            this.pnlEntrada = new System.Windows.Forms.Panel();
            this.btnUbicar = new System.Windows.Forms.PictureBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.cmbNodo2 = new System.Windows.Forms.ComboBox();
            this.cmbNodo1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDibujo)).BeginInit();
            this.pnlEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUbicar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnASQL);
            this.panel1.Controls.Add(this.lblLocalizacion);
            this.panel1.Controls.Add(this.pnlDibujo);
            this.panel1.Controls.Add(this.pnlEntrada);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 457);
            this.panel1.TabIndex = 4;
            // 
            // btnASQL
            // 
            this.btnASQL.Location = new System.Drawing.Point(649, 157);
            this.btnASQL.Name = "btnASQL";
            this.btnASQL.Size = new System.Drawing.Size(75, 23);
            this.btnASQL.TabIndex = 9;
            this.btnASQL.Text = "IniciarSQL";
            this.btnASQL.UseVisualStyleBackColor = true;
            this.btnASQL.Click += new System.EventHandler(this.btnASQL_Click);
            // 
            // lblLocalizacion
            // 
            this.lblLocalizacion.AutoSize = true;
            this.lblLocalizacion.Location = new System.Drawing.Point(646, 135);
            this.lblLocalizacion.Name = "lblLocalizacion";
            this.lblLocalizacion.Size = new System.Drawing.Size(0, 15);
            this.lblLocalizacion.TabIndex = 8;
            // 
            // pnlDibujo
            // 
            this.pnlDibujo.Image = global::Aerolinea.Properties.Resources.mundi;
            this.pnlDibujo.Location = new System.Drawing.Point(129, 146);
            this.pnlDibujo.Name = "pnlDibujo";
            this.pnlDibujo.Size = new System.Drawing.Size(487, 276);
            this.pnlDibujo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pnlDibujo.TabIndex = 7;
            this.pnlDibujo.TabStop = false;
            this.pnlDibujo.VisibleChanged += new System.EventHandler(this.pnlDibujo_VisibleChanged_1);
            this.pnlDibujo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDibujo_MouseMove);
            // 
            // pnlEntrada
            // 
            this.pnlEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.pnlEntrada.Controls.Add(this.btnUbicar);
            this.pnlEntrada.Controls.Add(this.txtCosto);
            this.pnlEntrada.Controls.Add(this.cmbNodo2);
            this.pnlEntrada.Controls.Add(this.cmbNodo1);
            this.pnlEntrada.Location = new System.Drawing.Point(0, 0);
            this.pnlEntrada.Name = "pnlEntrada";
            this.pnlEntrada.Size = new System.Drawing.Size(749, 118);
            this.pnlEntrada.TabIndex = 6;
            // 
            // btnUbicar
            // 
            this.btnUbicar.Image = global::Aerolinea.Properties.Resources.btnUbicar1;
            this.btnUbicar.Location = new System.Drawing.Point(577, 40);
            this.btnUbicar.Name = "btnUbicar";
            this.btnUbicar.Size = new System.Drawing.Size(143, 41);
            this.btnUbicar.TabIndex = 3;
            this.btnUbicar.TabStop = false;
            this.btnUbicar.Click += new System.EventHandler(this.btnUbicar_Click);
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(30, 78);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(522, 21);
            this.txtCosto.TabIndex = 2;
            // 
            // cmbNodo2
            // 
            this.cmbNodo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNodo2.FormattingEnabled = true;
            this.cmbNodo2.Location = new System.Drawing.Point(30, 49);
            this.cmbNodo2.Name = "cmbNodo2";
            this.cmbNodo2.Size = new System.Drawing.Size(522, 23);
            this.cmbNodo2.TabIndex = 1;
            // 
            // cmbNodo1
            // 
            this.cmbNodo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNodo1.FormattingEnabled = true;
            this.cmbNodo1.Location = new System.Drawing.Point(30, 20);
            this.cmbNodo1.Name = "cmbNodo1";
            this.cmbNodo1.Size = new System.Drawing.Size(522, 23);
            this.cmbNodo1.TabIndex = 0;
            // 
            // FrmVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(770, 457);
            this.Controls.Add(this.panel1);
            this.Name = "FrmVuelo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDibujo)).EndInit();
            this.pnlEntrada.ResumeLayout(false);
            this.pnlEntrada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUbicar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlEntrada;
        private System.Windows.Forms.ComboBox cmbNodo1;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.ComboBox cmbNodo2;
        private System.Windows.Forms.PictureBox btnUbicar;
        private System.Windows.Forms.Label lblLocalizacion;
        public System.Windows.Forms.PictureBox pnlDibujo;
        private System.Windows.Forms.Button btnASQL;
    }
}
