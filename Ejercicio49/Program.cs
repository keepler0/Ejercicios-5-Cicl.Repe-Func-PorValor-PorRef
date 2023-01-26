using System;

namespace Ejercicio49
{
    class Program
    {
        static void Main(string[] args)
        {
            //definicion de las variables
            int num, sumador, contador, mayor;
            //titulacion del programa
            Console.WriteLine("Se sumará los numeros pares e informara el numero mayor ingresado.");
            
            //valores de las variables para el ciclo repetitivo
            contador = 0;
            mayor = -100000;
            sumador = 0;
            //ciclo repetitivo
            for (contador = 1; contador <= 10; contador++)
            {
                Console.Write("Inserte número: ");
                num = int.Parse(Console.ReadLine());
                sumador = sumador + (Par(num));
                //aqui almacenara el numero mas alto introducido
                if (num > mayor)
                {
                    mayor = num;
                }
            }
            //final del algoritmo 
            //muestra de los resultados
            Console.WriteLine($"La Suma de los números pares es: {sumador}");
            //muestra del numero mayor ingresado
            Console.WriteLine($"El número mayor introducido fue: {mayor}");
        }

        //esta funcion verificara los numeros introducidos si son pares o no
        private static int Par(int num)
        {
            int Pares=0;
            if (num%2==0)
            {
                Pares = num;
            }
            return Pares;
        }
    }
}
