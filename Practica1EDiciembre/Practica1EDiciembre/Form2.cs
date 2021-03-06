﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;

namespace Practica1EDiciembre
{
    public partial class Form2 : Form
    {
        string ruta;
        string documento;
        string fileJSON;

       
        Pila LLPila = new Pila();
        Cola LLCola = new Cola();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.ListaDC.insertarNodo(textBox1.Text.ToString(), textBox2.Text.ToString());

            label3.Text = "El usuario " + textBox1.Text.ToString() + "  fue cargado con exito";
            textBox1.Clear();
            textBox2.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.ListaDC.desplegar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 back = new Form1();
            back.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.ListaDC.eliminarNodo(textBox3.Text.ToString());
            label5.Text = "Usuario Eliminado";
        }

        public void deserealizarJSON(string strJSON)
        {
            
            try
            {
                var jPerson = JsonConvert.DeserializeObject<TransferObject>(strJSON);
                Console.WriteLine("Heres our JSON object: " + jPerson.ToString());


                Console.WriteLine("Waiting to print matriz.... \n");

                //Console.WriteLine("leyendo en archivo JSON: " + jPerson.archivo.pila.matrices.ToString());
                //Console.WriteLine("Here s is size x " + jPerson.archivo.cola.matrices.matriz.ToString());

                // leer datos de la pila
                foreach(var datosadentrodematriz in jPerson.archivo.pila.matrices.matriz)
                {

                    MatrizOrtogonal LLMatriz = new MatrizOrtogonal();

                    Console.WriteLine("tamano de matriz de pila: " + datosadentrodematriz.size_x.ToString() + "-" + datosadentrodematriz.size_y.ToString()+"\n");
                    LLMatriz.crearMatriz(Convert.ToInt32(datosadentrodematriz.size_x), Convert.ToInt32(datosadentrodematriz.size_y));

                    
                    foreach (var datosdematrizmatriz in datosadentrodematriz.valores.valor)
                    {
                        Console.Write(" Posicion y valor de matriz pila: " +datosdematrizmatriz.dato.ToString() + "-" + datosdematrizmatriz.pos_x.ToString() + "-" + datosdematrizmatriz.pos_y.ToString() + "\n");
                        LLMatriz.MeterDato(Convert.ToInt32(datosdematrizmatriz.pos_x),Convert.ToInt32(datosdematrizmatriz.pos_y), Convert.ToInt32(datosdematrizmatriz.dato));
                        
                    }
                    //LLMatriz.recorre(Convert.ToInt32(datosadentrodematriz.size_x), Convert.ToInt32(datosadentrodematriz.size_y));

                   // 
                    LLPila.push(LLMatriz);
                    LLMatriz.ObtenerDato();
                   
                }

              //  LLPila.desplegarPila();

                //leer datos de la cola
                foreach (var primeraseccion in jPerson.archivo.cola.matrices.matriz)
            {
                    MatrizOrtogonal LLMatriz1 = new MatrizOrtogonal();
                    Console.WriteLine("tamano de matriz de cola: " + primeraseccion.size_x.ToString() + "-" + primeraseccion.size_y.ToString() + "\n");
                    LLMatriz1.crearMatriz(Convert.ToInt32(primeraseccion.size_x), Convert.ToInt32(primeraseccion.size_y));
                foreach (var segundaseccion in primeraseccion.valores.valor)
                {
                    Console.Write(" Posicion y valor de matriz cola: " + segundaseccion.dato.ToString() + "-" + segundaseccion.pos_x.ToString() + "-" + segundaseccion.pos_y.ToString() + "\n");
                        LLMatriz1.MeterDato(Convert.ToInt32(segundaseccion.pos_x), Convert.ToInt32(segundaseccion.pos_y), Convert.ToInt32(segundaseccion.dato));
                }
                    LLCola.enqueue(LLMatriz1);
                    LLMatriz1.ObtenerDato();
                   // LLCola.desplegarCola();

            }

        }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message.ToString() + Environment.NewLine);

            }
}

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ElectorDeArchivo = new OpenFileDialog();

            if (ElectorDeArchivo.ShowDialog() == DialogResult.OK)
            {
                ruta = ElectorDeArchivo.FileName;
            }

              documento = System.IO.File.ReadAllText(ruta);
              deserealizarJSON(documento);

            //ProcessStartInfo startInfo = new ProcessStartInfo("dot.exe");
            //startInfo.Arguments = "-Tpng graph.dot -o graph.png";

            //Process.Start(startInfo);
            // fileJSON = File.ReadAllText(@"C:\Users\Suseth\Desktop\ejemplo1.json");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            LLPila.desplegarPila();
           // LLPila.graficadoraCola();

       
            
           

        }

        private void button7_Click(object sender, EventArgs e)
        {
            LLCola.desplegarCola();
        }
    }
}
