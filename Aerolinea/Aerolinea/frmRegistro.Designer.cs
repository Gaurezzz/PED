namespace Aerolinea
{
    partial class frmRegistro
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
            this.DgvMatriz = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.lbxAristas = new System.Windows.Forms.ListBox();
            this.lbxVertices = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvMatriz);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnactualizar);
            this.panel1.Controls.Add(this.Label);
            this.panel1.Controls.Add(this.lbxAristas);
            this.panel1.Controls.Add(this.lbxVertices);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 457);
            this.panel1.TabIndex = 4;
            // 
            // DgvMatriz
            // 
            this.DgvMatriz.AllowUserToAddRows = false;
            this.DgvMatriz.AllowUserToDeleteRows = false;
            this.DgvMatriz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvMatriz.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvMatriz.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMatriz.Location = new System.Drawing.Point(115, 278);
            this.DgvMatriz.Name = "DgvMatriz";
            this.DgvMatriz.ReadOnly = true;
            this.DgvMatriz.Size = new System.Drawing.Size(504, 150);
            this.DgvMatriz.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(221, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "MATRIZ DE ADYACENCIA";
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnactualizar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnactualizar.Location = new System.Drawing.Point(296, 66);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(146, 39);
            this.btnactualizar.TabIndex = 3;
            this.btnactualizar.Text = "Actualizar Registros";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label.Location = new System.Drawing.Point(291, 17);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(154, 29);
            this.Label.TabIndex = 2;
            this.Label.Text = "REGISTROS";
            // 
            // lbxAristas
            // 
            this.lbxAristas.FormattingEnabled = true;
            this.lbxAristas.ItemHeight = 15;
            this.lbxAristas.Location = new System.Drawing.Point(420, 125);
            this.lbxAristas.Name = "lbxAristas";
            this.lbxAristas.Size = new System.Drawing.Size(280, 94);
            this.lbxAristas.TabIndex = 1;
            // 
            // lbxVertices
            // 
            this.lbxVertices.FormattingEnabled = true;
            this.lbxVertices.ItemHeight = 15;
            this.lbxVertices.Location = new System.Drawing.Point(16, 125);
            this.lbxVertices.Name = "lbxVertices";
            this.lbxVertices.Size = new System.Drawing.Size(280, 94);
            this.lbxVertices.TabIndex = 0;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(749, 457);
            this.Controls.Add(this.panel1);
            this.Name = "frmRegistro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMatriz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbxAristas;
        private System.Windows.Forms.ListBox lbxVertices;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.DataGridView DgvMatriz;
        private System.Windows.Forms.Label label1;
    }
}
