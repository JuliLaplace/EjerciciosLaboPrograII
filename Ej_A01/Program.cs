using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //Ejercicio A01 -Calcular un factorial Consigna
        //El factorial de un número es una operación que consiste en multiplicar un número “n”
        //por todos los números enteros positivos que estén debajo de él, por ejemplo el factorial
        //de 3 es el resultado de multiplicar 3 por 2 por 1.
        //En una aplicación de consola, desarrollar un método estático que calcule el factorial de
        //un número dado.

        int numeroIngresado;
        bool esNumero;
        int factorial;
        Console.WriteLine("Ingrese un numero para calcular su factorial:");
        esNumero = int.TryParse(Console.ReadLine(), out numeroIngresado);
        while (!(esNumero) || numeroIngresado<0)
        {
            Console.WriteLine("Usted ingreso un dato invalido. Ingrese un numero (positivo) para calcular su factorial:");
            esNumero = int.TryParse(Console.ReadLine(), out numeroIngresado);
        }


        factorial = CalcularFactorial(numeroIngresado);


        Console.WriteLine($"El factorial de {numeroIngresado} es {factorial}");
        
        
        static int CalcularFactorial (int numero)
        {
            int resultado = numero;
            for(int i = 1; i<numero; i++)
            {
                resultado *= i;
            }

            return resultado;
        }

    }
}