using System;
using System.IO;
using System.Diagnostics;

struct Vehiculo
{
    public string marca;
    public string tipo; // Sedán, Camión o Camioneta
    public string combustible;
}

struct Cliente
{
    public string nombre;
    public string correo;
    public Vehiculo vehiculo;
    public double totalVenta;
}

class Program
{
    static StreamWriter Escribir;
    static string archivo = "ventas_gasolinera.txt";
    static int totalClientes = 0;

    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("****** Gasolinera Don Bosco ******");
            Console.WriteLine("1. Venta.");
            Console.WriteLine("2. Mostrar datos ventas.");
            Console.WriteLine("3. Estadísticas de ventas.");
            Console.WriteLine("4. Salir");
            Console.WriteLine("***********************************");
            Console.Write("Seleccione una opción: ");

            try
            {
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        RegistrarVenta();
                        break;
                    case 2:
                        MostrarVentas();
                        break;
                    case 3:
                        MostrarEstadisticas();
                        break;
                    case 4:
                        Console.WriteLine("Gracias por usar el sistema.");
                        if (File.Exists(archivo))
                        {
                            try
                            {
                                Console.WriteLine("Abriendo archivo de ventas...");
                                Process.Start("notepad.exe", archivo); // Asegura que se abra con Bloc de notas
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("No se pudo abrir el archivo: " + ex.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay archivo de ventas que abrir.");
                        }
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingrese un número válido.");
                opcion = 0;
            }

            if (opcion != 4)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 4);
    }

    static void RegistrarVenta()
    {
        Cliente cliente = new Cliente();
        double precio = 0;

        Console.Write("Nombre del cliente: ");
        cliente.nombre = Console.ReadLine();

        Console.Write("Correo del cliente: ");
        cliente.correo = Console.ReadLine();

        Console.Write("Marca del vehículo: ");
        cliente.vehiculo.marca = Console.ReadLine();

        // === Tipo de Vehículo ===
        bool tipoValido = false;
        while (!tipoValido)
        {
            Console.WriteLine("Seleccione el tipo de vehículo:");
            Console.WriteLine("1. Sedán");
            Console.WriteLine("2. Camión");
            Console.WriteLine("3. Camioneta");
            Console.WriteLine("0. Cancelar");
            Console.Write("Opción: ");
            string opcionTipo = Console.ReadLine();

            switch (opcionTipo)
            {
                case "1": cliente.vehiculo.tipo = "Sedán"; tipoValido = true; break;
                case "2": cliente.vehiculo.tipo = "Camión"; tipoValido = true; break;
                case "3": cliente.vehiculo.tipo = "Camioneta"; tipoValido = true; break;
                case "0": return;
                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.\n");
                    break;
            }
        }

        // === Tipo de Combustible ===
        bool combustibleValido = false;
        while (!combustibleValido)
        {
            Console.WriteLine("Seleccione tipo de combustible:");
            Console.WriteLine("1. Regular ($3.51)");
            Console.WriteLine("2. Especial ($3.77)");
            Console.WriteLine("3. Diésel ($3.25)");
            Console.WriteLine("0. Cancelar");
            Console.Write("Opción: ");
            string opcionComb = Console.ReadLine();

            switch (opcionComb)
            {
                case "1": cliente.vehiculo.combustible = "Regular"; precio = 3.51; combustibleValido = true; break;
                case "2": cliente.vehiculo.combustible = "Especial"; precio = 3.77; combustibleValido = true; break;
                case "3": cliente.vehiculo.combustible = "Diésel"; precio = 3.25; combustibleValido = true; break;
                case "0": return;
                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.\n");
                    break;
            }
        }

        Console.Write("Cantidad de galones: ");
        double galones = Convert.ToDouble(Console.ReadLine());

        cliente.totalVenta = galones * precio;

        Console.WriteLine("Total a pagar: $" + cliente.totalVenta.ToString("F2"));

        try
        {
            Escribir = new StreamWriter(archivo, true);
            Escribir.WriteLine($"{cliente.nombre}|{cliente.correo}|{cliente.vehiculo.marca}|{cliente.vehiculo.tipo}|{cliente.vehiculo.combustible}|{galones}|{cliente.totalVenta}");
            Escribir.Close();
            Console.WriteLine("Venta registrada correctamente.");
            totalClientes++;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al guardar la venta: " + ex.Message);
        }
    }

    static void MostrarVentas()
    {
        try
        {
            if (!File.Exists(archivo))
            {
                Console.WriteLine("No hay ventas registradas aún.");
                return;
            }

            string[] lineas = File.ReadAllLines(archivo);

            Console.WriteLine("\n--- Ventas registradas ---");

            foreach (string linea in lineas)
            {
                var datos = linea.Split('|');
                Console.WriteLine($"Cliente: {datos[0]}, Correo: {datos[1]}, Vehículo: {datos[2]} ({datos[3]}), Combustible: {datos[4]}, Galones: {datos[5]}, Total: ${datos[6]}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al leer el archivo: " + ex.Message);
        }
    }

    static void MostrarEstadisticas()
    {
        try
        {
            if (!File.Exists(archivo))
            {
                Console.WriteLine("No hay estadísticas disponibles.");
                return;
            }

            int cantidadClientes = File.ReadAllLines(archivo).Length;
            Console.WriteLine($"Total de clientes atendidos: {cantidadClientes}");
            Console.WriteLine("Fecha del sistema: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al mostrar estadísticas: " + ex.Message);
        }
    }
}
