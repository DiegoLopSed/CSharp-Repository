using System;

namespace MiPrimerProyecto
{
    class Program
    {
        public static void Main(string[] args)
        {
            //! Variables
            int Base, Multiplo;

            Console.Write("Ingresa el número a multiplicar: ");
            Base = Convert.ToInt32(Console.ReadLine()); //? Leer Base 

            Console.WriteLine();

            for (int i = 1; i <= 10; i++) //* Repetir el ciclo hasta 10
            {
                Multiplo = Base * i; //! Obtener el valor de la multiplicación
                Console.WriteLine(Base + " X " + i + " = " + Multiplo);
            }


            // Esperar a que el usuario presione una tecla antes de cerrar la aplicación

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);

        }
    }
}