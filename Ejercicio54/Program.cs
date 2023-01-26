using System;

namespace Ejercicio54
{
    class Program
    {
        static void Main(string[] args)
        {//titulo mensaje del ususario
            Console.Title = "Ejercicio54informarCantDigDeUnNum";
            Console.WriteLine("Se informará la cantidad de dígitos que tiene un número");
            //definicion de las variables
            int contador;
            double num;

            num = int.Parse(Console.ReadLine());
            //valor del contador para el ciclo repetitivo
            contador = 0;
           
            do
            {
                num = Math.Truncate(num / 10);
                contador = contador + 1;
            } while (num >= 1);
            //mensaje final
            Console.WriteLine($"El número introducido tiene {contador} dígitos.");
        }
        
    }
}
