using System;

namespace MiPrimerProyecto
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//Declaración de variables
			
			string Nombre = "Diego"; //? Cadena de caracteres
			int Edad = 20; //? Entero
			double Estatura= 1.85; //? Decimal
			string Apellido; //? Cadena sin valor
			
			Console.WriteLine("Ingresa tu apellido");
			Apellido=Console.ReadLine(); //? Leer cadenas de texto
			
			Console.WriteLine("Nombre: " + Nombre + " " + Apellido); //! Concatenar variables 
			Console.WriteLine("Edad: " + Edad);  //! Concatenar variables 
			Console.WriteLine("Estatura: " + Estatura); //! Concatenar variables 
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}