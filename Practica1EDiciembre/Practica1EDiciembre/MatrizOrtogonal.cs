using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1EDiciembre
{
    class MatrizOrtogonal
    {
        int EjeenX;
        int EjeenY;
        NodoMatrizOrtogonal NodoCabeza = new NodoMatrizOrtogonal(0, 0, 0);



        public MatrizOrtogonal crearMatriz(int dimX, int dimY)
        {


            //DIMENSION DE MATRIZ
            EjeenX = dimX;
            EjeenY = dimY;


            //CONTADORES HORIZONTALES Y VERTICALES
            int contadorfila = 1;
            int contadorcolumna = 0;



            //NODOS QUE AUXILIARES
            NodoMatrizOrtogonal NodoTemporalH = NodoCabeza;
            NodoMatrizOrtogonal NodoTemporalV = NodoCabeza;
            NodoMatrizOrtogonal NodoDobleTemporal = NodoCabeza;


            while (contadorcolumna < dimY)
            {
                while (contadorfila < dimX)
                {
                    NodoMatrizOrtogonal NodoNuevo = new NodoMatrizOrtogonal(0, contadorfila, contadorcolumna);

                    NodoTemporalH.Derecha = NodoNuevo;
                    NodoNuevo.Izquierda = NodoTemporalH;
                    NodoTemporalH = NodoNuevo;


                    if (contadorcolumna > 0)
                    {
                        NodoTemporalV = NodoTemporalV.Derecha;
                        NodoNuevo.Arriba = NodoTemporalV;
                        NodoTemporalV.Abajo = NodoNuevo;
                    }
                    Console.WriteLine("Insertando X: " + Convert.ToString(contadorfila) + ", Y: " + Convert.ToString(contadorcolumna));

                    contadorfila++;
                }

                if ((contadorcolumna + 1) != dimY)
                {
                    contadorfila = 0;
                    contadorcolumna++;
                    NodoTemporalV = NodoDobleTemporal;
                    NodoMatrizOrtogonal nuevoY = new NodoMatrizOrtogonal(0, contadorfila, contadorcolumna);
                    NodoDobleTemporal.Abajo = nuevoY;
                    nuevoY.Arriba = NodoDobleTemporal;
                    NodoDobleTemporal = nuevoY;
                    NodoTemporalH = NodoDobleTemporal;
                    Console.WriteLine("Insertando X: " + Convert.ToString(contadorfila) + ", Y: " + Convert.ToString(contadorcolumna));
                    contadorfila = 1;
                }
                else
                {
                    contadorcolumna++;
                }
            }
            return this;
        }

        public NodoMatrizOrtogonal Buscar(int Fila, int Colummna)
        {
            NodoMatrizOrtogonal AuxiliarenH = NodoCabeza;
            NodoMatrizOrtogonal AuxiliarenV = NodoCabeza;


            for (int conta1 = 0; conta1 < Fila; conta1++)
            {
                for (int conta2 = 0; conta2 < Colummna; conta2++)
                {

                    AuxiliarenH = AuxiliarenH.Derecha;
                    AuxiliarenV = AuxiliarenH;

                }
                AuxiliarenV = AuxiliarenV.Abajo;
            }


            return AuxiliarenV;
        }

        public void MeterDato(int coordenadax, int coordenaday, int cantidad)
        {

            NodoMatrizOrtogonal AuxiliarNodo = NodoCabeza;

            int contadorenx = 0;
            int contadoreny = 0;

            while (contadoreny < coordenaday)
            {
                while (contadorenx < coordenadax)
                {
                    AuxiliarNodo = AuxiliarNodo.Derecha;
                    contadorenx++;
                }
                AuxiliarNodo = AuxiliarNodo.Abajo;
                contadoreny++;
            }
            AuxiliarNodo.Entrada = cantidad;
           


        }


        public int ObtenerDato()
        {
            NodoMatrizOrtogonal auxColum = NodoCabeza;
            NodoMatrizOrtogonal auxFila = NodoCabeza;


            int dato = 0;

            for (int contador1 = 0; contador1 < EjeenY; contador1++)
            {
                for (int contador2 = 0; contador2 < EjeenX; contador2++)
                {
                    dato = dato + auxColum.Entrada;
                    auxColum = auxColum.Derecha;
                }
                auxFila = auxFila.Abajo;
                auxColum = auxFila;
            }
            Console.WriteLine(" dato que devuleve: " + dato);
            return dato;

        

        }
    }
}
