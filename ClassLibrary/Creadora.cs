using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Entidades
{
    public class Creadora
    {
        /*Crear la clase Creadora con los siguientes miembros:
        De clase:
        (-) fechaCreacionPrimerObjeto : DateTime;
        (-) contadorObjetosCreados : int;

        (+) ObtenerCantidadObjetosCreados() : int;
        * retorna el valor del atributo contadorObjetosCreados.

        Cosntructor (clase)
        * inicializa con la fecha actual (DateTime.Now) y con cero a sus atributos estáticos, según corresponda.

        De instancia:
        (-) fechaCreacion : DateTime;

        (+) ObtenerDiferencia() : string
        * retorna la diferencia (en milisegundos) entre la fechaCreacionPrimerObjeto y la fechaCreacion de la instancia actual.

        Constructor (instancia)
        * inicializa su atributo NO estático con la fecha actual (DateTime.Now).
        * incrementa en uno el atributo estático contadorObjetosCreados.*/

        private static DateTime fechaCreacionPrimerObjeto;
        private static int contadorObjetosCreados;
        private DateTime fechaCreacion;

        static Creadora() {
            Creadora.contadorObjetosCreados = 0;
            Creadora.fechaCreacionPrimerObjeto = DateTime.Now;
        }
        public Creadora()
        {
            this.fechaCreacion = DateTime.Now;
            Creadora.contadorObjetosCreados ++;
        }

        public static int ObtenerCantidadOjetosCreados()
        {
            return Creadora.contadorObjetosCreados;
        }

        public string ObtenerDiferencia()
        {
            TimeSpan diferencia = this.fechaCreacion - Creadora.fechaCreacionPrimerObjeto;
            return diferencia.ToString();
        }
    }

    
}