using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp6
{
    public partial class Form1 : Form
    {
        Calculadora NuevaCalculadora = new Calculadora();
        float resultado;
        string operador;
        int numero = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void click(object sender, EventArgs e)
        {
            Numbers(sender); // creo funcion para agregar cada numero con cada click
        }

        private void button17_Click(object sender, EventArgs e) // BOTON DE BORRAR TODO
        {
            resultado = 0;
            operador = "";
            numero = 0;
            NuevaCalculadora.num1 = default(float);
            NuevaCalculadora.num2 = default(float);
        }
        private void Numbers(object sender)
        {
            Button boton = (Button)sender;
            switch (boton.Text)
            {
                case "+":
                    operador = "+"; 
                    if (textBox1.Text != "")
                    { //Evito que el programa crashee al querer hacer una operacion de un valor vacío.
                        NuevaCalculadora.num1 = float.Parse(textBox1.Text);
                        textBox1.Text += operador;
                    }
                    numero = 1;
                    break;
                case "-":
                    operador = "-";
                    if (textBox1.Text != "")
                    {
                        NuevaCalculadora.num1 = float.Parse(textBox1.Text);
                        textBox1.Text += operador;
                    }
                    numero = 1;
                    break;
                case "/":
                    operador = "/";
                    if (textBox1.Text != "")
                    {
                        NuevaCalculadora.num1 = float.Parse(textBox1.Text);
                        textBox1.Text += operador;
                    }
                    numero = 1;
                    break;
                case "*":
                    operador = "*";
                    if (textBox1.Text != "")
                    {
                        NuevaCalculadora.num1 = float.Parse(textBox1.Text);
                        textBox1.Text += operador;
                    }
                    numero = 1;
                    break;
                default:
                    textBox1.Text += boton.Text;
                    break;
            }
            if (numero == 1)
            {
                textBox1.Text = NuevaCalculadora.num1.ToString();
            }
            textBox1.Text += operador;
        }
    }
    }

