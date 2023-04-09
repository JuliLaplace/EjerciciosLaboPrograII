internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio Nro 10";

        Console.WriteLine("Ingrerse la altura del triangulo");
        int alturaTriangulo;
        bool alturaCorrecta = int.TryParse((Console.ReadLine()), out alturaTriangulo);
        string triangulo = "*";
       

        for (int i = 1; i <= alturaTriangulo; i++)
        {
            if (i == 1)
            {
                Console.WriteLine($"{triangulo.PadLeft(alturaTriangulo)}");
                //triangulo += "**";

            }
            else
            {
                
                triangulo += "**";
                Console.WriteLine($"{triangulo.PadLeft(alturaTriangulo - 1)}");


            }
        }
    }
}