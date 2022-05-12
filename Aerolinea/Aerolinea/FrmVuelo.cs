using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Aerolinea
{
    public partial class FrmVuelo : Aerolinea.formBase
    {
        Grafo obj;
        Graphics g;
        int nArista = 0; //nos ayudara a crear los nombres de las aristas
        
        public FrmVuelo(ref Grafo grafo)
        {
            InitializeComponent();
            obj = grafo;
            g = pnlDibujo.CreateGraphics();
        }
        //utilizamos de nuevo la funcion para actualizar el mapa
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

                int my = (iy - fy);
                int mx = (ix - fx);

                int rx, ry;

                if (mx == 0)
                {
                    rx = ix + 10;
                    ry = sy;
                }
                else
                {

                    double m = (double)my / mx;
                    double nm = -1 * (1 / m);

                    double d = 10;

                    ry = (int)((-1 + Math.Sqrt(1 + 4 * nm * nm * d * d)) / (2 * nm)) - sy;
                    if (ry < 0) ry = Math.Abs((int)((-1 - Math.Sqrt(1 + 4 * nm * nm * d * d)) / (2 * nm)) - sy);
                    rx = (int)Math.Sqrt((ry - sy) * (ry - sy) - d) + sx;
                    if (rx < 0) rx = (int)(Math.Sqrt((ry - sy) * (ry - sy) - d) + sx);
                }

                g.DrawLine(lapiz, ix, iy, fx, fy);
                g.DrawString(aristas[i].Peso.ToString(), font, s, rx, ry);
            }
        }
        //metodo que permite crear la lista de opciones en los combo box
        void actualizarNodos()
        {
            string[] vertices = obj.ObtenerVerticesString();

            cmbNodo1.Items.Clear();
            cmbNodo2.Items.Clear();

            cmbNodo1.Items.AddRange(vertices);
            cmbNodo2.Items.AddRange(vertices);
        }


        private void pnlDibujo_VisibleChanged_1(object sender, EventArgs e)
        {
            actualizarMapa();
            actualizarNodos();
        }
        //metodo que permite ubicar la arista
        private void btnUbicar_Click(object sender, EventArgs e)
        {
            Nodo inicio = obj.LocalizaVertice(cmbNodo1.Text);
            Nodo final = obj.LocalizaVertice(cmbNodo2.Text);

            if (inicio == final)
            {
                MessageBox.Show("Introduzca dos paises diferentes entre si", "Error");
                return;
            }
            if (cmbNodo1.Text == "" || cmbNodo2.Text == "")
            {
                MessageBox.Show("Seleccione dos destinos", "Error");
                return;
            }
            if (txtCosto.Text == "")
            {
                MessageBox.Show("Escriba el costo del viaje", "Error");
                return ;
            }

            if (int.Parse(txtCosto.Text) < 0)
            {
                MessageBox.Show("El costo debe ser un numero entero positivo", "Error");
                return;
            }

            try
            {
                Nodo arista = new Nodo();

                arista.VerticeAntecesor = inicio;
                arista.VerticeAdyacente = final;
                arista.Nombre = "arista" + nArista.ToString();

                nArista++;
                

                arista.Peso = int.Parse(txtCosto.Text);

                obj.InsertarArista(arista, inicio, final); //Introducimos las aristas en el grafo

                actualizarMapa();

                cmbNodo1.Text = "";
                cmbNodo2.Text = "";
                txtCosto.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("El costo debe ser un numero entero positivo", "Error");
            }
        }

        private void pnlDibujo_MouseMove(object sender, MouseEventArgs e)
        {
            lblLocalizacion.Text = ("X: " + e.X + " , Y: " + e.Y);  //definimos la ubicacion del string
        }

        public void SQLIniciar()
        {

            try
            {
                List<Nodo> aristas = obj.SQLAEntry();
                for (int i = 0; i < aristas.Count; i++)
                {
                    Nodo inicio = obj.LocalizaVertice(aristas[i].VerticeAntecesor.Nombre);
                    Nodo final = obj.LocalizaVertice(aristas[i].VerticeAdyacente.Nombre);

                    Nodo arista = new Nodo();

                    arista.VerticeAntecesor = inicio;
                    arista.VerticeAdyacente = final;
                    arista.Nombre = "arista" + nArista.ToString();

                    nArista = int.Parse(Regex.Replace(aristas[i].Nombre, @"[^\d]", "")) + 1;


                    arista.Peso = aristas[i].Peso;

                    obj.InsertarArista(arista, inicio, final); //Introducimos las aristas en el grafo

                    actualizarMapa();
                }

                cmbNodo1.Text = "";
                cmbNodo2.Text = "";
                txtCosto.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("El costo debe ser un numero entero positivo", "Error");
            }
        }
    }
}
