using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_L04
{
    internal class Calculadora
    {

        public static double Calcular (double num1, double num2, char opcion)
        {
            double resultado=0;
            switch (opcion)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;

                case '/':
                    if (Validar(num2))
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        resultado = 0;
                    }
                    
                    break;
            }
            return resultado;
        }

        private static bool Validar(double num2)
        {
            bool noEsCero = true;

            if (num2 == 0)
            {
                noEsCero = false;
            }
            return noEsCero;
        }
    }
}
