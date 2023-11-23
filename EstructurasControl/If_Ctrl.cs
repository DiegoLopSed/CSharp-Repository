using System;

{
    class Program
    {
        public static void Main(string[] args)
        {

            //! Estructura de control If

            int Edad; //? Declaramos una variable para almacenar la edad
            string Nombre; //? Declaramos una variable para almacenar el nombre

            Console.Write("Ingresa tu nombre: ");
            Nombre = Console.ReadLine();//* Leemos el nombre ingresado por el usuario
            Console.Write("Ingresa tu edad: ");
            Edad = Convert.ToInt32(Console.ReadLine());//* Leemos la edad ingresada por el usuario


            if (Edad >= 18)
            { //! La estructura if evalua que se cumpla la condición

                //* Acciones por verdadero
                Console.WriteLine(Nombre + " Eres mayor de edad");

            }
            else
            {

                //! Acciones por falso
                Console.WriteLine(Nombre + " Aún no eres mayor de edad");

            }


            //? Esperar a que el usuario presione una tecla antes de cerrar la aplicación
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}