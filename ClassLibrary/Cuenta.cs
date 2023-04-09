using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuenta
    {
        /*Deberá tener los atributos:
        ● titular que contendrá la razón social del titular de la cuenta.
        ● cantidad que será un número decimal que representa al monto actual de dinero
        en la cuenta.
        Construir los siguientes métodos para la clase:
        ● Un constructor que permita inicializar todos los atributos.
        ● Un método getter para cada atributo.
        ● mostrar retornará una cadena de texto con todos los datos de la cuenta.
        ● ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es
        negativo, no se hará nada.
        ● retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en
        negativo.*/

        //Atributos
        private string titular;
        private double cantidad;

        public Cuenta(string nombre, double cantidad)
        {
            this.titular = nombre;
            this.cantidad = cantidad;
        }

        public string Nombre
        {
            get { return titular; }
        }

        public double Cantidad
        {
            get { return cantidad; } 
        }

        public string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("*******************************************");
            cadena.AppendLine($"Titular de la cuenta: {Nombre}");
            cadena.AppendLine($"Monto actual: {Cantidad}");
            cadena.AppendLine("*******************************************");

            return cadena.ToString();
        }

        public void Ingresar(double monto)
        {
            if (monto > 0)
            {
                this.cantidad += monto;
            }
        }

        public void Retirar(double monto)
        {
            this.cantidad -=monto;
        }
    }
}
