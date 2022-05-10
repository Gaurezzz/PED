using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aerolinea
{
    public partial class frmRegistro : Aerolinea.formBase
    {
        Grafo OBJ = new Grafo();
        public frmRegistro(ref Grafo grafo)
        {
            InitializeComponent();
            OBJ = grafo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            OBJ.MostrarV(lbxVertices);
            OBJ.MostrarA(lbxAristas);
            DgvMatriz.Rows.Clear();
            DgvMatriz.Columns.Clear();
            string[] NombreDeVertices = OBJ.ObtenerVerticesString();
            DgvMatriz.Columns.Add("VERTICES", "");
            for (int i = 0; i < OBJ.Num_vertices(); i++)
            {
                DgvMatriz.Columns.Add(NombreDeVertices[i], NombreDeVertices[i]);
                DgvMatriz.Rows.Add(NombreDeVertices[i]);
                DgvMatriz.Columns[i].Width = 40;
                DgvMatriz.Columns[i + 1].Width = 40;
            }

            for (int i = 1; i <= OBJ.Num_vertices();i++ )
            {
                for (int j = 1; j<= OBJ.Num_vertices(); j++)
                {
                    string vertice1 = DgvMatriz.Rows[i - 1].Cells[0].Value.ToString();
                    Nodo ver = OBJ.LocalizaVertice(vertice1);

                    if (OBJ.LocalizaAdyacente(ver.Nombre, DgvMatriz.Columns[j].Name.ToString()) == true)
                    {
                        try
                        {
                            DgvMatriz.Rows[i - 1].Cells[j].Value = (OBJ.ExistaArista_Vertices(OBJ.LocalizaVertice(vertice1), OBJ.LocalizaVertice(DgvMatriz.Columns[j].Name.ToString())).Peso);
                        }
                        catch
                        {
                            DgvMatriz.Rows[i - 1].Cells[j].Value = 0;
                        }
                    }
                    else
                        DgvMatriz.Rows[i - 1].Cells[j].Value = "0";

                }
            }
            }
            catch
            {
                MessageBox.Show("No se pudo actualizar la lista de componentes", "Error", MessageBoxButtons.OK);
            }
            
        }
    }
}
