using System;

namespace Ejercicio52
{
    class Program
    {
        static void Main(string[] args)
        {
            //titulacion del programa
            Console.Title = "Ejercicio52GenerarTablaCaF";
            //definicion de las variables
            int inicio, final;
            double fahrenheit;
            //mensaje al usuario
            Console.WriteLine("Se generará una tabla de conversion de Celsius a Fahrenheit");
            //Definicion de los parametros de inicio y final
            Console.WriteLine("Inserte el punto de inicio y final");
            Console.Write("Inicio: ");
            inicio = int.Parse(Console.ReadLine());
            //C.repetitivo para verificar que el inicio<final
            do
            {
                Console.Write("Final: ");
                final = int.Parse(Console.ReadLine());
                if (final > inicio)
                {
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("El parametro Final debe ser mayor al Inicio.");
                }
            } while (final <= inicio);
            Console.WriteLine("-----------------------Equivalentes Celsius a Fahrenheit-----------------");
            //C.repetitivo para generar la tabla de conversiones
            do
            {
                fahrenheit = 1.8 * inicio + 32;
                Console.WriteLine($"C°: {inicio} ==> F°: {fahrenheit}");
                inicio = inicio + 1;
            } while (inicio<=final);

        }
    }
}
