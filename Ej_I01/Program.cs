using Entidades;
internal class Program
{
    private static void Main(string[] args)
    {
        /*Ejercicio I01 - Creo que necesito un préstamo

        Consigna
        Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.
        
        En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir
        mostrando como va variando el saldo.*/

        Cuenta cuenta1 = new Cuenta("Jose Rosales", 2456888888);
        Console.WriteLine(cuenta1.Mostrar());
        Console.WriteLine("Se van a ingresar $27300");
        cuenta1.Ingresar(27300);
        Console.WriteLine(cuenta1.Mostrar());
        Console.WriteLine("Se debita 1000000000");
        cuenta1.Retirar(1000000000);
        Console.WriteLine(cuenta1.Mostrar());

    }
}