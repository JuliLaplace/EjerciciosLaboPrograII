using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //[A.03] Números primos
        //Mostrar por pantalla todos los números primos que haya hasta el número que
        //ingrese el usuario por 2 consola.
        //Nota: Utilizar estructuras repetitivas, selectivas y la función módulo(%).

        Console.Title = "Ejercicio Nro 3";

        Console.WriteLine("Ingrese un numero:");
        int numeroIngresado = int.Parse(Console.ReadLine());
        int contador = 0;

        while (numeroIngresado <= 0)
        {
            Console.WriteLine("Numero invalido. Ingrese un numero mayor a 0:");
            numeroIngresado = int.Parse(Console.ReadLine());
        }

        for(int i =1; i <= numeroIngresado; i++)
        {
            if (numeroIngresado % i == 0)
            {
                contador++;
            }
        }

        if(contador == 2)
        {
            Console.WriteLine($"El numero {numeroIngresado} es primo");
        }
        else
        {
            Console.WriteLine($"El numero {numeroIngresado} no es primo");
        }
        
    }
}