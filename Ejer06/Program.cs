﻿using System.Runtime.Intrinsics.X86;

internal class Program
{
    private static void Main(string[] args)
    {

        //[A.06] Bis sextus dies ante calendas martii
        //Escribir un programa que determine si un año es bisiesto. Un año es bisiesto si es múltiplo de 4. Los años
        //múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400.Por ejemplo: el año 2000 es
        //bisiesto pero 1900 no. Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos
        //en ese rango.
        //Nota: Utilizar estructuras repetitivas, selectivas y la función módulo(%).


        Console.WriteLine("Ingrese un año de inicio:");
        int anioInicio = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese un año final:");
        int anioFinal = int.Parse(Console.ReadLine());


        for(int i = anioInicio; i <=anioFinal; i++)
        {
            if ( (i % 4 == 0 && i%100 !=0) || (i%100==0 && i%400 ==0))
            {
                Console.WriteLine($"El año {i} es bisiesto");
            }
        }
    }
}