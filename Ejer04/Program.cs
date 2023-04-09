internal class Program
{
    private static void Main(string[] args)
    {
        //[A.04] Números perfectos
        //Un número perfecto es un entero positivo, que es igual a la suma de todos los
        //enteros positivos(excluido el mismo) que son divisores del número.
        //El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
        //Escribir una aplicación que encuentre los 4 primeros números perfectos.
        //Nota: Utilizar estructuras repetitivas y selectivas.

        Console.Title = "Ejercicio Nro 4";

        int cantidadNumerosPerfectos = 0;
        int sumaNumeros = 0;
        int numeroInicio = 2;
        do
        {

            for (int i = 1; i < numeroInicio; i++)
            {
                if (numeroInicio % i == 0)
                {
                    sumaNumeros += i;
                }
            }
            if (sumaNumeros == numeroInicio)
            {
                Console.WriteLine($"El numero {numeroInicio} es perfecto");
                cantidadNumerosPerfectos++;
            }
            numeroInicio++;
            sumaNumeros = 0;

        } while (cantidadNumerosPerfectos != 4);



    }
}