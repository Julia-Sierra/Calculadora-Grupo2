using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Bienvenido a la Calculadora");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.Write("Seleccione una opción: ");

            string? entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out int opcion))
            {
                Console.WriteLine("Opción inválida.");
                Console.WriteLine();
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Has seleccionado Suma.");
                    break;
                case 2:
                    Console.WriteLine("Has seleccionado Resta.");
                    break;
                case 3:
                    Console.WriteLine("Has seleccionado Multiplicación.");
                    break;
                case 4:
                    Console.WriteLine("Has seleccionado División.");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            Console.WriteLine();
            Console.Write("¿Desea salir? (s/n): ");
            string? respuesta = Console.ReadLine();

            if (respuesta != null && respuesta.Trim().ToLower() == "s")
            {
                break;
            }
        }
    }
}