using System;

class Program
{
    static void Main()
    {
        //! Estructura de control Switch


        //? Mensajes para que el usuario seleccione una opción
        Console.WriteLine("Selecciona una opción:");
        Console.WriteLine("1. Saludo");
        Console.WriteLine("2. Despedida");
        Console.WriteLine("3. Otro mensaje");

        //! Leer la opción ingresada por el usuario
        int opcion = Convert.ToInt32(Console.ReadLine());

        //* Utilizar la declaración switch para realizar acciones según la opción seleccionada
        switch (opcion)
        {
            case 1:
                //* Si la opción es 1, imprimir un saludo
                Console.WriteLine("Hola, ¡bienvenido!");
                break;

            case 2:
                //* Si la opción es 2, imprimir un mensaje de despedida
                Console.WriteLine("Hasta luego, ¡que tengas un buen día!");
                break;

            case 3:
                //* Si la opción es 3, imprimir otro mensaje
                Console.WriteLine("Este es otro mensaje.");
                break;

            default:
                //* Si la opción no es 1, 2 ni 3, imprimir un mensaje de opción no válida
                Console.WriteLine("Opción no válida. Por favor, selecciona una opción válida.");
                break;
        }

        //? Esperar a que el usuario presione una tecla antes de cerrar la aplicación
        Console.Write("Press any key to continue . . . ");
        Console.ReadKey(true);
    }
}
