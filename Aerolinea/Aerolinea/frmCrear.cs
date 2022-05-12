using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aerolinea
{
    public partial class frmCrear : Aerolinea.formBase
    {
        Grafo obj;
        Graphics g;
        public int contadorV = 0;
        public int contadorA = 0;
        public frmCrear(ref Grafo grafo)
        {
            InitializeComponent();
            obj = grafo;
            g = pnlDibujo.CreateGraphics();
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }

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
            cmbNodo3.Items.Clear();

            cmbNodo1.Items.AddRange(vertices);
            cmbNodo2.Items.AddRange(vertices);
            cmbNodo3.Items.AddRange(vertices);
        }

        private void pnlDibujo_VisibleChanged(object sender, EventArgs e)
        {
            actualizarMapa();
            actualizarNodos();
        }

        private void btnCRuta_Click(object sender, EventArgs e)
        {
            if (cmbNodo1.Text == "" || cmbNodo2.Text == "")
            {
                MessageBox.Show("Ingrese ambos lugares del recorrido");
                return;
            }

            if (cmbNodo1.Text == cmbNodo2.Text)
            {
                MessageBox.Show("Los lugares deben ser diferentes");
                return;
            }


            listBox.Items.Clear();
            cantidad.Text = "";
            obj.A_Dijkstra(cmbNodo1.Text, cmbNodo2.Text, listBox, cantidad);
            cmbNodo1.Text = "";
            cmbNodo2.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            cantidad.Text = "";
        }

        private void btnEliminarC_Click(object sender, EventArgs e)
        {
            string nombre = cmbNodo3.Text;
            Nodo verOari = new Nodo();
            verOari.Nombre = nombre;

            if (obj.ExisteV(verOari))
            {
                obj.EliminarVertice(verOari);
                string[] aristas = obj.ObtenerAristasString();
                for(int i = obj.Num_aristas() - 1; i >= 0; i--)
                {
                    Nodo actual = obj.LocalizaArista(aristas[i]);
                    if (actual.VerticeAdyacente.Nombre == nombre || actual.VerticeAntecesor.Nombre == nombre)
                    {
                        obj.EliminarArista(actual);
                    }
                }
                contadorV--;
            }
            else if (obj.ExisteA(verOari))
            {
                obj.EliminarArista(verOari);

                contadorA--;
            }
            else
            {
                MessageBox.Show("Este elemento no existe en el grafo", "ELEMENTO NO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            actualizarNodos();
            cmbNodo3.Text = "";
            actualizarMapa();
        }
    }
}
