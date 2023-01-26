using System;

namespace Ejercicio51
{
    class Program
    {
        static void Main(string[] args)
        {
            //definicion de las variables
            int num, sumador, contador, contNumMayor, contNumMenor;
            //titulacion del programa
            Console.Title = "Ejercicio51InformarNumMayorAYMenorA";
            //encabezado del programa
            Console.WriteLine("Se generará 15 numeros al azar y se informara cantidad de numeros.");
            Console.WriteLine("precione cualquier tecla para continuar");
            Console.ReadKey();
            //definicion de los valores para el ciclo repetitivo
            sumador = 0;
            contador = 0;
            contNumMayor = 0;
            contNumMenor = 0;
            for (contador = 1; contador <=15; contador++)
            {
                //se generó una clase random con variable local "r" para generar los numeros azar
                Random r= new Random();
                num=r.Next(20);
                Console.WriteLine($"Número generado:{num}");
                //Bicondicional para determinar num entre 10 y 15
                if (num>=10 && num <= 15)
                {
                    contNumMayor = contNumMayor + 1;
                }
                else
                {
                    //condicional para contar cuantos menores a 7
                    if (num < 7)
                    {
                        contNumMenor = contNumMenor + 1;
                    }
                }
                //suma de los numeros generados
                sumador = sumador + num;
            }
            //muestra de los resultados finales
            //y dinal del programa
            Console.WriteLine($"Los números al azar sumaron: {sumador} en total");
            Console.WriteLine($"Se generaron {contNumMayor} números entre 10 y 15");
            Console.WriteLine($"Se generaron {contNumMenor} números menores a 7");
        }
    }
}
