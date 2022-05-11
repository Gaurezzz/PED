using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//sdvsdvs

namespace Aerolinea
{
    public partial class frmPais : Aerolinea.formBase
    {
        Random random = new Random();
        public int contadorlblV = 0; //Contador para el label de vertices
        public int contadorlblA = 0; //Contador para el label de aristas

        //Elementos de grafico
        private Graphics g;

        private Grafo obj = null;

        public frmPais(ref Grafo grafo)
        {
            obj = grafo; //asigno el grafo global
            InitializeComponent();
            g = pnlDibujo.CreateGraphics(); //la imagen del apa sera nuestro lienzo
            contadorlblA = obj.Num_aristas();
            
        }

        private void txtPais_Enter(object sender, EventArgs e) //configuro el text box para que al ingresar, deje de dar instrucciones
        {
            if (txtPais.Text == "Introduzca el nombre del país a agregar")
            {
                txtPais.Text = "";
                txtPais.Text = "Vertice" + contadorlblV;
            }
            txtPais.ForeColor = Color.FromArgb(36, 35, 35);
        }

        private void pnlDibujo_MouseMove(object sender, MouseEventArgs e)
        {
            lblLocalizacion.Text = ("X: " + e.X + " , Y: " + e.Y);  //definimos la ubicacion del string
        }

        private void pnlDibujo_MouseDown(object sender, MouseEventArgs e)
        {
            g = pnlDibujo.CreateGraphics();
            string nombre = txtPais.Text;

            if (nombre == "Introduzca el nombre del país a agregar")
            {
                MessageBox.Show("Escriba un nombre para el vertice", "ERROR", MessageBoxButtons.OK);
                return;
            }

            InsertarManualmente(e.X, e.Y); //Insertamos el nodo en el grafo

            actualizarMapa(); //Actualizamos graficamente
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
                    vertice.ColorNodo = "black";
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
        //Metodo para crear los dibujos del grafo
        public void actualizarMapa()
        {

            pnlDibujo.Refresh();

            Nodo[] vertices = obj.ObtenerVertices();
            Nodo[] aristas = obj.ObtenerAristas();

            SolidBrush s = new SolidBrush(Color.Black);
            FontFamily ff = new FontFamily("Consolas");
            Font font = new Font(ff, 10);

            Pen lapiz = new Pen(Color.IndianRed, 2);

            for (int i = 0; i < vertices.Length; i++)
            {
                g.DrawArc(lapiz, new Rectangle(vertices[i].PosX, vertices[i].PosY, 5, 5), 0, 360);
                g.DrawString(vertices[i].Nombre, font, s, vertices[i].PosX - 10, vertices[i].PosY - 20);
            }

            for (int i = 0; i < aristas.Length; i++)
            {
                Nodo inicio = aristas[i].VerticeAntecesor;
                Nodo final = aristas[i].VerticeAdyacente;

                int ix = inicio.PosX;
                int iy = inicio.PosY;
                int fx = final.PosX;
                int fy = final.PosY;

                int sx = (fx + ix) / 2;
                int sy = (fy + iy) / 2;

                int m = sy / sx;

                if (m > 1) sx += 10;
                else sy += 10;

                g.DrawLine(lapiz, ix, iy, fx, fy);
                g.DrawString(aristas[i].Peso.ToString(), font, s, sx, sy);
            }
        }
        //Cada vez que volvamos a aparecer el panel, debemos actualizar el grafico
        private void pnlDibujo_VisibleChanged(object sender, EventArgs e)
        {
            actualizarMapa();
        }
    }
}
