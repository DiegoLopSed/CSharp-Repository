using System;

namespace MiPrimerProyecto
{
	class Program
	{
		public static void Main(string[] args)
		{
		 //! Solicitar al usuario que ingrese una calificación
        Console.Write("Ingresa tu calificación: ");
        int calificacion = Convert.ToInt32(Console.ReadLine());

        //? Estructura condicional para evaluar la calificación
        if (calificacion >= 90)
        {
            //* Si la calificación es igual o mayor a 90, se imprime "¡Excelente!"
            Console.WriteLine("¡Excelente!");
        }
        else if (calificacion >= 70)
        {
            //* Si la calificación está entre 70 y 89, se imprime "Buen trabajo"
            Console.WriteLine("Buen trabajo");
        }
        else if (calificacion >= 50)
        {
            //* Si la calificación está entre 50 y 69, se imprime "Aprobado"
            Console.WriteLine("Aprobado");
        }
        else
        {
            //* Si la calificación es menor a 50, se imprime "Reprobado"
            Console.WriteLine("Reprobado");
        }
        //? Esperar a que el usuario presione una tecla antes de cerrar la aplicación
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
        
		}
	}
}