using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerolinea
{
    public class Grafo
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

        public bool LocalizaAdyacente(string vertice, string nombre)
        {
            Nodo Act = LocalizaVertice(vertice);
            int n = 0;
            while (Act != null)
            {
                if (n == 0) { }
                else
                {
                    if (Act.Nombre.Equals(nombre))
                        return true;
                }
                Act = Act.VerticeAntecesor;
                n++;
            }
            return false;
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

        //Metodo para insertar una arista dirigida dado dos vertices
        public void InsertarAristaDirigida(Nodo arista, Nodo a, Nodo s)
        {
            if (ExisteA(arista))
            {
                MessageBox.Show("Ya existe esta arista", "ATENCION", MessageBoxButtons.OK);
            }
            else
            {
                Nodo A = LocalizaVertice(s.Nombre);
                Nodo nuevoS = new Nodo();
                nuevoS.Nombre = a.Nombre;
                if (Adyacentes(A) == 0)
                    a.VerticeAdyacente = nuevoS;
                else
                {
                    nuevoS.VerticeAdyacente = A.VerticeAdyacente;
                    A.VerticeAdyacente = nuevoS;
                }
                Nodo S = LocalizaVertice(a.Nombre);
                Nodo nuevoA = new Nodo();
                nuevoA.Nombre = s.Nombre;
                if (Antecesores(S) == 0)
                    S.VerticeAntecesor = nuevoA;
                else
                {
                    nuevoA.VerticeAntecesor = S.VerticeAntecesor;
                    S.VerticeAntecesor = nuevoA;
                }

                //Insertando la arista en la lista de las aristas
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
        public void EliminarVertice(Nodo v)
        {
            Nodo Actual = new Nodo();
            Nodo anterior = new Nodo();
            anterior = null;
            Actual = V_inicial;
            bool encontrado = false;
            while (Actual != null && encontrado == false)
            {
                if (Actual.Nombre == v.Nombre)
                {
                    if (Actual == V_inicial)
                    {
                        V_inicial = V_inicial.Siguiente;
                    }
                    else if (Actual == V_final)
                    {
                        anterior.Siguiente = null;
                        V_final = anterior;
                    }
                    else
                    {
                        anterior.Siguiente = Actual.Siguiente;
                        Actual.Siguiente.Anterior = anterior;
                    }
                    encontrado = true;
                }
                anterior = Actual;
                Actual = Actual.Siguiente;
            }
            if (encontrado == true)
                Nv--;
        }

        //Metodo para eliminar una arista dado su nombre
        public void EliminarArista(Nodo a)
        {
            Nodo Actual = new Nodo();
            Nodo anterior = new Nodo();
            anterior = null;
            Actual = A_inicial;
            bool encontrado = false;
            while (Actual != null && encontrado == false)
            {
                if (Actual.Nombre == a.Nombre)
                {
                    if (Actual == A_inicial)
                    {
                        A_inicial = A_inicial.Siguiente;
                    }
                    else if (Actual == A_final)
                    {
                        anterior.Siguiente = null;
                        A_final = anterior;
                    }
                    else
                    {
                        anterior.Siguiente = Actual.Siguiente;
                        Actual.Siguiente.Anterior = anterior;
                    }
                    encontrado = true;
                }
                anterior = Actual;
                Actual = Actual.Siguiente;
                if (encontrado == true)
                    Na--;
            }
        }

       
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

        //Metodo que comprueba que hay arista y vertices
        public Nodo ExistaArista_Vertices(Nodo ant, Nodo ady)
        {
            string[] buscados = ObtenerAristasString();
            for (int i = 0; i < Na; i++)
            {
                Nodo actual = LocalizaArista(buscados[i]);
                if (ant.Nombre == actual.VerticeAntecesor.Nombre && ady.Nombre == actual.VerticeAdyacente.Nombre)
                    return actual;
                else if (ady.Nombre == actual.VerticeAntecesor.Nombre && ant.Nombre == actual.VerticeAdyacente.Nombre)
                    return actual;
            }
            return null;
        }

        //Metodo para mostrar vertices
        public void MostrarV(ListBox lbxComponentes)
        {
            if (hayVertices() == true)
            {
                lbxComponentes.Items.Clear();
                Nodo q = V_inicial;
                lbxComponentes.Items.Add("VERTICES:");
                while (q != null)
                {
                    lbxComponentes.Items.Add("*Vertice: " + q.Nombre + "\t Pos(x): " + q.PosX + "\t Pos(y): " + q.PosY);
                    q = q.Siguiente;
                }
            }
        }

        //Metodo para mostrar aristas
        public void MostrarA(ListBox lbxComponentes)
        {
            if (hayAristas() == true)
            {
                lbxComponentes.Items.Clear();
                Nodo q = A_inicial;
                lbxComponentes.Items.Add("ARISTAS:");
                while (q != null)
                {
                    lbxComponentes.Items.Add("*Arista: " + q.Nombre + "\t {" + q.VerticeAntecesor.Nombre + "," + q.VerticeAdyacente.Nombre + "}" + "\t Peso{" + q.Peso + "}");
                    q = q.Siguiente;
                }
            }
        }

        //Metodo que devuelve todos los nombres de los vertices
        public Nodo[] ObtenerVertices()
        {
            Nodo[] NombresV = new Nodo[Nv];
            Nodo Actual = V_inicial;
            for (int i = 0; i < Nv; i++)
            {
                NombresV[i] = Actual;
                Actual = Actual.Siguiente;
            }
            return NombresV;
        }

        public string[] ObtenerVerticesString()
        {
            string[] NombresV = new string[Nv];
            Nodo Actual = V_inicial;
            for (int i = 0; i < Nv; i++)
            {
                NombresV[i] = Actual.Nombre;
                Actual = Actual.Siguiente;
            }
            return NombresV;
        }

        //Metodo que devuelve todos los nombres de las aristas
        public Nodo[] ObtenerAristas()
        {
            Nodo[] NombresA = new Nodo[Na];
            Nodo Actual = A_inicial;
            for (int i = 0; i < Na; i++)
            {
                NombresA[i] = Actual;
                Actual = Actual.Siguiente;
            }
            return NombresA;
        }

        public string[] ObtenerAristasString()
        {
            string[] NombresA = new string[Na];
            Nodo Actual = A_inicial;
            for (int i = 0; i < Na; i++)
            {
                NombresA[i] = Actual.Nombre;
                Actual = Actual.Siguiente;
            }
            return NombresA;
        }

        //Metodo que retorna la posicion dado el nombre de vertice
        public int PosVertice(string nombre)
        {
            int n = 0;
            Nodo Act = V_inicial;
            while (Act != null)
            {
                if (Act.Nombre.Equals(nombre))
                    return n;
                Act = Act.Siguiente;
                n++;
            }
            return -1;
        }

        //Metodo que retorna el vertice dada una posicion
        public Nodo VerticePorPos(int n)
        {
            int contador = 0;
            Nodo Act = V_inicial;
            while (contador != n)
            {
                Act = Act.Siguiente;
                contador++;
            }
            return Act;
        }

        //Metodo para el algoritmo de DIJKSTRA
        public void A_Dijkstra(string A, string B, ListBox L, TextBox T)
        {
            int inicio = PosVertice(A);
            int final = PosVertice(B);
            int distancia = 0;
            int n = 0;
            int cantNodos = Nv;
            int actual = 0;
            int columna = 0;

            //Se crea la tabla
            //Visitado-->0
            //Distancia-->1
            //Previo-->2
            int[,] tabla = new int[cantNodos, 3];

            //Inicializando la tabla
            for (n = 0; n < cantNodos; n++)
            {
                tabla[n, 0] = 0;
                tabla[n, 1] = int.MaxValue;
                tabla[n, 2] = 0;
            }
            tabla[inicio, 1] = 0;

            //Iniciando Dijkstra
            actual = inicio;

            do
            {
                //Marcar nodo como visitado
                tabla[actual, 0] = 1;
                for (columna = 0; columna < cantNodos; columna++)
                {

                    //Buscamos a quien se dirige
                    if (ExistaArista_Vertices(VerticePorPos(actual), VerticePorPos(columna )) != null)
                    {
                        //Calculamos la distancia
                        distancia = ExistaArista_Vertices(VerticePorPos(actual), VerticePorPos(columna)).Peso + tabla[actual, 1];

                        //Colocamos las distancias
                        if (distancia < tabla[columna, 1])
                        {
                            tabla[columna, 1] = distancia;

                            //Colocamos la informacion del padre(previo)
                            tabla[columna, 2] = actual;
                        }
                    }
                }
                //El nuevo actual es el nodo con la menor distancia que no ha sido visitado
                int indiceMenor = -1;
                int distanciaMenor = int.MaxValue;

                for (int x = 0; x < cantNodos; x++)
                {
                    if (tabla[x, 1] < distanciaMenor && tabla[x, 0] == 0)
                    {
                        indiceMenor = x;
                        distanciaMenor = tabla[x, 1];
                    }
                }
                actual = indiceMenor;
            } while (actual != -1);

            //Obtenemos la ruta
            List<int> ruta = new List<int>();
            int nodo = final;
            while (nodo != inicio)
            {
                ruta.Add(nodo);
                nodo = tabla[nodo, 2];
            }
            ruta.Add(inicio);
            ruta.Reverse();

            int sumaDistancias = tabla[ruta.ElementAt(ruta.Count() - 1), 1];
            if (sumaDistancias == 0 || sumaDistancias == int.MaxValue)
            {
                L.Items.Add("No existe una ruta disponible");
            }
            else
            {
                foreach (int posicion in ruta)
                {
                    L.Items.Add("{" + VerticePorPos(posicion).Nombre + "}");
                    L.Items.Add("  ↓↓  ");
                }
                T.Text = Convert.ToString(sumaDistancias);
            }
        }

    }
}
