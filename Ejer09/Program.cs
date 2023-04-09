internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio Nro 9";

        Console.WriteLine("Ingrerse la altura del triangulo");
        int alturaTriangulo = int.Parse(Console.ReadLine());
        string triangulo = "*";

        for (int i = 0; i < alturaTriangulo; i++)
        {
            if (i == 0)
            {
                Console.WriteLine($"{triangulo}");

            }
            else
            {
                triangulo += "**";
                Console.WriteLine($"{triangulo}");
            }
        }
        
    }
}