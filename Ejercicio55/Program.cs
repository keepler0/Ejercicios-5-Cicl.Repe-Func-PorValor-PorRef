using System;

namespace Ejercicio55
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 55 Informar el dígito menor del número ingresado";
            Console.WriteLine("Se informará el dígito menor del número ingresado.");
            //definicion de las variables
            double num,digMenor, Menor;
            Console.Write("Ingrese un número: ");
            num = double.Parse(Console.ReadLine());
            digMenor = num % 10;
            num = Math.Truncate(num / 10);
            do
            {
                Menor = num % 10;
                num = Math.Truncate(num / 10);
                if (Menor < digMenor)
                {
                    digMenor = Menor;
                }
            } while (num>0);
            //mensaje final del programa
            Console.WriteLine($"El dígito menor es: {digMenor}");
        }
    }
}
