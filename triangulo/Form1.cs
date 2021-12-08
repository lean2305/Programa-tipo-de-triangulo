using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triangulo
{
    public partial class Form1 : Form
    {
        double a= 0, b=0, c=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            //todos iguais

            if (textBox1.Text == textBox2.Text && textBox1.Text== textBox3.Text)
            {
                textBox4.Text = "É um triângulo equilátero (todos os lados são iguais)";
            }

            //fim

            //dois iguais e um diferente
            if (textBox1.Text == textBox2.Text && textBox1.Text != textBox3.Text)
            {
                textBox4.Text = "É um triângulo isósceles (dois lados iguais e um diferente)";
            }
            if (textBox1.Text != textBox2.Text && textBox1.Text == textBox3.Text)
            {
                textBox4.Text = "É um triângulo isósceles (dois lados iguais e um diferente)";
            }
            if (textBox1.Text != textBox2.Text && textBox2.Text == textBox3.Text)
            {
                textBox4.Text = "É um triângulo isósceles (dois lados iguais e um diferente)";
            }

            //fim

            //Todos os lados diferentes
            if (textBox1.Text != textBox2.Text && textBox1.Text != textBox3.Text && textBox2.Text != textBox3.Text)
            {
                textBox4.Text = "É um triângulo escaleno (todos os lados diferentes)";
            }


            //fim

             //Não é um triangulo





            if( textBox1.Text == "0")
            {
                textBox4.Text = "Não é um triângulo (a soma dos dois lados menores é menor que o lado maior ou um lado é menor ou igual a zero)";
            }
            if (textBox2.Text == "0")
            {
                textBox4.Text = "Não é um triângulo (a soma dos dois lados menores é menor que o lado maior ou um lado é menor ou igual a zero)";
            }
            if (textBox3.Text == "0")
            {
                textBox4.Text = "Não é um triângulo (a soma dos dois lados menores é menor que o lado maior ou um lado é menor ou igual a zero)";
            }


            //fim


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
