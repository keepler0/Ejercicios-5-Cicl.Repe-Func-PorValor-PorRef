using System;

namespace Ejercicio47
{
    class Program
    {
        static void Main(string[] args)
        {
            //titulacion del programa de consola
            Console.Title = "Ejercicio47TablaDeMultiplicarDeUnNum";
            //mensaje para el usuario
            Console.WriteLine("Se mostrará la tabla de multiplicar segun el número introducido");
            //definicion de las variables
            int contador, multiplicador, multiplicando, producto;
            Console.Write("Que numero desea mostrar su tabla de multiplicar?: ");
            multiplicando = int.Parse(Console.ReadLine());
            Console.WriteLine($"TABLA DEL {multiplicando}");
            contador = 0;
            multiplicador = 0;
            //ciclo repetitivo
            do
            {
                contador = contador + 1;
                multiplicador = multiplicador + 1;
                producto = obtenerMultiplicacion(multiplicador, multiplicando);
                Console.WriteLine($"{multiplicando} x {multiplicador} = {producto}");

            } while (multiplicador != 10);
        }

        private static int obtenerMultiplicacion(int multiplicador, int multiplicando) => multiplicador * multiplicando;
    }
}
