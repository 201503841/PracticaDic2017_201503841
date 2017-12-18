using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1EDiciembre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Program.ListaDC.insertarNodo("admin", "1234");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.ListaDC.Buscar(textBox1.Text.ToString(), textBox2.Text.ToString()) == true)
            {

               // this.Hide();
                Form2 frm = new Form2();
                frm.Show();
            }
            else
            {
                label3.Text = "CONTRASENA O USUARIO INCORRECTO";
            }
        }
    }
}
