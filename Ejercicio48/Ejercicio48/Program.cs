using System;

namespace Ejercicio48
{
    class Program
    {
        static void Main(string[] args)
        {
            //Titulacion del programa
            Console.Title = "Ejercicio48ingresoYSumaDeNumEInformacionDeEllas";
            //Mensaje del programa
            Console.WriteLine("Se sumara los numeros ingresados e informara cuantos se ingresaron");
            //definicion de las variables
            int num, contador, sumador;
            contador = 0;
            sumador = 0;
            //ciclo repetitivo repetir hasta que... do while
            do
            {
                Console.Write("Ingrese Número: ");
                num = int.Parse(Console.ReadLine());
                contador = contador + 1;
                sumador = sumador + num;
            } while (sumador <= 60);
            Console.WriteLine($"Se ingresaron {contador} números y la suma total es: {sumador}");
        }
    }
}
