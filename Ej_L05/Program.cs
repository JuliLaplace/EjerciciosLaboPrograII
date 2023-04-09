using Microsoft.VisualBasic;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {

        //Ejercicio I05 -Aprendete las tablas 
        //Consigna: Crear una aplicación de consola que permita al usuario ingresar un número entero.
        //Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de ese número en 
        //formato string. Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el 
        //resultado. Mostrar en la consola el resultado. Por ejemplo, si se ingresa el número 2 la salida deberá ser:
        //Tabla de multiplicar del número 2:
        //    2 x 1 = 2
        //    2 x 2 = 4
        //    2 x 3 = 6
        //    2 x 4 = 8
        //    2 x 5 = 10
        //    2 x 6 = 12
        //    2 x 7 = 14 
        //    2 x 8 = 16
        //    2 x 9 = 18
        int numeroIngresado;
        bool esNumero;

        Console.WriteLine("Ingrese un numero para generar su tabla de multiplicar: ");
        esNumero= int.TryParse(Console.ReadLine(), out numeroIngresado);
        while (!esNumero)
        {
            Console.WriteLine("Dato incorrecto: Ingrese un numero para generar su tabla de multiplicar: ");
            esNumero = int.TryParse(Console.ReadLine(), out numeroIngresado);
        }

        Console.WriteLine(CrearTablaMultiplicacion(numeroIngresado));



        static string CrearTablaMultiplicacion (int numero)
        {
            StringBuilder tabla = new StringBuilder();
            for(int i = 1; i<=10; i++)
            {
                tabla.AppendLine($"{numero} x {i} = {numero*i}");
            }
            
            return tabla.ToString();
        }
    }
}