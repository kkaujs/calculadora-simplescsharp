using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudoforms1
{
    public class Calculos
    {
        private double valor1, valor2;

        public void SetValor1(double valor1)
        {
            this.valor1 = valor1;
        }

        public double GetValor1()
        {
            return valor1;
        }

        public void SetValor2(double valor2)
        {
            this.valor2 = valor2;
        }

        public double GetValor2()
        {
            return valor2;
        }

        public double Somar()
        {
            double resultado;
            resultado = valor1 + valor2;
            return resultado;
        }

        public double Diminuir()
        {
            double resultado;
            resultado = valor1 - valor2;
            return resultado;
        }

        public double Multiplicar()
        {
            double resultado;
            resultado = valor1 * valor2;
            return resultado;
        }

        public double Dividir()
        {
            double resultado;
            resultado = valor1/valor2;
            return resultado;
        }
    }
}
