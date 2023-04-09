using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //[A.01] Máximos, mínimos y promedios. Ingresar 5 números por consola,
        //guardandolos en una variable escalar.
        //Calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
        Console.Title = "Ejercicio Nro 1";
        int numeroMaximo=0;
        int numeroMinimo=0;
        int totalNumerosIngresados = 0;
        float promedio=0;
        //int bandera = 0;

        for (int i = 0; i< 5; i++)
        {
            Console.WriteLine("Ingrese un numero:");
            int numeroIngresado = int.Parse(Console.ReadLine());

            if(i==0)
            {
                numeroMaximo = numeroIngresado;
                numeroMinimo = numeroIngresado;
                totalNumerosIngresados += numeroIngresado;
            }
            else
            {
                if(numeroIngresado > numeroMaximo)
                {
                    numeroMaximo = numeroIngresado;
                }

                if (numeroIngresado < numeroMinimo)
                {
                    numeroMinimo = numeroIngresado;
                }

                totalNumerosIngresados += numeroIngresado;
            }

        }

        promedio = totalNumerosIngresados / 5;
        Console.WriteLine($" El valor maximo es {numeroMaximo}, el valor minimo es {numeroMinimo} y el promedio de todos los numeros ingresados es {promedio}");
    }
}