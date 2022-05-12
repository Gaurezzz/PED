namespace Aerolinea
{
    partial class frmCrear
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminarC = new System.Windows.Forms.Button();
            this.cmbNodo3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.pnlDibujo = new System.Windows.Forms.PictureBox();
            this.pnlEntrada = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.PictureBox();
            this.btnCRuta = new System.Windows.Forms.PictureBox();
            this.cmbNodo2 = new System.Windows.Forms.ComboBox();
            this.cmbNodo1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDibujo)).BeginInit();
            this.pnlEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCRuta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnlDibujo);
            this.panel1.Controls.Add(this.pnlEntrada);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 458);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.btnEliminarC);
            this.panel2.Controls.Add(this.cmbNodo3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cantidad);
            this.panel2.Controls.Add(this.listBox);
            this.panel2.Location = new System.Drawing.Point(548, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 339);
            this.panel2.TabIndex = 9;
            // 
            // btnEliminarC
            // 
            this.btnEliminarC.BackColor = System.Drawing.Color.Turquoise;
            this.btnEliminarC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarC.Location = new System.Drawing.Point(111, 283);
            this.btnEliminarC.Name = "btnEliminarC";
            this.btnEliminarC.Size = new System.Drawing.Size(86, 44);
            this.btnEliminarC.TabIndex = 15;
            this.btnEliminarC.Text = "Eliminar Componente";
            this.btnEliminarC.UseVisualStyleBackColor = false;
            this.btnEliminarC.Click += new System.EventHandler(this.btnEliminarC_Click);
            // 
            // cmbNodo3
            // 
            this.cmbNodo3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNodo3.FormattingEnabled = true;
            this.cmbNodo3.Location = new System.Drawing.Point(3, 292);
            this.cmbNodo3.Name = "cmbNodo3";
            this.cmbNodo3.Size = new System.Drawing.Size(102, 23);
            this.cmbNodo3.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Peso total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "RUTA";
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(81, 254);
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Size = new System.Drawing.Size(108, 21);
            this.cantidad.TabIndex = 11;
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.Silver;
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(13, 35);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(176, 210);
            this.listBox.TabIndex = 10;
            // 
            // pnlDibujo
            // 
            this.pnlDibujo.Image = global::Aerolinea.Properties.Resources.mundi;
            this.pnlDibujo.Location = new System.Drawing.Point(30, 145);
            this.pnlDibujo.Name = "pnlDibujo";
            this.pnlDibujo.Size = new System.Drawing.Size(487, 276);
            this.pnlDibujo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pnlDibujo.TabIndex = 8;
            this.pnlDibujo.TabStop = false;
            this.pnlDibujo.VisibleChanged += new System.EventHandler(this.pnlDibujo_VisibleChanged);
            // 
            // pnlEntrada
            // 
            this.pnlEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.pnlEntrada.Controls.Add(this.label3);
            this.pnlEntrada.Controls.Add(this.btnLimpiar);
            this.pnlEntrada.Controls.Add(this.btnCRuta);
            this.pnlEntrada.Controls.Add(this.cmbNodo2);
            this.pnlEntrada.Controls.Add(this.cmbNodo1);
            this.pnlEntrada.Location = new System.Drawing.Point(0, 0);
            this.pnlEntrada.Name = "pnlEntrada";
            this.pnlEntrada.Size = new System.Drawing.Size(749, 118);
            this.pnlEntrada.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::Aerolinea.Properties.Resources.limpiar1;
            this.btnLimpiar.Location = new System.Drawing.Point(610, 41);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(127, 39);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.TabStop = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCRuta
            // 
            this.btnCRuta.Image = global::Aerolinea.Properties.Resources.cr1;
            this.btnCRuta.Location = new System.Drawing.Point(477, 41);
            this.btnCRuta.Name = "btnCRuta";
            this.btnCRuta.Size = new System.Drawing.Size(127, 39);
            this.btnCRuta.TabIndex = 4;
            this.btnCRuta.TabStop = false;
            this.btnCRuta.Click += new System.EventHandler(this.btnCRuta_Click);
            // 
            // cmbNodo2
            // 
            this.cmbNodo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNodo2.FormattingEnabled = true;
            this.cmbNodo2.Location = new System.Drawing.Point(30, 81);
            this.cmbNodo2.Name = "cmbNodo2";
            this.cmbNodo2.Size = new System.Drawing.Size(427, 23);
            this.cmbNodo2.TabIndex = 1;
            // 
            // cmbNodo1
            // 
            this.cmbNodo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNodo1.FormattingEnabled = true;
            this.cmbNodo1.Location = new System.Drawing.Point(30, 52);
            this.cmbNodo1.Name = "cmbNodo1";
            this.cmbNodo1.Size = new System.Drawing.Size(427, 23);
            this.cmbNodo1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(27, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(392, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seleccione la ciudad de partida y la ciudad de llegada: ";
            // 
            // frmCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(749, 457);
            this.Controls.Add(this.panel1);
            this.Name = "frmCrear";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDibujo)).EndInit();
            this.pnlEntrada.ResumeLayout(false);
            this.pnlEntrada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCRuta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlEntrada;
        private System.Windows.Forms.ComboBox cmbNodo2;
        private System.Windows.Forms.ComboBox cmbNodo1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.PictureBox pnlDibujo;
        private System.Windows.Forms.PictureBox btnCRuta;
        private System.Windows.Forms.PictureBox btnLimpiar;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNodo3;
        private System.Windows.Forms.Button btnEliminarC;
        private System.Windows.Forms.Label label3;
    }
}
