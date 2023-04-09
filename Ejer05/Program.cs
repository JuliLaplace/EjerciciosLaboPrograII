using System;

internal class Program
{
    private static void Main(string[] args)
    {

        //[A.05] Centros Numéricos
        //Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de
        //números, cuyas sumas son iguales. El primer centro numérico es el 6, el cual separa la lista(1 a 8) en los
        //grupos: (1; 2; 3; 4; 5) y(7; 8) cuyas sumas son ambas iguales a 15. El segundo centro numérico es el
        //35, el cual separa la lista(1 a 49) en los grupos: (1 a 34) y(36 a 49) cuyas sumas son ambas iguales a 595.
        //Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese
        //por consola.
        //Nota: Utilizar estructuras repetitivas y selectivas.

        int numeroIngresado;

        Console.WriteLine("Ingrese un numero:");
        

        while(int.TryParse(Console.ReadLine(), out numeroIngresado))
        {
                for(int centro  = 1; centro < numeroIngresado; centro++)
                {
                    int sumaNumerosAnteriores = 0;
                    for(int i =0; i<centro; i++)
                    {
                        sumaNumerosAnteriores += i;
                    }
                    int sumaNumerosPosteriores = 0;
                    for(int j =centro+1; j <=sumaNumerosAnteriores; j++)
                    {
                        if ((sumaNumerosPosteriores == sumaNumerosAnteriores) || (sumaNumerosPosteriores>sumaNumerosAnteriores))
                        {
                            break;
                        }
                        sumaNumerosPosteriores += j;
                    }

                    if (sumaNumerosAnteriores == sumaNumerosPosteriores)
                    {
                        Console.WriteLine($"El numero {centro} es un numero centro");

                    }
                
                }
        }
        
        Console.WriteLine("No se ingreso un numero");
        Console.ReadKey();
    }
}