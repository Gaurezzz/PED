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

        private void pnlDibujo_MouseDown(object sender, MouseEventArgs e)
        {
            g = pnlDibujo.CreateGraphics();
            string nombre = txtPais.Text;

            //Escribir nombres
            SolidBrush s = new SolidBrush(Color.Black);
            FontFamily ff = new FontFamily("Consolas");
            Font font = new Font(ff, 15);

            lapiz=new Pen(Color.Black,3);
            g.DrawArc(lapiz, new Rectangle(e.X, e.Y, 5, 5), 0, 360);
            g.DrawString(nombre, font, s, e.X - 10, e.Y - 30);

            InsertarManualmente(e.X, e.Y);
            
        }

        //Metodo para insertar manualmente
        public void InsertarManualmente(int x, int y)
        {
            try
            {
                string nombre = txtPais.Text;
                nombre = nombre.Trim();
                if (nombre != "" && x <= 749 && y <= 610)
                {
                    Nodo vertice = new Nodo();
                    vertice.Nombre = nombre;
                    vertice.PosX = x;
                    vertice.PosY = y;
                    vertice.Color = "black";
                    vertice.Grosor = 3;
                    vertice.Tamaño = 5;

                    if (!obj.ExisteV(vertice))
                    {
                        contadorlblV += 1;
                        txtPais.Text = "";
                        txtPais.Text = "Vertice" + contadorlblV;
                    }
                    obj.InsertarVertice(vertice);
                    lblvertices.Text = "VERTICES: " + contadorlblV;

                }
            }
            catch
            {
                MessageBox.Show("PROPIEDADES DEL VERTICE INVALIDAS:\n" +
                    "\n" +
                    "1.- Los vertices deben tener nombre \n" +
                    "2.- La posición X es un número entero positvo (máximo 749)\n" +
                    "3.- La posición Y es un número entero positivo (máximo 339)\n","ERROR", MessageBoxButtons.OK);
            }
        }

        
    }
}
