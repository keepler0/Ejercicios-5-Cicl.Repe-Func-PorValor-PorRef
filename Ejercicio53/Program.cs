using System;

namespace Ejercicio53
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio53GenerarTabAzarTemp";
            Console.WriteLine("Se generará una tabla de temperaturas al azar.");
            Console.WriteLine("Toque ENTER para iniciar");
            Console.ReadKey();
            //definicion de las variables
            int celsius;
            int contador = 0;
            int sumador = 0;
            double tempMedia;
            do
            {
                //se crea una clase Random variable "r"
                Random r= new Random();
                celsius = r.Next(0,30);
                
                //se invoco una funcion para determinar los numeros maores a 20
                if (mayorAVeinte(celsius))
                {
                    Console.Write($"{celsius}*");
                    Console.Write("|  ");
                }
                else
                {
                    Console.Write(celsius);
                    Console.Write("|  ");
                }
                sumador = sumador + celsius;
                contador = contador + 1;
            } while (contador != 10);
            tempMedia = sumador / contador;
            Console.WriteLine("");
            Console.WriteLine($"La temperatura media es: {tempMedia}");
        }

        private static bool mayorAVeinte(int celsius)
        {
            bool validar = (celsius > 20) ? true : false;
            return validar;
        }
    }
}
