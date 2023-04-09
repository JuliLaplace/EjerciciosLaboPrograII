using Ej_L06;

internal class Program
{
    private static void Main(string[] args)
    {
        //Ejercicio I06 - Calculadora de áreas
        //Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase
        //(estáticos) que realicen el cálculo del área que corresponda:
        //public double CalcularAreaCuadrado(double longitudLado) { }
        //public double CalcularAreaTriangulo(double base, double altura) { }
        //public double CalcularAreaCirculo(double radio) { }
        //El ingreso de los datos como la visualización se deberán realizar desde el método
        //Main().
        //
        Console.WriteLine("Ingrese la opcion que desee calcular:");
        Console.WriteLine("1) Area de un cuadrado.");
        Console.WriteLine("2) Area de un triangulo.");
        Console.WriteLine("3) Area de un circulo");
        int opcion;
        bool esNumero = int.TryParse(Console.ReadLine(), out opcion);
        while ((!esNumero) || opcion <1 || opcion >3)
        {
            Console.WriteLine("Opcion ingresada invalida. Ingrese la opcion que desee calcular:");
            Console.WriteLine("1) Area de un cuadrado.");
            Console.WriteLine("2) Area de un triangulo.");
            Console.WriteLine("3) Area de un circulo");
            esNumero = int.TryParse(Console.ReadLine(), out opcion);
        }

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Ingrese la longitud del lado del cuadrado a saber su area:");
                double lado = double.Parse(Console.ReadLine());
                Console.WriteLine($"El area del cuadrado de lado {lado} es {CalculadoraDeArea.CalcularAreaCuadrado(lado)}");
                break;
            case 2:
                Console.WriteLine("Ingrese la base del triangulo a saber su area:");
                double basee = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la altura del triangulo a saber su area:");
                double altura = double.Parse(Console.ReadLine());
                Console.WriteLine($"El area del triangulo de base {basee} y altura {altura} es {CalculadoraDeArea.CalcularAreaTriangulo(basee, altura)}");
                break;
            case 3:
                Console.WriteLine("Ingrese el radio del circulo a saber su area:");
                double radio = double.Parse(Console.ReadLine());
                Console.WriteLine($"El area del circulo de radio {radio} es {CalculadoraDeArea.CalcularAreaCirculo(radio)}");
                break;
            //podria poner un defaul que aca me evalue el numero de opcion elegida en lugar de hacerlo en el while
            //default:
            //    Console.WriteLine("El numero elegido no es una opcion correcta");
            //    break;
        }
    }
}