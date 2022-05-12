namespace Aerolinea
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pctMin = new System.Windows.Forms.PictureBox();
            this.pctCerrar = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pctRegistro = new System.Windows.Forms.PictureBox();
            this.pctCrear = new System.Windows.Forms.PictureBox();
            this.pctRutas = new System.Windows.Forms.PictureBox();
            this.pctVueloDirecto = new System.Windows.Forms.PictureBox();
            this.pctPais = new System.Windows.Forms.PictureBox();
            this.pctAgregar = new System.Windows.Forms.PictureBox();
            this.pctLogo1 = new System.Windows.Forms.PictureBox();
            this.SQLWaitTime = new System.Windows.Forms.Timer(this.components);
            this.pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCerrar)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCrear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVueloDirecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.pnlBarra.Controls.Add(this.panel1);
            this.pnlBarra.Controls.Add(this.pctMin);
            this.pnlBarra.Controls.Add(this.pctCerrar);
            this.pnlBarra.Location = new System.Drawing.Point(0, 0);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(1000, 43);
            this.pnlBarra.TabIndex = 0;
            this.pnlBarra.Click += new System.EventHandler(this.pnlBarra_Click);
            this.pnlBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarra_MouseDown);
            this.pnlBarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBarra_MouseMove);
            this.pnlBarra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBarra_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(257, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 156);
            this.panel1.TabIndex = 2;
            // 
            // pctMin
            // 
            this.pctMin.Image = global::Aerolinea.Properties.Resources.min1;
            this.pctMin.Location = new System.Drawing.Point(915, 0);
            this.pctMin.Name = "pctMin";
            this.pctMin.Size = new System.Drawing.Size(41, 43);
            this.pctMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMin.TabIndex = 2;
            this.pctMin.TabStop = false;
            this.pctMin.Click += new System.EventHandler(this.pctMin_Click);
            this.pctMin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctMin_MouseDown);
            this.pctMin.MouseEnter += new System.EventHandler(this.pctMin_MouseEnter);
            this.pctMin.MouseLeave += new System.EventHandler(this.pctMin_MouseLeave);
            this.pctMin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctMin_MouseUp);
            // 
            // pctCerrar
            // 
            this.pctCerrar.Image = global::Aerolinea.Properties.Resources.close1;
            this.pctCerrar.Location = new System.Drawing.Point(957, 0);
            this.pctCerrar.Name = "pctCerrar";
            this.pctCerrar.Size = new System.Drawing.Size(43, 43);
            this.pctCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCerrar.TabIndex = 1;
            this.pctCerrar.TabStop = false;
            this.pctCerrar.Click += new System.EventHandler(this.pctCerrar_Click);
            this.pctCerrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctCerrar_MouseDown);
            this.pctCerrar.MouseEnter += new System.EventHandler(this.pctCerrar_MouseEnter);
            this.pctCerrar.MouseLeave += new System.EventHandler(this.pctCerrar_MouseLeave);
            this.pctCerrar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctCerrar_MouseUp);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.pctRegistro);
            this.pnlMenu.Controls.Add(this.pctCrear);
            this.pnlMenu.Controls.Add(this.pctRutas);
            this.pnlMenu.Controls.Add(this.pctVueloDirecto);
            this.pnlMenu.Controls.Add(this.pctPais);
            this.pnlMenu.Controls.Add(this.pctAgregar);
            this.pnlMenu.Controls.Add(this.pctLogo1);
            this.pnlMenu.Location = new System.Drawing.Point(0, 43);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(251, 457);
            this.pnlMenu.TabIndex = 1;
            // 
            // pctRegistro
            // 
            this.pctRegistro.Image = global::Aerolinea.Properties.Resources.registro1;
            this.pctRegistro.Location = new System.Drawing.Point(0, 409);
            this.pctRegistro.Name = "pctRegistro";
            this.pctRegistro.Size = new System.Drawing.Size(251, 45);
            this.pctRegistro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctRegistro.TabIndex = 7;
            this.pctRegistro.TabStop = false;
            this.pctRegistro.Click += new System.EventHandler(this.pctRegistro_Click);
            this.pctRegistro.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctRegistro_MouseDown);
            this.pctRegistro.MouseEnter += new System.EventHandler(this.pctRegistro_MouseEnter);
            this.pctRegistro.MouseLeave += new System.EventHandler(this.pctRegistro_MouseLeave);
            this.pctRegistro.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctRegistro_MouseUp);
            // 
            // pctCrear
            // 
            this.pctCrear.Image = global::Aerolinea.Properties.Resources.crear1;
            this.pctCrear.Location = new System.Drawing.Point(0, 358);
            this.pctCrear.Name = "pctCrear";
            this.pctCrear.Size = new System.Drawing.Size(251, 45);
            this.pctCrear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCrear.TabIndex = 6;
            this.pctCrear.TabStop = false;
            this.pctCrear.Click += new System.EventHandler(this.pctCrear_Click);
            this.pctCrear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctCrear_MouseDown);
            this.pctCrear.MouseEnter += new System.EventHandler(this.pctCrear_MouseEnter);
            this.pctCrear.MouseLeave += new System.EventHandler(this.pctCrear_MouseLeave);
            this.pctCrear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctCrear_MouseUp);
            // 
            // pctRutas
            // 
            this.pctRutas.Image = global::Aerolinea.Properties.Resources.rutas1;
            this.pctRutas.Location = new System.Drawing.Point(0, 307);
            this.pctRutas.Name = "pctRutas";
            this.pctRutas.Size = new System.Drawing.Size(251, 45);
            this.pctRutas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctRutas.TabIndex = 5;
            this.pctRutas.TabStop = false;
            // 
            // pctVueloDirecto
            // 
            this.pctVueloDirecto.Image = global::Aerolinea.Properties.Resources.vuelo1;
            this.pctVueloDirecto.Location = new System.Drawing.Point(0, 256);
            this.pctVueloDirecto.Name = "pctVueloDirecto";
            this.pctVueloDirecto.Size = new System.Drawing.Size(251, 45);
            this.pctVueloDirecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctVueloDirecto.TabIndex = 4;
            this.pctVueloDirecto.TabStop = false;
            this.pctVueloDirecto.Click += new System.EventHandler(this.pctVueloDirecto_Click);
            this.pctVueloDirecto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctVueloDirecto_MouseDown);
            this.pctVueloDirecto.MouseEnter += new System.EventHandler(this.pctVueloDirecto_MouseEnter);
            this.pctVueloDirecto.MouseLeave += new System.EventHandler(this.pctVueloDirecto_MouseLeave);
            this.pctVueloDirecto.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctVueloDirecto_MouseUp);
            // 
            // pctPais
            // 
            this.pctPais.Image = global::Aerolinea.Properties.Resources.pais1;
            this.pctPais.Location = new System.Drawing.Point(0, 205);
            this.pctPais.Name = "pctPais";
            this.pctPais.Size = new System.Drawing.Size(251, 45);
            this.pctPais.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPais.TabIndex = 3;
            this.pctPais.TabStop = false;
            this.pctPais.Click += new System.EventHandler(this.pctPais_Click);
            this.pctPais.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctPais_MouseDown);
            this.pctPais.MouseEnter += new System.EventHandler(this.pctPais_MouseEnter);
            this.pctPais.MouseLeave += new System.EventHandler(this.pctPais_MouseLeave);
            this.pctPais.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctPais_MouseUp);
            // 
            // pctAgregar
            // 
            this.pctAgregar.Image = global::Aerolinea.Properties.Resources.agregar1;
            this.pctAgregar.Location = new System.Drawing.Point(0, 154);
            this.pctAgregar.Name = "pctAgregar";
            this.pctAgregar.Size = new System.Drawing.Size(251, 45);
            this.pctAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAgregar.TabIndex = 2;
            this.pctAgregar.TabStop = false;
            this.pctAgregar.WaitOnLoad = true;
            // 
            // pctLogo1
            // 
            this.pctLogo1.Image = global::Aerolinea.Properties.Resources.logo_pequenio;
            this.pctLogo1.Location = new System.Drawing.Point(46, 41);
            this.pctLogo1.Name = "pctLogo1";
            this.pctLogo1.Size = new System.Drawing.Size(155, 66);
            this.pctLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo1.TabIndex = 0;
            this.pctLogo1.TabStop = false;
            this.pctLogo1.Click += new System.EventHandler(this.pctLogo1_Click);
            // 
            // SQLWaitTime
            // 
            this.SQLWaitTime.Interval = 1000;
            this.SQLWaitTime.Tick += new System.EventHandler(this.SQLWaitTime_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1300, 740);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.pnlBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCerrar)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCrear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVueloDirecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.PictureBox pctCerrar;
        private System.Windows.Forms.PictureBox pctMin;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pctLogo1;
        private System.Windows.Forms.PictureBox pctAgregar;
        private System.Windows.Forms.PictureBox pctRegistro;
        private System.Windows.Forms.PictureBox pctCrear;
        private System.Windows.Forms.PictureBox pctRutas;
        private System.Windows.Forms.PictureBox pctVueloDirecto;
        private System.Windows.Forms.PictureBox pctPais;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer SQLWaitTime;
    }
}

