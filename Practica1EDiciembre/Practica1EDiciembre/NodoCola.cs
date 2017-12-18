using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1EDiciembre
{
    class NodoCola
    {
        private int dato;
        private NodoCola siguiente;
        private MatrizOrtogonal Matriz;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }




        public NodoCola Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public MatrizOrtogonal matriz
        {
            get { return Matriz; }
            set { Matriz = value; }
        }
    }
}
