using Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        //Creo los tres objetos 
        Estudiante estudiante1 = new Estudiante("Laplace", "Julieta", "111246");
        Estudiante estudiante2 = new Estudiante("Man", "Morty", "123456");
        Estudiante estudiante3 = new Estudiante("Ciana", "Effy", "030345");
        //Cargo sus notas (morty esta desaprobado)
        estudiante1.SetNotaPrimerParcial(6);
        estudiante1.SetNotaSegundoParcial(8);
        estudiante2.SetNotaPrimerParcial(2);
        estudiante2.SetNotaSegundoParcial(9);
        estudiante3.SetNotaPrimerParcial(9);
        estudiante3.SetNotaSegundoParcial(10);
        //Muestro la informacion
        Console.WriteLine(estudiante1.Mostrar());
        Console.WriteLine(estudiante2.Mostrar());
        Console.WriteLine(estudiante3.Mostrar());
        
    }
}