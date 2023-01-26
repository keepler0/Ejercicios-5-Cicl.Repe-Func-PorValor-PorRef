using System;

namespace Ejercicios56
{
    class Program
    {
        static void Main(string[] args)
        {
            //definicion de las variables
            int num, contador, contDivisible;
            Console.Title = "Ejercicio 56 Informar la cantidad de divisores";
            Console.WriteLine("Se informara la cantidad de divisores del numero ingresado.");
            Console.Write("Ingrese el número: ");
            num = int.Parse(Console.ReadLine());
            contDivisible = 1;
            contador = 0;
            do
            {
                if (num % contDivisible == 0)
                {
                    contador++;
                }
                contDivisible++;
            } while (contDivisible <= num);
            Console.WriteLine($"La cantidad de divisores es: {contador}");
        }
    }
}
