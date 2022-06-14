using System;
using TiempoEnClase2022POO.Entidades;

namespace TiempoEnClase2022POO.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El tunel del Tiempo");

            var t1 = new Tiempo(10, 17);
            var t2=new Tiempo(15,25,2);
            var t3 = new Tiempo(10, 17);
            var t4 = t1 + t2;

            Tiempo t5="10:25:43";
            Console.WriteLine(t5.ToString());

            int segundos = (int) t5;
            Console.WriteLine($"{t5.ToString()} equivale a {segundos} segundos");
            

            Console.WriteLine(t4.ToString());
            if (t1==t3)
            {
                Console.WriteLine("Ambas horas son iguales");
            }
            else
            {
                Console.WriteLine("Las horas son distintas");
            }
            if (t2.Validar())
            {
                Console.WriteLine(t2.ToString());
            }
            else
            {
                Console.WriteLine("Hora mal ingresada");
            }
            Console.WriteLine(t1.ToString());
        }
    }
}
