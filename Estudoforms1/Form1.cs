using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudoforms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            valor1 = Decimal.Parse(txtCalculo.Text, CultureInfo.InvariantCulture);
            txtCalculo.Clear();
            operacao = "soma";
            parcial.Text = valor1 + " +";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "9";
        }

        private void apaga_Click(object sender, EventArgs e)
        {
            txtCalculo.Clear();
        }

        private void parcial_Click(object sender, EventArgs e)
        {

        }

        private void multiplica_Click(object sender, EventArgs e)
        {
            valor1 = Decimal.Parse(txtCalculo.Text, CultureInfo.InvariantCulture);
            txtCalculo.Clear();
            operacao = "mult";
            parcial.Text = valor1 + " x";
        }

        private void subtrai_Click(object sender, EventArgs e)
        {
            valor1 = Decimal.Parse(txtCalculo.Text, CultureInfo.InvariantCulture);
            txtCalculo.Clear();
            operacao = "sub";
            parcial.Text = valor1 + " -";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            valor1 = Decimal.Parse(txtCalculo.Text, CultureInfo.InvariantCulture);
            txtCalculo.Clear();
            operacao = "div";
            parcial.Text = valor1 + " /";
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            valor2 = Decimal.Parse(txtCalculo.Text, CultureInfo.InvariantCulture);
            if (operacao.Equals("soma"))
            {
               txtCalculo.Text = Convert.ToString(valor1 + valor2);
                Historico.Items.Add(txtCalculo.Text);
            }else if (operacao.Equals("sub"))
            {
                txtCalculo.Text = Convert.ToString(valor1 - valor2);
                Historico.Items.Add(txtCalculo.Text);
            }
            else if (operacao.Equals("mult"))
            {
                txtCalculo.Text = Convert.ToString(valor1 * valor2);
                Historico.Items.Add(txtCalculo.Text);
            }
            else if (operacao.Equals("div"))
            {
                txtCalculo.Text = Convert.ToString(valor1 / valor2);
                Historico.Items.Add(txtCalculo.Text);
            }


            parcial.Text = "";
        }
    }
}
