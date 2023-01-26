using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //titulacion del programa
            Console.Title = "Ejercicio46IngresarDiezNumEInformarSuma";
            //mensaje de consola
            Console.WriteLine("Se ingresará Diez números y se sumará e informará los mismos");
            //definicion de las variables
            int num,contador, sumador;
            contador = 0;
            sumador = 0;
            //ciclo repetitivo FOR
            for(contador=1; contador <= 10; contador++)
            {
                Console.Write("inserte un número: ");
                num = int.Parse(Console.ReadLine());
                sumador = sumador + num;
            }
            //mensaje final
            Console.WriteLine($"La suma de los números es {sumador}");
        }
    }
}
