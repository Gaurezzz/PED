using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea
{
    class Nodo
    {
        //Declarando variables
        private String nombre;
        private int posX, posY;
        private string color;
        private int tamaño, grosor, peso;
        private bool dirigido;
        private Nodo anterior;
        private Nodo vertice_antecesor;
        private Nodo vertice_adyacente;
        private Nodo siguiente;

        //Constructor
        public Nodo()
        {
            nombre = null;
            posX = 0;
            posY = 0;
            color = "";
            tamaño = 0;
            grosor = 0;
            peso = 0;
            anterior = null;
            vertice_adyacente = null;
            vertice_antecesor = null;
            siguiente = null;
        }

        //Propiedades
        public string Nombre 
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int PosX
        {
            get { return posX; }
            set { posX = value; }
        }
        public int PosY 
        {
            get { return posY; }
            set { posY = value; }
        }
        public string Color
        {
            get { return color; }
            set { Color = value; }
        }
        public int Tamaño
        {
            get { return tamaño; }
            set { tamaño = value; }
        }
        public int Grosor 
        {
            get { return grosor; }
            set { grosor = value; }
        }
        public int Peso 
        {
            get { return peso; }
            set { peso = value; }
        }
        public bool Dirigido 
        {
            get { return dirigido; }
            set { dirigido = value; } 
        }
        public Nodo Anterior 
        {
            get { return anterior; }
            set { anterior = value; }
        }
        public Nodo VerticeAntecesor 
        {
            get { return vertice_antecesor; }
            set { vertice_antecesor = value; }
        }
        public Nodo VerticeAdyacente
        {
            get { return vertice_adyacente; }
            set { vertice_adyacente = value; }
        }
        public Nodo Siguiente 
        {
            get { return siguiente; }
            set { siguiente = value; }
        }



    }
}
