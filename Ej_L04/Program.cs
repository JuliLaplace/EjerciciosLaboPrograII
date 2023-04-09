using Ej_L04;

internal class Program
{
    private static void Main(string[] args)
    {
        
        char opcion;
        char operacion;
        double numero1;
        double numero2;
        double resultado;
        bool esNumero1;
        bool esNumero2;
        bool esOperacion;
        do
        {

            Console.WriteLine("Ingrese primer numero: ");
            esNumero1 = double.TryParse(Console.ReadLine(), out numero1);
            Console.WriteLine("Ingrese segundo numero: ");
            esNumero2 = double.TryParse(Console.ReadLine(), out numero2);
            Console.WriteLine("Ingrese operacion a realizar: + - * /");
            esOperacion = char.TryParse(Console.ReadLine(), out operacion);

            while (!(esNumero1) || !(esNumero2) || !(esOperacion)) 
            { 
                Console.WriteLine("Ingrese primer numero: ");
                esNumero1 = double.TryParse(Console.ReadLine(), out numero1);
                Console.WriteLine("Ingrese segundo numero: ");
                esNumero2 = double.TryParse(Console.ReadLine(), out numero2);
                Console.WriteLine("Ingrese operacion a realizar: + - * /");
                esOperacion = char.TryParse(Console.ReadLine(), out operacion);
            }

            resultado = Calculadora.Calcular(numero1, numero2, operacion);
            Console.WriteLine($"El resultado de {numero1} {operacion} {numero2} es {resultado}");

            Console.WriteLine("Desea realizar otra operacion? s/n");
            opcion = char.Parse(Console.ReadLine());
        } while (opcion != 'n');

    }
}