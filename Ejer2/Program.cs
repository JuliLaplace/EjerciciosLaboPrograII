using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        //[A.02] Potencias
        //Ingresar un número y mostrar: el cuadrado y el cubo del mismo.
        //Se debe validar que el número sea mayor que cero, caso contrario, mostrar el
        //mensaje: "ERROR.¡Reingresar número!".
        //Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
        Console.Title = "Ejercicio Nro 2";
        Console.WriteLine("Ingrese un numero:");
        int numeroIngresado = int.Parse(Console.ReadLine());
        while (numeroIngresado <= 0)
        {
            Console.WriteLine("ERROR.¡Reingresar número!");
            numeroIngresado = int.Parse(Console.ReadLine());
        } 

        Console.WriteLine($"El cuadrado de {numeroIngresado} es {Math.Pow(numeroIngresado,2)} y el cubo es {Math.Pow(numeroIngresado,3)}");
    }
}