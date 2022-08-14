using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hora_Extra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float valor0, valor1, valor2, valor3, valor4, valor5, aux, result;

            valor0 = Convert.ToInt16(textBox1.Text); // Hora total trabalhada no mes.
            valor1 = Convert.ToInt16(textBox2.Text); // salario.
            valor2 = Convert.ToInt16(textBox3.Text); // horas.
            valor3 = Convert.ToInt16(textBox4.Text); // porcentagem.

            aux = valor1 / valor0;

            textBox5.Text = Convert.ToString(aux); // resultado valor da hora sem extra.

            valor4 = valor3 / 100 * aux;
            valor5 = valor4 + aux;
            result = valor5 * valor2;

            textBox6.Text = Convert.ToString(result); // resultado da hora extra.

        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

