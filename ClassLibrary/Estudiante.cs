using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiante
    {
        //Atributos
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random; 

        //Constructores
        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante (string apellido, string nombre, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            
        }

        public string Mostrar()
        {

            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("**************************");
            cadena.AppendLine($"Nombre: {this.nombre}");
            cadena.AppendLine($"Apellido: {this.apellido}");
            cadena.AppendLine($"Legajo: {this.legajo}");
            cadena.AppendLine("**************************");
            cadena.AppendLine($"Nota primer parcial: {this.notaPrimerParcial}");
            cadena.AppendLine($"Nota segundo parcial: {this.notaSegundoParcial}");
            cadena.AppendLine("**************************");
            cadena.AppendLine($"Promedio: {CalcularPromedio()}");

            if (CalcularNotaFinal() != -1)
            {
                cadena.AppendLine($"Nota final: {CalcularNotaFinal()}");
                cadena.Append("**************************");
            }
            else
            {
                cadena.AppendLine("Alumno desaprobado");
                cadena.Append("**************************");
            }
            return cadena.ToString();
        }

        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }
        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }
             

        public double CalcularNotaFinal()
        {
            double notaFinal = -1;
            if(this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                notaFinal = (random.NextDouble() * 4)  + 6; // da un numero random entre 0 y 1. Si multiplico por 4 me queda 
                                                          //entre 0 y 4. Y si le sumo 6, el rango final es entre 6 y 10.
            }
 
            return notaFinal;
        }

        private float CalcularPromedio()
        {
            return ((this.notaPrimerParcial + this.notaSegundoParcial)/2);
        }
    }
}
