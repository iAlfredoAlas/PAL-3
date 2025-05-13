using System;

class Program
{
    static void Main()
    {
        string nombre;
        double horasTrabajadas = 0, sueldoBase = 0;
        double isss, afp, renta, sueldoLiquido;

        Console.WriteLine("=== Cálculo de Sueldo Banco 'Ate de LR' ===");

        // Entrada del nombre
        Console.Write("Ingrese el nombre del empleado: ");
        nombre = Console.ReadLine();

        // Validación de horas trabajadas con opción de corregir
        bool horasValidas = false;

        while (!horasValidas)
        {
            Console.Write("Ingrese el total de horas trabajadas en el mes: ");
            horasTrabajadas = Convert.ToDouble(Console.ReadLine());

            if (horasTrabajadas <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Las horas trabajadas deben ser mayores a cero.");
                Console.ResetColor();
                Console.Write("¿Desea corregir el dato? (S/N): ");
                string opcion = Console.ReadLine().ToUpper();

                if (opcion != "S")
                {
                    Console.WriteLine("Saliendo del programa...");
                    return;
                }
            }
            else
            {
                horasValidas = true;
            }
        }

        // Cálculo del sueldo base
        if (horasTrabajadas < 200)
        {
            sueldoBase = horasTrabajadas * 30;
        }
        else
        {
            sueldoBase = horasTrabajadas * 50;
        }

        // Cálculo de descuentos
        isss = sueldoBase * 0.03;
        afp = sueldoBase * 0.06;
        renta = (sueldoBase - isss - afp) * 0.10;

        // Sueldo líquido
        sueldoLiquido = sueldoBase - isss - afp - renta;

        // Mostrar resultados
        Console.Clear();
        Console.WriteLine("=== Resultados del Cálculo de Sueldo ===");
        Console.WriteLine("Empleado: " + nombre);
        Console.WriteLine("Sueldo base: $" + sueldoBase.ToString("F2"));
        Console.WriteLine("Descuento ISSS (3%): $" + isss.ToString("F2"));
        Console.WriteLine("Descuento AFP (6%): $" + afp.ToString("F2"));
        Console.WriteLine("Descuento RENTA (10%): $" + renta.ToString("F2"));
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Sueldo líquido a pagar: $" + sueldoLiquido.ToString("F2"));

        Console.WriteLine("\nPresione una tecla para salir...");
        Console.ReadKey();
    }
}
