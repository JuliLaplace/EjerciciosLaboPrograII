using Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        /*En el Main: 
         * crear 4 objetos y mostrar la diferencia de tiempos y cantidad de instancias creadas (ejecutado con F5)
         *  realizar la misma tarea pero con una ejecución paso a paso (F11)
         *  analizar resultados.*/
        Creadora primerObjeto = new Creadora();
        Console.WriteLine(Creadora.ObtenerCantidadOjetosCreados());
        Creadora segundoObjeto = new Creadora();
        Creadora tercerObjeto = new Creadora();
        Creadora cuatroObjeto = new Creadora();

        Console.WriteLine("Primer objeto");
        Console.WriteLine(primerObjeto.ObtenerDiferencia());
        Console.WriteLine("SegundoObjeto");
        Console.WriteLine(segundoObjeto.ObtenerDiferencia());
        Console.WriteLine(Creadora.ObtenerCantidadOjetosCreados());
        
    }
}