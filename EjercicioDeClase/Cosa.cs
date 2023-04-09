using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeClase
{
    public class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;


        /*+) Cosa(DateTime, int, string)

        */

        public Cosa()
        {
            this.fecha = DateTime.Now;
            this.entero = 10;
            this.cadena = "Sin valor";
        }

        public Cosa(string valor) : this()
        {
            this.cadena = valor;
        }

        public Cosa(int numero, string valor) : this(valor)
        {
            this.entero = numero;
        }

        public Cosa(DateTime fecha, int numero, string valor) : this(numero, valor)
        {
            this.fecha = fecha;
        } 



        public void EstablecerValor(int valor)
        {
            this.entero = valor;
        }

        public void EstablecerValor(string valor)
        {
            this.cadena = valor;
        }
        public void EstablecerValor(DateTime valor)
        {
            this.fecha = valor;
        }
  
        private string Mostrar()
        {
            return this.entero + " " + this.cadena + " " + this.fecha;
        }
        public static string Mostrar(Cosa obj)
        {
            return Cosa.Mostrar();
        }
    }
}
