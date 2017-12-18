using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1EDiciembre
{
    class NodoMatrizOrtogonal
    {
        private int entrada;
        private int ejex;
        private int ejey;
        private NodoMatrizOrtogonal arriba;
        private NodoMatrizOrtogonal abajo;
        private NodoMatrizOrtogonal derecha;
        private NodoMatrizOrtogonal izquierda;

        public NodoMatrizOrtogonal(int cantidad, int UbicacionX, int UbicacionY)
        {
            entrada = cantidad;
            ejex = UbicacionX;
            ejey = UbicacionY;

        }
        public NodoMatrizOrtogonal Arriba
        {
            get { return arriba; }
            set { arriba = value; }
        }


        public NodoMatrizOrtogonal Abajo
        {
            get { return abajo; }
            set { abajo = value; }
        }

        public NodoMatrizOrtogonal Derecha
        {
            get { return derecha; }
            set { derecha = value; }
        }

        public NodoMatrizOrtogonal Izquierda
        {
            get { return izquierda; }
            set { izquierda = value; }
        }
        public int Entrada
        {
            get { return entrada; }
            set { entrada = value; }
        }

        public int EjeX
        {
            get { return ejex; }
            set { ejex = value; }

        }

        public int EjeY
        {
            get { return ejey; }
            set { ejey = value; }
        }
    }
}
