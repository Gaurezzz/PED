using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerolinea
{
    public partial class Form1 : Form
    {
        //A continuacion se declaran las variables globales del formulario principal

        static public Grafo obj = new Grafo();

        bool presionando = false;
        int px = 0;
        int py = 0;
        int actual = 0;

        int panx = 251;
        int pany = 43;

        frmInicio frmInicio = new frmInicio();
        frmPais frmPais = new frmPais(ref obj);
        FrmVuelo frmVuelo = new FrmVuelo(ref obj);
        frmRegistro frmRegistro = new frmRegistro(ref obj);
        frmCrear frmCrear = new frmCrear(ref obj);

        //Inicializamos todos los elementos que necesitaremos

        public Form1()
        {
            InitializeComponent();
            Width = 1000;
            Height = 500;

            //por cada uno de los paneles, les reasignaremos el padre y los ubicaremos en el form1

            frmInicio.panel1.Parent = this;
            frmInicio.panel1.Visible = true;
            frmInicio.panel1.Location = new Point(panx, pany);

            frmPais.panel1.Parent = this;
            frmPais.panel1.Visible = false;
            frmPais.panel1.Location = new Point(panx, pany);

            frmVuelo.panel1.Parent = this;
            frmVuelo.panel1.Visible = false;
            frmVuelo.panel1.Location = new Point(panx, pany);

            frmCrear.panel1.Parent = this;
            frmCrear.panel1.Visible = false;
            frmCrear.panel1.Location = new Point(panx, pany);

            frmRegistro.panel1.Parent = this;
            frmRegistro.panel1.Visible = false;
            frmRegistro.panel1.Location = new Point(panx, pany);

            this.ActiveControl = frmPais.lblprueba;

            SQLWaitTime.Enabled = true;
        }

        //Aqui se configura la barra superior para permitirle ser arrastrada
        private void pnlBarra_MouseDown(object sender, MouseEventArgs e)
        {
            presionando = true;
            px = e.X;
            py = e.Y;
        }

        private void pnlBarra_MouseUp(object sender, MouseEventArgs e)
        {
            presionando = false;
        }

        private void pnlBarra_MouseMove(object sender, MouseEventArgs e)
        {
            if (presionando)
            {
                this.Location = new Point(MousePosition.X - px,MousePosition.Y - py);
            }
        }


        //En esta seccion se editan los cambios en las imagenes de los botones

        //Boton cerrar

        private void pctCerrar_MouseEnter(object sender, EventArgs e)
        {
            pctCerrar.Image = global::Aerolinea.Properties.Resources.close2;
        }

        private void pctCerrar_MouseLeave(object sender, EventArgs e)
        {
            pctCerrar.Image = global::Aerolinea.Properties.Resources.close1;
        }

        private void pctCerrar_MouseDown(object sender, MouseEventArgs e)
        {
            pctCerrar.Image = global::Aerolinea.Properties.Resources.close3;
        }

        private void pctCerrar_MouseUp(object sender, MouseEventArgs e)
        {
            pctCerrar.Image = global::Aerolinea.Properties.Resources.close2;
        }

        private void pctCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        //Boton minimizar

        private void pctMin_MouseEnter(object sender, EventArgs e)
        {
            pctMin.Image = global::Aerolinea.Properties.Resources.min2;
        }

        private void pctMin_MouseLeave(object sender, EventArgs e)
        {
            pctMin.Image = global::Aerolinea.Properties.Resources.min1;
        }

        private void pctMin_MouseDown(object sender, MouseEventArgs e)
        {
            pctMin.Image = global::Aerolinea.Properties.Resources.min3;
        }

        private void pctMin_MouseUp(object sender, MouseEventArgs e)
        {
            pctMin.Image = global::Aerolinea.Properties.Resources.min2;
        }

        private void pctMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Boton pais

        private void pctPais_MouseDown(object sender, MouseEventArgs e)
        {
            pctPais.Image = global::Aerolinea.Properties.Resources.pais3;
        }

        private void pctPais_MouseEnter(object sender, EventArgs e)
        {
            pctPais.Image = global::Aerolinea.Properties.Resources.pais2;
        }

        private void pctPais_MouseLeave(object sender, EventArgs e)
        {
            pctPais.Image = global::Aerolinea.Properties.Resources.pais1;

            if (actual == 1) pctPais.Image = global::Aerolinea.Properties.Resources.pais2;
            if (actual == 2) pctVueloDirecto.Image = global::Aerolinea.Properties.Resources.vuelo2;
            if (actual == 3) pctCrear.Image = global::Aerolinea.Properties.Resources.crear2;
            if (actual == 4) pctRegistro.Image = global::Aerolinea.Properties.Resources.registro2;

        }

        private void pctPais_MouseUp(object sender, MouseEventArgs e)
        {
            pctPais.Image = global::Aerolinea.Properties.Resources.pais2;
        }

        //Boton vuelo directo

        private void pctVueloDirecto_MouseDown(object sender, MouseEventArgs e)
        {
            pctVueloDirecto.Image = global::Aerolinea.Properties.Resources.vuelo3;

        }

        private void pctVueloDirecto_MouseEnter(object sender, EventArgs e)
        {
            pctVueloDirecto.Image = global::Aerolinea.Properties.Resources.vuelo2;
        }

        private void pctVueloDirecto_MouseLeave(object sender, EventArgs e)
        {
            pctVueloDirecto.Image = global::Aerolinea.Properties.Resources.vuelo1;

            if (actual == 1) pctPais.Image = global::Aerolinea.Properties.Resources.pais2;
            if (actual == 2) pctVueloDirecto.Image = global::Aerolinea.Properties.Resources.vuelo2;
            if (actual == 3) pctCrear.Image = global::Aerolinea.Properties.Resources.crear2;
            if (actual == 4) pctRegistro.Image = global::Aerolinea.Properties.Resources.registro2;
        }

        private void pctVueloDirecto_MouseUp(object sender, MouseEventArgs e)
        {
            pctVueloDirecto.Image = global::Aerolinea.Properties.Resources.vuelo2;
            if (actual == 1) pctPais.Image = global::Aerolinea.Properties.Resources.pais2;
            if (actual == 2) pctVueloDirecto.Image = global::Aerolinea.Properties.Resources.vuelo2;
            if (actual == 3) pctCrear.Image = global::Aerolinea.Properties.Resources.crear2;
            if (actual == 4) pctRegistro.Image = global::Aerolinea.Properties.Resources.registro2;

        }

        //Boton crear

        private void pctCrear_MouseDown(object sender, MouseEventArgs e)
        {
            pctCrear.Image = global::Aerolinea.Properties.Resources.crear3;

        }

        private void pctCrear_MouseEnter(object sender, EventArgs e)
        {
            pctCrear.Image = global::Aerolinea.Properties.Resources.crear2;
        }

        private void pctCrear_MouseLeave(object sender, EventArgs e)
        {
            pctCrear.Image = global::Aerolinea.Properties.Resources.crear1;

            if (actual == 1) pctPais.Image = global::Aerolinea.Properties.Resources.pais2;
            if (actual == 2) pctVueloDirecto.Image = global::Aerolinea.Properties.Resources.vuelo2;
            if (actual == 3) pctCrear.Image = global::Aerolinea.Properties.Resources.crear2;
            if (actual == 4) pctRegistro.Image = global::Aerolinea.Properties.Resources.registro2;
        }

        private void pctCrear_MouseUp(object sender, MouseEventArgs e)
        {
            pctCrear.Image = global::Aerolinea.Properties.Resources.crear2;

            if (actual == 1) pctPais.Image = global::Aerolinea.Properties.Resources.pais2;
            if (actual == 2) pctVueloDirecto.Image = global::Aerolinea.Properties.Resources.vuelo2;
            if (actual == 3) pctCrear.Image = global::Aerolinea.Properties.Resources.crear2;
            if (actual == 4) pctRegistro.Image = global::Aerolinea.Properties.Resources.registro2;
        }

        //Boton registro

        private void pctRegistro_MouseDown(object sender, MouseEventArgs e)
        {
            pctRegistro.Image = global::Aerolinea.Properties.Resources.registro3;
        }

        private void pctRegistro_MouseEnter(object sender, EventArgs e)
        {
            pctRegistro.Image = global::Aerolinea.Properties.Resources.registro2;
        }

        private void pctRegistro_MouseLeave(object sender, EventArgs e)
        {
            pctRegistro.Image = global::Aerolinea.Properties.Resources.registro1;

            if (actual == 1) pctPais.Image = global::Aerolinea.Properties.Resources.pais2;
            if (actual == 2) pctVueloDirecto.Image = global::Aerolinea.Properties.Resources.vuelo2;
            if (actual == 3) pctCrear.Image = global::Aerolinea.Properties.Resources.crear2;
            if (actual == 4) pctRegistro.Image = global::Aerolinea.Properties.Resources.registro2;

        }

        private void pctRegistro_MouseUp(object sender, MouseEventArgs e)
        {
            pctRegistro.Image = global::Aerolinea.Properties.Resources.registro2;

            if (actual == 1) pctPais.Image = global::Aerolinea.Properties.Resources.pais2;
            if (actual == 2) pctVueloDirecto.Image = global::Aerolinea.Properties.Resources.vuelo2;
            if (actual == 3) pctCrear.Image = global::Aerolinea.Properties.Resources.crear2;
            if (actual == 4) pctRegistro.Image = global::Aerolinea.Properties.Resources.registro2;

        }

        //En la siguiente funcion determino los cambios de visibilidad en los paneles

        public void cambio()
        {
            if (actual == 0)
            {
                frmInicio.panel1.Hide();
            }
            if (actual == 1)
            {
                pctPais.Image = global::Aerolinea.Properties.Resources.pais1;
                frmPais.panel1.Hide();
            }
            if (actual == 2)
            {
                pctVueloDirecto.Image = global::Aerolinea.Properties.Resources.vuelo1;
                frmVuelo.panel1.Hide();
            }
            if (actual == 3)
            {
                pctCrear.Image = global::Aerolinea.Properties.Resources.crear1;
                frmCrear.panel1.Hide();
            }
            if (actual == 4)
            {
                pctRegistro.Image = global::Aerolinea.Properties.Resources.registro1;
                frmRegistro.panel1.Hide();
            }
        }

        //Ahora defino los cambios en los paneles

        private void pctPais_Click(object sender, EventArgs e)
        {
            cambio();
            actual = 1;
            frmPais.panel1.Show();
        }

        private void pctVueloDirecto_Click(object sender, EventArgs e)
        {
            cambio();
            actual = 2;
            frmVuelo.panel1.Show();
        }

        private void pctCrear_Click(object sender, EventArgs e)
        {
            cambio();
            actual = 3;
            frmCrear.panel1.Show();
        }

        private void pctRegistro_Click(object sender, EventArgs e)
        {
            cambio();
            actual = 4;
            frmRegistro.panel1.Show();
        }

        private void pctLogo1_Click(object sender, EventArgs e)
        {
            cambio();
            actual = 0;
            frmInicio.panel1.Show();
        }

        //Por ultimo, la siguiente funcion es para enfocar la barra superior en un inicio

        private void pnlBarra_Click(object sender, EventArgs e)
        {
            this.ActiveControl = pnlBarra;
        }

        private void SQLWaitTime_Tick(object sender, EventArgs e)
        {
            frmPais.SQLInicio();
            frmVuelo.SQLIniciar();
            SQLWaitTime.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            obj.GuardarDatosSQL();
        }
    }
}
