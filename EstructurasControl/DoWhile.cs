using System;
namespace MiPrimerProyecto
{
	class Program
	{
		public static void Main(string[] args)
		{

		int Base, Multiplo;
		string Respuesta;

		
		do {
			Console.Write("Ingresa el número a multiplicar: ");
			Base = Convert.ToInt32(Console.ReadLine());
				
			Console.WriteLine();
			
	        for (int i = 1; i <= 10; i++)
	        {
	        	Multiplo= Base*i;
	            Console.WriteLine(Base + " X " + i + " = " + Multiplo);
	        }
			
	        Console.WriteLine();
	        Console.Write("Desea repetir el programa? Y/N: ");
	        Respuesta = Console.ReadLine();
	        
	        
		}while(Respuesta == "Y" || Respuesta == "y");

		}
	}
}