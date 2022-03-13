using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerolinea
{
    class Grafo
    {
        //Vertices
        private Nodo V_inicial = new Nodo();
        private Nodo V_final = new Nodo();
        //Aristas
        private Nodo A_inicial = new Nodo();
        private Nodo A_final = new Nodo();
        private int Nv; //Numero de vertices
        private int Na; //Numero de aristas

        //Constructor
        public Grafo()
        {
            Anular();
        }
        
        //Metodo para anular los vertices y aristas
        public void Anular()
        {
            V_inicial = null;
            V_final = null;
            A_inicial = null;
            A_final = null;
            Nv = 0;
            Na = 0;
        }
        
        //Metodo para comprobar si hay vertices y aristas
        public bool esVacio()
        {
            return (V_inicial == null && A_inicial == null); //Devuelve true
        }

        //Metodo para comprobar si hay vertices
        public bool hayVertices()
        {
            return (Nv != 0);
        }

        //Metodo para comprobar si hay aristas
        public bool hayAristas()
        {
            return (Na != 0);
        }

        //Metodo que devuelve el numero de vertices
        public int Num_vertices()
        {
            return Nv;
        }

        //Metodo que devuelve el numero de aristas
        public int Num_aristas()
        {
            return Na;
        }

        //Metodo que devuelve el numero de vertices adyacentes dado un vertice 
        public int Adyacentes(Nodo v)
        {
            int n = 0;
            Nodo q = LocalizaVertice(v.Nombre);
            while (q != null)
            {
                q = q.VerticeAdyacente;
                n++;
            }
            return n;
        }

        //Metodo que devuelve el numero de vertices antecesores dado un vertice 
        public int Antecesores(Nodo v)
        {
            int n = 0;
            Nodo q = LocalizaVertice(v.Nombre);
            while (q != null)
            {
                q = q.VerticeAntecesor;
                n++;
            }
            return n;
        }
        
        //Metodo para insertar un vertice por su nombre
        public void InsertarVertice(Nodo v)
        {
            if (ExisteV(v))
            {
                MessageBox.Show("Existe ya un vertice con ese nombre", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //Se inserta vertice en la lista de vertices
                Nodo nuevo = v;
                if (V_inicial == null)
                {
                    V_inicial = nuevo;
                    V_inicial.Siguiente = null;
                    V_inicial.Anterior = null;
                    V_final = V_inicial;
                }
                else
                {
                    V_final.Siguiente = nuevo;
                    nuevo.Siguiente = null;
                    nuevo.Anterior = V_final;
                    V_final = nuevo;
                }
                Nv++;
            }
        }

        //Metodo para insertar una arista(no dirigida) dado dos vertices
        public void InsertarArista(Nodo arista, Nodo a, Nodo s)
        {
            if (ExisteA(arista))
            {
                MessageBox.Show("Ya existe esta arista", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Nodo A = LocalizaVertice(s.Nombre);
                Nodo nuevoA = new Nodo();
                nuevoA.Nombre = a.Nombre;
                if (Adyacentes(A) == 0)
                {
                    A.VerticeAdyacente = nuevoA;
                    A.VerticeAntecesor = nuevoA;
                }
                else
                {
                    nuevoA.VerticeAdyacente = A.VerticeAdyacente;
                    A.VerticeAdyacente = nuevoA;
                    nuevoA.VerticeAntecesor = A.VerticeAntecesor;
                    A.VerticeAntecesor = nuevoA;
                }

                Nodo S = LocalizaVertice(a.Nombre);
                Nodo nuevoS = new Nodo();
                nuevoS.Nombre = s.Nombre;
                if (Antecesores(S) == 0)
                {
                    S.VerticeAntecesor = nuevoS;
                    S.VerticeAdyacente = nuevoS;
                }
                else
                {
                    nuevoS.VerticeAntecesor = S.VerticeAntecesor;
                    S.VerticeAntecesor = nuevoS;
                    nuevoS.VerticeAdyacente = S.VerticeAdyacente;
                    S.VerticeAdyacente = nuevoS;
                }

                //Se inserta en la lista de aristas
                Nodo nuevo = new Nodo();
                nuevo = arista;
                if (A_inicial == null)
                {
                    A_inicial = nuevo;
                    A_inicial.Siguiente = null;
                    A_inicial.Anterior = null;
                    A_final = A_inicial;
                }
                else
                {
                    A_final.Siguiente = nuevo;
                    nuevo.Siguiente = null;
                    nuevo.Anterior = A_final;
                    A_final = nuevo;
                }
                Na++;      
            }
        }

        //Metodo que localiza por el nombre del vertice
        public Nodo LocalizaVertice(string nombre)
        {
            Nodo Act = V_inicial; //Vertice actual 
            while (Act != null)
            {
                if (Act.Nombre.Equals(nombre))
                    return Act;
                Act = Act.Siguiente;
            }
            return null;
        }

        //Metodo que localiza por el nombre de la arista
        public Nodo LocalizaArista(string nombre)
        {
            Nodo Act = A_inicial;
            while (Act != null)
            {
                if (Act.Nombre.Equals(nombre))
                    return Act;
                Act = Act.Siguiente;
            }
            return null;
        }

        //Metodo para eliminar un vertice por su nombre
       
        //Metodo que comprueba que exista una arista
        public bool ExisteA(Nodo a)
        {
            Nodo buscado = LocalizaArista(a.Nombre);
            if (buscado != null)
                return true;
            else
                return false;
        }

        //Metodo que comprueba que exista un vertice
        public bool ExisteV(Nodo v)
        {
            Nodo buscado = LocalizaVertice(v.Nombre);
            if (buscado != null)
                return true;
            else
                return false;
        }
    }
}
