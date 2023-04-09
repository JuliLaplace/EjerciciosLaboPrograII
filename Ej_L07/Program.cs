internal class Program
{
    private static void Main(string[] args)
    {
        /*Ejercicio I07 - Pitágoras estaría orgulloso
        Consigna
        Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en centímetros.
        El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y Usar los métodos 
        Pow y Sqrt de la clase Math para realizar los cálculos.
        Mostrar el resultado en la consola.*/
        double basee;
        double altura;
        
        Console.WriteLine("Ingrese la base de un triangulo");
        basee = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la altura de un triangulo");
        altura = double.Parse(Console.ReadLine());
        
        double hipotenusa = CalcularHipotenusa(basee, altura);
        Console.WriteLine($"La hipotenusa de un triangulo con base {basee}cm y altura {altura}cm es de {hipotenusa}cm");


        static double CalcularHipotenusa (double basee, double altura)
        {
            //c = √(b² + h²)
            double resultado = Math.Sqrt((Math.Pow(basee, 2)) + (Math.Pow(altura, 2)));
            return resultado;
        }
    }
}