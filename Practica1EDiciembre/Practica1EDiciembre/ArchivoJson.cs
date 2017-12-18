using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1EDiciembre
{
    
        public class TransferObject
        {
            public Archivo archivo { get; set; }
        }

        public class Archivo
        {
            public Pila1 pila { get; set; }
            public Cola1 cola { get; set; }
        }

        public class Pila1
        {
            public Matrices matrices { get; set; }
        }

        public class Matrices
        {
            public Matriz[] matriz { get; set; }
        }

        public class Matriz
        {
            public string size_x { get; set; }
            public string size_y { get; set; }
            public Valores valores { get; set; }
        }

        public class Valores
        {
            public Valor[] valor { get; set; }
        }

        public class Valor
        {
            public string pos_x { get; set; }
            public string pos_y { get; set; }
            public string dato { get; set; }
        }

        public class Cola1
        {
            public Matrices1 matrices { get; set; }
        }

        public class Matrices1
        {
            public Matriz1[] matriz { get; set; }
        }

        public class Matriz1
        {
            public string size_x { get; set; }
            public string size_y { get; set; }
            public Valores1 valores { get; set; }
        }

        public class Valores1
        {
            public Valor1[] valor { get; set; }
        }

        public class Valor1
        {
            public string pos_x { get; set; }
            public string pos_y { get; set; }
            public string dato { get; set; }
        }

    
}
