using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aerolinea
{
    public partial class frmPais : Aerolinea.formBase
    {
        Random random = new Random();
        Grafo obj = new Grafo();
        public int contadorlblV = 0; //Contador para el label de vertices
        public int contadorlblA = 0; //Contador para el label de aristas

        //Elementos de grafico
        private Bitmap bmp;
        private Pen lapiz;
        private Graphics g;

        public frmPais()
        {
            InitializeComponent();
            g = pnlDibujo.CreateGraphics();
            
        }

        bool ubicarNodo = false;
        int x = 0;
        int y = 0;

        private void btnUbicar_MouseEnter(object sender, EventArgs e)
        {
            btnUbicar.Image = global::Aerolinea.Properties.Resources.btnUbicar2;
        }

        private void btnUbicar_MouseLeave(object sender, EventArgs e)
        {
            btnUbicar.Image = global::Aerolinea.Properties.Resources.btnUbicar1;
        }

        private void btnUbicar_MouseDown(object sender, MouseEventArgs e)
        {
            btnUbicar.Image = global::Aerolinea.Properties.Resources.btnUbicar3;
        }

        private void btnUbicar_MouseUp(object sender, MouseEventArgs e)
        {
            btnUbicar.Image = global::Aerolinea.Properties.Resources.btnUbicar2;
        }

        private void btnUbicar_Click(object sender, EventArgs e)
        {
            ubicarNodo = true;
            pnlDibujo.Cursor = Cursors.Hand;
        }

        private void txtPais_Enter(object sender, EventArgs e)
        {
            if (txtPais.Text == "Introduzca el nombre del país a agregar") txtPais.Text = "";
            txtPais.ForeColor = Color.FromArgb(36, 35, 35);
        }

        private void txtPais_Leave(object sender, EventArgs e)
        {
            if (txtPais.Text == "")
            {
                txtPais.Text = "Introduzca el nombre del país a agregar";
                txtPais.ForeColor = Color.Gray;
            }
        }

        private void pnlDibujo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnlDibujo_MouseClick(object sender, MouseEventArgs e)
        {
            if (ubicarNodo == true)
            {

                x = e.X;
                y = e.Y;

                Pen lapiz = new Pen(Color.Gray, 3);
                SolidBrush relleno = new SolidBrush(Color.FromArgb(56, 182, 255));

                g.DrawEllipse(lapiz, x - 7, y - 7, 14, 14);
                g.FillEllipse(relleno, x - 7, y - 7, 14, 14);

                ubicarNodo = false;
            }
        }

        private void pnlDibujo_MouseMove(object sender, MouseEventArgs e)
        {
            lblLocalizacion.Text = ("X: " + e.X + " , Y: " + e.Y);
            
        }

        
    }
}
