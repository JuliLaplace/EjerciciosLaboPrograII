using Ej_L01;

internal class Program
{
    private static void Main(string[] args)
    {

        //Consigna: Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente
        //firma: bool Validar(int valor, int min, int max)
        //● valor: dato a validar.
        //● min: mínimo valor incluido.
        //● max: máximo valor incluido.
        //Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén
        //dentro del rango - 100 y 100. Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado
        //y el promedio. IMPORTANTE Utilizar variables escalares, NO utilizar vectores/ arrays.

        int numeroMinimo=int.MinValue;
        int numeroMaximo = int.MaxValue;
        double total=0;
        
        for(int i = 0; i<10; i++)
        {
            Console.WriteLine("Ingrese un numero");
            int numeroIngresado;
            bool esNumero = int.TryParse(Console.ReadLine(), out numeroIngresado);
            while (!esNumero || !Validador.Validar(numeroIngresado, -100, 100))
            {
                Console.WriteLine("Dato incorrecto. Reingrese un numero");
                esNumero = int.TryParse(Console.ReadLine(), out numeroIngresado);
            }

            if (i == 0)
            {
                numeroMaximo = numeroIngresado;
                numeroMinimo = numeroIngresado;
            }
            else
            {
                if (numeroIngresado > numeroMaximo)
                {
                    numeroMaximo = numeroIngresado;
                }
                if (numeroIngresado < numeroMinimo)
                {
                    numeroMinimo = numeroIngresado;
                }
            }
            total += numeroIngresado;


        }

        Console.WriteLine($"El numero minimo ingresado es {numeroMinimo}, el numero maximo ingresado es {numeroMaximo}, y el promedio de todos los numeros ingresados es {total/10}");
        
    }
}