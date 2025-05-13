using System;

class Program
{
    static void Main()
    {
        // Variables
        string nombre;
        double montoPrestamo, interesPorcentaje, cuotaBase, cuotaConInteres, totalFinal = 0, totalIntereses = 0;
        int meses;

        // Entrada de datos
        Console.WriteLine("=== Banco 'Ate de LR' ===");
        Console.Write("Ingrese el nombre del cliente: ");
        nombre = Console.ReadLine();

        Console.Write("Ingrese el monto del préstamo ($): ");
        montoPrestamo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el interés mensual (%): ");
        interesPorcentaje = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la cantidad de meses a pagar: ");
        meses = Convert.ToInt32(Console.ReadLine());

        // Cálculo de cuota base
        cuotaBase = montoPrestamo / meses;

        // Mostrar resultados
        Console.Clear();
        Console.WriteLine("=== Detalle del Préstamo ===");
        Console.WriteLine("Cliente: " + nombre);
        Console.WriteLine("Monto inicial del préstamo: $" + montoPrestamo.ToString("F2"));
        Console.WriteLine("Interés mensual: " + interesPorcentaje + "%");
        Console.WriteLine("Meses a pagar: " + meses);
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Mes\tCuota Base\tInterés\t\tCuota Total");

        // Proceso
        for (int mes = 1; mes <= meses; mes++)
        {
            double interesDelMes = cuotaBase * (interesPorcentaje / 100);
            cuotaConInteres = cuotaBase + interesDelMes;

            totalFinal += cuotaConInteres;
            totalIntereses += interesDelMes;

            Console.WriteLine(mes + "\t$" + cuotaBase.ToString("F2") + "\t\t$" + interesDelMes.ToString("F2") + "\t\t$" + cuotaConInteres.ToString("F2"));
        }

        // Mostrar totales
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Total de intereses pagados: $" + totalIntereses.ToString("F2"));
        Console.WriteLine("Monto final a pagar: $" + totalFinal.ToString("F2"));
        Console.WriteLine("\nPresione una tecla para salir...");
        Console.ReadKey();
    }
}
