using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1EDiciembre
{
    class Pila
    {
        public MatrizOrtogonal llamar = new MatrizOrtogonal();
        public NodoPila ultimo = new NodoPila();

        public Pila()
        {

            ultimo = null;
        }


        public void push(MatrizOrtogonal matriz1)
        {
            llamar = matriz1;
            NodoPila Nuevo = new NodoPila();
            Nuevo.matriz = matriz1;
            Nuevo.Dato = llamar.ObtenerDato();

            if (ultimo == null)
            {
                ultimo = Nuevo;
            }
            else
            {

                Nuevo.Siguiente = ultimo;
                ultimo = Nuevo;
            }
            Console.WriteLine("Nodo ingresado \n");

        }



        public int Pop() // sacar elementos de la pila

        {

            NodoPila auxnodo = new NodoPila(); /* variable auxiliar para manipular nodo */
            int v;      /* variable auxiliar para retorno */

            if (ultimo == null)
            {
                return 0;
            }
            else
            {
                /* Nodo apunta al primer elemento de la pila */
                auxnodo = ultimo;

                /* Asignamos a pila toda la pila menos el primer elemento */
                ultimo = auxnodo.Siguiente;

                /* Guardamos el valor de retorno */
                v = auxnodo.Dato;


                return v;
            }
        }


        public void desplegarPila()
        {
            var Doc = File.Create(@"C:\Users\Suseth\Documents\Visual Studio 2015\Projects\Practica1EDiciembre\MyCola.txt");
            Doc.Close();
            StreamWriter escribiendo = new StreamWriter(@"C:\Users\Suseth\Documents\Visual Studio 2015\Projects\Practica1EDiciembre\MyCola.txt");
            escribiendo.WriteLine("Diagraph {");


          
            NodoPila Actual = new NodoPila();
            Actual = ultimo;

            if (ultimo != null)
            {
                // encabezadoPila();
                while (Actual != null)
                {

                    Console.WriteLine("Dato de la pila: " + Actual.Dato);
                    escribiendo.WriteLine(Actual.Dato + "->" + Actual.Dato + ";");
                    //string nombrenodo = Actual.Dato.ToString();

                    //string escribiendo = nombrenodo + "[label=\"" + Actual.Dato + "\\n"+ "\"];";

                    Actual = Actual.Siguiente;
                }

                //txtPila("}");
            }
            else
            {
                Console.WriteLine(" La pila se encuentra Vacia \n");

            }
            escribiendo.WriteLine("}");
              escribiendo.Close();
        }


        public void txtPila(string escritura)
        {
            
            try
            {
                TextWriter archivo;
                archivo = new StreamWriter(@"C:\Users\Suseth\Documents\Visual Studio 2015\Projects\Practica1EDiciembre\Practica1EDiciembre\MyCola.txt");
               
                
                archivo.WriteLine(escritura);
                archivo.Close();
                Console.WriteLine("Archivo creado correrctamente \n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }


        public void encabezadoPila()
        {

           

            

            //try
            //{
            //    TextWriter archivo;
            //    archivo = new StreamWriter ("archivoa.txt");
            //    string mensaje;
            //    mensaje = ("Diagraph {");
            //    archivo.WriteLine(mensaje);
            //    archivo.Close();
            //    Console.WriteLine("Archivo creado correrctamente \n");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Exception: " + e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Executing finally block.");
            //}

        }

        public void graficadoraCola()
         {
           string Comm = "dot -Tpng C:\\Users\\Suseth\\Documents\\Visual Studio 2015\\Projects\\Practica1EDiciembre\\MyCola.txt -o MyCola.png";
           System.Diagnostics.Process.Start(Comm);
        }
   }
    
}
