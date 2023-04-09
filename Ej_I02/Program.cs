using Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
       
        /*  1. Instanciar 3 objetos de tipo Persona en el método Main.
        2. Mostrar quiénes son mayores de edad y quiénes no.*/
        
        Persona persona1 = new Persona("Julieta", DateTime.Parse("09/04/1991"), 35411575);
        
        Persona persona2 = new Persona("Morty", DateTime.Parse("01/12/2018"), 16529834);
        Persona persona3 = new Persona("Effy", DateTime.Parse("20/12/2000"), 27563817);

        


        Console.WriteLine(persona1.Mostrar());
        Console.WriteLine("**********************************************************");
        Console.WriteLine($"La persona {persona1.GetNombre()} {persona1.EsMayorDeEdad()}");
        Console.WriteLine($"La persona {persona2.GetNombre()} {persona2.EsMayorDeEdad()}");
        Console.WriteLine($"La persona {persona3.GetNombre()} {persona3.EsMayorDeEdad()}");
    }
}