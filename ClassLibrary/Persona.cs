using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  
        public class Persona
        {
            /*Ejercicio I02 - ¿Vos cuántas primaveras tenés?
            Consigna
            Crear una aplicación de consola y una biblioteca de clases que contenga la clase
            Persona.
            Deberá tener los atributos:
            ● nombre
            ● fechaDeNacimiento
            ● dni
            Deberá tener un constructor que inicialice todos los atributos.
            Construir los siguientes métodos para la clase:
            ● Setter y getter para cada uno de los atributos.
            ● CalcularEdad será privado y retornará la edad de la persona calculándola a
            partir de la fecha de nacimiento.

            ● Mostrar retornará una cadena de texto con todos los datos de la persona,
            incluyendo la edad actual.
            ● EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino
            devuelve “es menor”.
            1. Instanciar 3 objetos de tipo Persona en el método Main.
            2. Mostrar quiénes son mayores de edad y quiénes no.*/

            private string nombre;
            private DateTime fechaDeNacimiento;
            private int dni;

            public Persona(string nombre, DateTime fecha, int dni)
            {
                this.nombre = nombre;
                this.fechaDeNacimiento = fecha;
                this.dni = dni;
            }

            public void SetNombre(string nombre)
            {
                this.nombre = nombre;
            }

            public string GetNombre()
            {
                return nombre;
            }

            public void SetDni(int dni)
            {
                this.dni = dni;
            }

            public int GetDni()
            {
                return this.dni;
            }

            public void SetFechaNacimiento(DateTime fecha)
            {
                this.fechaDeNacimiento = fecha;
            }

            public DateTime GetFechaNacimiento()
            {
                return this.fechaDeNacimiento;
            }

            private int CalcularEdad()
            {
                return DateTime.Now.Year - this.fechaDeNacimiento.Year;
            }

            public string Mostrar()
            {
                StringBuilder datos = new StringBuilder();
                datos.AppendLine($"Nombre: {this.nombre}");
                datos.AppendLine($"Edad: {CalcularEdad()}");
                datos.AppendLine($"DNI: {this.dni}");
                return datos.ToString();
            }

            public string EsMayorDeEdad()
            {
                string mayoriaDeEdad = "Es mayor de edad";
                if (CalcularEdad() < 18)
                {
                    mayoriaDeEdad = "Es menor de edad";
                }

                return mayoriaDeEdad;
            }

        }

}
