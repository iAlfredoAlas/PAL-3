using System;
using System.Linq;

namespace CineDonBosco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            int[] butacas = new int[12]; // 0 = libre, 1 = ocupada
            int totalVenta = 0;
            int opcion;
            const int precioBoleto = 4;

            do
            {
                Console.WriteLine("\n\t*** Cine Don Bosco ***");
                Console.WriteLine("\t1. Vender butaca");
                Console.WriteLine("\t2. Mostrar estado de butacas");
                Console.WriteLine("\t3. Salir");
                Console.Write("\n\tSeleccione una opción: ");

                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("\n\tEstado actual de butacas (0 = libre, 1 = ocupada):\n");
                            for (int i = 0; i < butacas.Length; i++)
                            {
                                Console.Write(" " + butacas[i] + " ");
                            }

                            Console.Write("\n\n\tIngrese el número de la butaca que desea comprar (1-12): ");
                            int numButaca = Convert.ToInt32(Console.ReadLine());

                            if (numButaca < 1 || numButaca > 12)
                            {
                                Console.WriteLine("\tNúmero inválido. Debe estar entre 1 y 12.");
                            }
                            else if (butacas[numButaca - 1] == 1)
                            {
                                Console.WriteLine("\tEsa butaca ya está ocupada.");
                            }
                            else
                            {
                                butacas[numButaca - 1] = 1;
                                totalVenta += precioBoleto;
                                Console.WriteLine("\t¡Butaca " + numButaca + " vendida con éxito!");

                                if (butacas.All(b => b == 1))
                                {
                                    Console.WriteLine("\n\t>>> ¡La función va iniciar! <<<");
                                }
                            }
                            break;

                        case 2:
                            Console.WriteLine("\n\tEstado actual de butacas (0 = libre, 1 = ocupada):\n");
                            for (int i = 0; i < butacas.Length; i++)
                            {
                                Console.Write(" " + butacas[i] + " ");
                            }

                            Console.WriteLine("\n\n\tTotal vendido: $" + totalVenta);

                            if (butacas.All(b => b == 1))
                            {
                                Console.WriteLine("\n\t>>> ¡La función va iniciar! <<<");
                            }
                            break;

                        case 3:
                            Console.WriteLine("\tSaliendo del programa...");
                            break;

                        default:
                            Console.WriteLine("\tOpción no válida.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\tError: debe ingresar un número entero.");
                    opcion = 0;
                }

            } while (opcion != 3);

            Console.WriteLine("\n\tPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
