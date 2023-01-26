using System;

namespace Ejercicio59
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 59 ingresar medidas de 7 personas";
            Console.WriteLine("Debe ingresar las medidas de 7 personas expresadas en centimetros.");
           
            //definicion de las variables
            //para hacer el codigo mas "Limpio" determine los valores de las variables

            int centimetros=0,
                alto = 19,
                bajo=231,
                sumador=0,
                contador=0;
           
            double promedio=0,
                   pies=0;
            Console.WriteLine("Ingrese la medida de la persona:");
            //ciclo for
            Console.WriteLine("*********************Tabla Centimetros-Pies********************************");
            for (contador=1; contador <= 7; contador++)
            {
                string datoIngresado=Console.ReadLine();
                validarDatos(datoIngresado,centimetros);
                do
                {
                    if (centimetros>= 231 && centimetros <= 19)
                    {
                        Console.WriteLine("Debe introducir un valor racional");
                    }
                }
                while (centimetros <= 230 && centimetros >= 20);
                sumador += centimetros;
                cenversorPies(pies,centimetros);
                promedioAlt(promedio, sumador);
                Console.WriteLine($"{centimetros} Equivalente en pies ===>{pies}");
                if (centimetros > alto)
                {
                    alto = centimetros;
                }
                else if (centimetros<bajo)
                {
                    bajo = centimetros;
                }
            }
            Console.WriteLine("***********************INFORMACION FINAL****************************");
            Console.WriteLine($"La persona más alta tiene: {alto} cms y la mas baja tiene: {bajo} cms");
            Console.WriteLine($"El promedio de altura fue: {promedio}");
        }


        //***********************funcion para calcular el promedio*****************
        private static void promedioAlt(double promedio, int sumador)=> promedio = sumador / 7;


        //***********************funcion para convertir centimetros a pies****************
        private static void cenversorPies(double pies,int centimetros)=> pies=centimetros * 0.0328084;


        //funcion para validar los datos ingresados ya que este solo tiene que ser números
        private static bool validarDatos(string datoIngresado,int centimetros)
        {
            bool valido;
            if (int.TryParse(datoIngresado,out centimetros))
            {
                valido = true;
            }
            else
            {
                valido = false;
                Console.WriteLine("El dato ingresado es invalido.");
            }
            return valido;
        }
    }
}
