﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aerolinea
{
    public class Nodo
    {
        //Declarando variables
        private String nombre;
        private int posX, posY;
        private string colorNodo;
        private int tamaño, grosor;
        private int peso;
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
            colorNodo = "";
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
        public string ColorNodo
        {
            get { return colorNodo; }
            set { colorNodo = value; }
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
