using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraFR
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }
        clases.Clasesuma obj = new clases.Clasesuma();
        clases.Claseresta obj2 = new clases.Claseresta();
        clases.Clasemultiplicaion obj3 = new clases.Clasemultiplicaion();
        clases.Clasedivision obj4 = new clases.Clasedivision();



        private void button17_Click(object sender, EventArgs e)
        {
            tbxscreen.Text = tbxscreen.Text + ".";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tbxscreen.Text = tbxscreen.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbxscreen.Text = tbxscreen.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbxscreen.Text = tbxscreen.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbxscreen.Text = tbxscreen.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbxscreen.Text = tbxscreen.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbxscreen.Text = tbxscreen.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbxscreen.Text = tbxscreen.Text + "6";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbxscreen.Text = tbxscreen.Text + "9";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbxscreen.Text = tbxscreen.Text + "8";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbxscreen.Text = tbxscreen.Text + "7";
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(tbxscreen.Text);
            tbxscreen.Clear();
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(tbxscreen.Text);
            tbxscreen.Clear();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(tbxscreen.Text);
            tbxscreen.Clear();
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(tbxscreen.Text);
            tbxscreen.Clear();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(tbxscreen.Text);
            double sum;
            double res;
            double multi;
            double div;

            switch (operador)
            {
                case "+":
                    sum = obj.sumar((primero), (segundo));
                    tbxscreen.Text = sum.ToString();
                    break;

                case "-":
                    res = obj2.restar((primero), (segundo));
                    tbxscreen.Text = res.ToString();
                    break;

                case "*":
                    multi = obj3.multiplicar((primero), (segundo));
                    tbxscreen.Text = multi.ToString();
                    break;

                case "/":
                    div = obj4.dividir((primero), (segundo));
                    tbxscreen.Text = div.ToString();
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
