using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1EDiciembre
{
    class Nodo
    {
        private string Usuario;
        private string Password;
        private Nodo Siguiente;
        private Nodo Atras;
        private NodoPila DerechaPila;
        private NodoCola DerechaCola;


        public string usuario
        {
            get { return Usuario; }
            set { Usuario = value; }
        }

        public string password
        {
            get { return Password; }
            set { Password = value; }
        }

        public Nodo siguiente
        {

            get { return Siguiente; }
            set { Siguiente = value; }
        }

        public NodoPila derechapila
        {
            get { return DerechaPila; }
            set { DerechaPila = value; }
        }

        public NodoCola derechacola
        {
            get { return DerechaCola; }
            set { DerechaCola = value; }
        }

        public Nodo atras
        {
            get { return Atras; }
            set { Atras = value; }
        }


    }
}
