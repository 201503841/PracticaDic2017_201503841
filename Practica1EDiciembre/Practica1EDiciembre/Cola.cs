using System;
using System.Collections.Generic;
using System.IO;
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

            var Doc = File.Create(@"C:\Users\Suseth\Documents\Visual Studio 2015\Projects\Practica1EDiciembre\MyPila.txt");
            Doc.Close();
            StreamWriter escribiendo = new StreamWriter(@"C:\Users\Suseth\Documents\Visual Studio 2015\Projects\Practica1EDiciembre\MyPila.txt");
            escribiendo.WriteLine("Digraph {");

            NodoCola actualcola = new NodoCola();
            actualcola = primero;
            if (primero != null)
            {
                while (actualcola.Siguiente!= null)
                {
                    Console.WriteLine("Datos ingresados a la cola: " + actualcola.Dato);
                    escribiendo.WriteLine(actualcola.Dato + "->" + actualcola.Siguiente.Dato + ";");
                    actualcola = actualcola.Siguiente;
                }
            }
            else
            {
                Console.Write(" La cola esta vacia \n");
            }
            escribiendo.WriteLine("}");
            escribiendo.Close();
        }

    }
}
