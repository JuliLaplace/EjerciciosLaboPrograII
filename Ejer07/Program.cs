using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {

        //[A.07] ¿Cuántos días viviste?
        //Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y calcule
        //el número de días vividos por esa persona hasta la fecha actual(tomar la fecha del sistema con DateTime.Now).
        //Nota: Utilizar estructuras selectivas.Tener en cuenta los años bisiestos.


        //Console.WriteLine("Ingrese dia de nacimiento");
        //int dia = int.Parse(Console.ReadLine());
        //Console.WriteLine("Ingrese mes de nacimiento");
        //int mes = int.Parse(Console.ReadLine());
        //Console.WriteLine("Ingrese año de nacimiento");
        //int anio = int.Parse(Console.ReadLine());
        //DateTime fechaNacimiento = new DateTime(anio, mes, dia);


        Console.WriteLine("Ingrese su fecha de nacimiento: dd-mm-aaaa");
        DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());
        DateTime dateTime = DateTime.Now;
        Console.WriteLine($"Dias vividos: {(dateTime - fechaNacimiento).Days} ");



    }
}