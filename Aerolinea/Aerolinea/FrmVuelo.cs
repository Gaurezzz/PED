using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aerolinea
{
    public partial class FrmVuelo : Aerolinea.formBase
    {
        Grafo obj;
        Graphics g;
        public FrmVuelo(ref Grafo grafo)
        {
            InitializeComponent();
            obj = grafo;
            g = pnlDibujo.CreateGraphics();
        }

        public void actualizarMapa()
        {
            pnlDibujo.Refresh();

            Nodo[] vertices = obj.ObtenerVertices();
            Nodo[] aristas = obj.ObtenerAristas();

            SolidBrush s = new SolidBrush(Color.Black);
            FontFamily ff = new FontFamily("Consolas");
            Font font = new Font(ff, 15);

            Pen lapiz = new Pen(Color.Black, 3);

            for (int i = 0; i < vertices.Length; i++)
            {
                g.DrawArc(lapiz, new Rectangle(vertices[i].PosX, vertices[i].PosY, 5, 5), 0, 360);
                g.DrawString(vertices[i].Nombre, font, s, vertices[i].PosX - 10, vertices[i].PosY - 30);
            }

            for (int i = 0; i < aristas.Length; i++)
            {
                Nodo inicio = aristas[i].VerticeAntecesor;
                Nodo final = aristas[i].VerticeAdyacente;

                int ix = inicio.PosX;
                int iy = inicio.PosY;
                int fx = final.PosX;
                int fy = final.PosY;

                g.DrawLine(lapiz, ix, iy, fx, fy);
            }
        }

        void actualizarNodos()
        {
            string[] vertices = obj.ObtenerVerticesString();

            cmbNodo1.Items.AddRange(vertices);
            cmbNodo2.Items.AddRange(vertices);
        }


        private void pnlDibujo_VisibleChanged_1(object sender, EventArgs e)
        {
            actualizarMapa();
            actualizarNodos();
        }

        private void btnUbicar_Click(object sender, EventArgs e)
        {
            Nodo inicio = obj.LocalizaVertice(cmbNodo1.Text);
            Nodo final = obj.LocalizaVertice(cmbNodo2.Text);

            if (inicio == final)
            {
                MessageBox.Show("Introduzca dos paises diferentes entre si", "Error");
            }

            Nodo arista = new Nodo();

            arista.VerticeAntecesor = inicio;
            arista.VerticeAdyacente = final;

            arista.Peso = int.Parse(txtCosto.Text);

            obj.InsertarArista(arista, inicio, final);

            actualizarMapa();
        }
    }
}
