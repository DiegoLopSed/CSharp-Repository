using System;

namespace MiPrimerProyecto
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//Manejo de variables numericas
			
			int num1, num2;
			double resultado; //? Devido a que la división puede tener decimales usamos double
			
			Console.WriteLine("Ingresa el numero 1");
			num1=Convert.ToInt32(Console.ReadLine()); //! ReadLine() Solo permite Caracteres

            //?Para poder trabajar con números debe usarse el metodo ToInt32()
			
			Console.WriteLine("Ingresa el numero 2");
			num2=Convert.ToInt32(Console.ReadLine());
			
			resultado = num1 + num2;
			Console.WriteLine("Suma de los numeros = " + resultado);
				
			resultado = num1 - num2;
			Console.WriteLine("Resta de los numeros = " + resultado);

			resultado = num1 * num2;
			Console.WriteLine("Multiplicación de los numeros = " + resultado);	

			resultado = num1 / num2;
			Console.WriteLine("División de los numeros = " + resultado);				
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}