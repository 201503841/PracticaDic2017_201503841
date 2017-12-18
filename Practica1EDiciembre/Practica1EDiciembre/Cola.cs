using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1EDiciembre
{
    class Cola
    {
        MatrizOrtogonal llamarmatriz = new MatrizOrtogonal();
        NodoCola primero = new NodoCola();
        NodoCola ultimo = new NodoCola();

        public Cola()
        {
            primero = null;
            ultimo = null;
        }




        //Insertar un objeto en la cola (enqueue).


        public void enqueue(MatrizOrtogonal datito)
        {
            llamarmatriz = datito;
            NodoCola nuevo = new NodoCola();
            nuevo.matriz = datito;
            
            nuevo.Dato = llamarmatriz.ObtenerDato();

            if (primero == null)
            {
                primero = nuevo;
                primero.Siguiente = null;
                ultimo = primero;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                ultimo = nuevo;
            }
            Console.WriteLine("Nodo ingresado en cola \n "+ ultimo.Dato);
        }


        //int cola::Leer()
        //{

        //    pnodo nodo; /* variable auxiliar para manipular nodo */
        //    int v;      /* variable auxiliar para retorno */

        //    /* Nodo apunta al primer elemento de la pila */
        //    nodo = primero;
        //    if (!nodo) return 0; /* Si no hay nodos en la pila retornamos 0 */
        //                         /* Asignamos a primero la dirección del segundo nodo */
        //    primero = nodo->siguiente;
        //    /* Guardamos el valor de retorno */
        //    v = nodo->valor;
        //    /* Borrar el nodo */
        //    delete nodo;
        //    /* Si la cola quedó vacía, ultimo debe ser NULL también*/
        //    if (!primero) ultimo = NULL;
        //    return v;
        //}


        public void desplegarCola()
        {

            NodoCola actualcola = new NodoCola();
            actualcola = primero;
            if (primero != null)
            {
                while (actualcola != null)
                {
                    Console.WriteLine("Datos ingresados a la cola: " + actualcola.Dato);
                    actualcola = actualcola.Siguiente;
                }
            }
            else
            {
                Console.Write(" La cola esta vacia \n");
            }

        }

    }
}
