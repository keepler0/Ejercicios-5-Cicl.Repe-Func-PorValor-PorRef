using System;

namespace Ejercicio50
{
    class Program
    {
        static void Main(string[] args)
        {
            //titulacion del programa
            Console.WriteLine("Se sumaran numeros al azar y se informara la cantidad generada");
            //definicion de las variables
            int num, contador, sumador;
            //definimos los valores para el ciclo
            sumador = 0;
            contador = 0;
            //ciclo repetitivo do while
            do
            {
                contador = contador + 1;
                Random r = new Random();
                num = r.Next(0, 100);
                sumador = sumador + num;
            } while (sumador <= 1000);
            Console.WriteLine($"Los numeros al azar sumaron: {sumador}");
            Console.WriteLine($"Se generaron {contador} numeros.");
        }
    }
}
