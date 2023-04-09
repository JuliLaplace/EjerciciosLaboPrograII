internal class Program
{
    private static void Main(string[] args)
    {

        //[A.08] Recibos de sueldo
        //Por teclado se ingresa el valor hora, el nombre, la antigüedad(en años) y la cantidad de horas trabajadas
        //en el mes de N empleados de una fábrica. Se pide calcular el importe a cobrar teniendo en cuenta que el
        //total(que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), hay que sumarle la
        //cantidad de años trabajados multiplicados por $15000, y al total de todas esas operaciones restarle el
        //13 % en concepto de descuentos. Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor
        //hora, el total a cobrar en bruto, el total de descuentos y el valor neto a cobrar de todos los
        //empleados ingresados.
        //Nota: Utilizar estructuras repetitivas y selectivas.

        int valorHoraIngresada;
        string nombreIngresado;
        int antiguedadIngresada;
        int horasTrabajadasIngresadas;
        string opcion = "no";

        do
        {
            double totalBruto;
            double totalNeto;
            Console.WriteLine("Ingrese su nombre:");
            nombreIngresado = Console.ReadLine();

            Console.WriteLine("Ingrese el valor por hora:");
            valorHoraIngresada = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su antiguedad:");
            antiguedadIngresada = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese elas horas trabajadas en el mes:");
            horasTrabajadasIngresadas = int.Parse(Console.ReadLine());

            totalBruto = (valorHoraIngresada * horasTrabajadasIngresadas) + (antiguedadIngresada*15000);
            totalNeto = totalBruto * 0.87;
            double descuento = totalBruto - totalNeto;


            Console.WriteLine($"{nombreIngresado}, con antiguedad de {antiguedadIngresada} años, con " +
                $"{horasTrabajadasIngresadas} horas trabajadas. Cobra {totalBruto} pesos en bruto, y se le aplica " +
                $"un descuento de {descuento} pesos, dejando un sueldo neto de {totalNeto} pesos. ");

            Console.WriteLine("Desea seguir cargando datos de empleados? si/no");
            opcion = Console.ReadLine();
        } while (opcion == "si");


        Console.WriteLine("Adios");
    }
}