using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1EDiciembre
{
    class NodoPila
    {
        private int dato;
        private NodoPila siguiente;
        private MatrizOrtogonal Matriz;


        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public MatrizOrtogonal matriz
        {
            get { return Matriz; }
            set { Matriz = value; }
        }

        public NodoPila Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

    }
}
