using System;

namespace Ejercicio57
{
    class Program
    {
        static void Main(string[] args)
        {
            //titulacion del programa
            Console.Title = "Ejercicio 57 Multiplos de 3 entre 1 y 20";
            //definicion de las variables
            int num=0, contador=0, cantidad=0;
            //mensaje principal
            Console.WriteLine("Se mostraran los multiplos de 3 comprendidos del numero 1 al 20");
            //se coloca un read key ya que se escapa solo con el resultado
            Console.WriteLine("Toque ENTER para continuar");
            Console.ReadKey();
            do
            {
                if (num % 3 == 0)
                {
                    cantidad++;
                    Console.Write($" {num}");
                }
                contador++;
                num++;
            } while (contador != 20);
            //muestra de los resultados y fin del programa
            Console.WriteLine(" ");
            Console.WriteLine($"La cantidad de multiplos: {cantidad}");

        }
    }
}
