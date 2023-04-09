using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_L06
{
    internal class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado) {
            return (longitudLado*longitudLado);
        }
        public static double CalcularAreaTriangulo(double basee, double altura) {
            return ((basee*altura)/2);
        }
        public static double CalcularAreaCirculo(double radio) {
            return (Math.PI * Math.Pow(radio, 2));
        }
    }
}
