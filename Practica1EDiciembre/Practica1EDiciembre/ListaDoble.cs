using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1EDiciembre
{
    public class ListaDoble
    {
        Nodo primero = new Nodo();
        Nodo ultimo = new Nodo();


        public ListaDoble()
        {
            primero = null;
            ultimo = null;

        }

        public void insertarNodo(string nombre, string contra)
        {
            Nodo nuevo = new Nodo();
            NodoPila tempopila = new NodoPila();
            NodoCola tempocola = new NodoCola();



            nuevo.usuario = nombre;
            nuevo.password = contra;

            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;

                primero.siguiente = primero;
                primero.atras = ultimo;
                primero.derechapila = tempopila;
                primero.derechacola = tempocola;

            }
            else
            {
                ultimo.siguiente = nuevo;
                nuevo.atras = ultimo;
                nuevo.siguiente = primero;
                ultimo = nuevo;
                primero.atras = ultimo;
                primero.derechapila = tempopila;
                primero.derechacola = tempocola;
            }
            Console.WriteLine(" Nuevo nodo ingresado\n");
        }

        public void desplegar()
        {
            Nodo actual = new Nodo();
            actual = primero;
            if (actual != null)
            {
                do
                {
                    Console.WriteLine("USUARIO REGISTRADO: " + actual.usuario + actual.password + "\n");
                    actual = actual.siguiente;

                } while (actual != primero);

            }
            else
            {
                Console.WriteLine("La lista se encuentra Vacia \n");
            }
        }


        public Boolean Buscar(string usuario1, string contrasena)
        {
            Nodo actual = new Nodo();
            actual = primero;
            bool encontrado = false;
            string nodoBuscado = usuario1;

            if (actual != null)
            {
                do
                {
                    if ((actual.usuario == nodoBuscado) && (actual.password == contrasena))
                    {
                        Console.WriteLine("\n Nodo encontrado");
                        encontrado = true;
                        return true;
                    }

                    actual = actual.siguiente;
                } while (actual != primero && encontrado != true);
                if (!encontrado)
                {
                    Console.WriteLine("\n Nodo no encontrado");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("\n la lista se encuentra vacia \n");

            }
            return false;
        }

        public void eliminarNodo(string user)
        {
            Nodo actual = new Nodo();
            actual = primero;
            Nodo anterior = new Nodo();
            anterior = null;
            bool encontrado = false;
            string nodoBuscado = user;

            if (actual != null)
            {
                do
                {
                    if ((actual.usuario == nodoBuscado))
                    {
                        if (actual == primero)
                        {
                            primero = primero.siguiente;
                            primero.atras = ultimo;
                            ultimo.siguiente = primero;

                        }
                        else if (actual == ultimo)
                        {
                            ultimo = anterior;
                            ultimo.siguiente = primero;
                            primero.atras = ultimo;

                        }
                        else
                        {
                            anterior.siguiente = actual.siguiente;
                            actual.siguiente.atras = anterior;
                        }
                        Console.Write("Nodo eliminado con exito \n");
                        encontrado = true;

                    }
                    anterior = actual;
                    actual = actual.siguiente;
                } while (actual != primero && encontrado != true);
                if (!encontrado)
                {
                    Console.WriteLine("\n Nodo no encontrado");

                }
            }
            else
            {
                Console.WriteLine("\n la lista se encuentra vacia \n");

            }

        }
    }
}
