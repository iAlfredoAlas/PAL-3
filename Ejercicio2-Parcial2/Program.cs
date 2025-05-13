using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("******** Programa especial :D - PAL ********");
            Console.WriteLine("1. Vector de Caracteres.");
            Console.WriteLine("2. Cadena de Caracteres 01.");
            Console.WriteLine("3. Cadenas de Caracteres 02.");
            Console.WriteLine("4. Mostrar números del 500 al 1000.");
            Console.WriteLine("5. Matriz de datos.");
            Console.WriteLine("6. Fecha del sistema.");
            Console.WriteLine("7. Salir");
            Console.WriteLine("********************************************");
            Console.Write("Digite una opción: ");

            try
            {
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        VectorDeCaracteres();
                        break;
                    case 2:
                        CadenaCaracteres01();
                        break;
                    case 3:
                        CadenaCaracteres02();
                        break;
                    case 4:
                        MostrarNumeros500a1000();
                        break;
                    case 5:
                        MatrizDeDatos();
                        break;
                    case 6:
                        MostrarFechaSistema();
                        break;
                    case 7:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingrese un número válido.");
                opcion = 0;
            }

            if (opcion != 7)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 7);
    }

    static void VectorDeCaracteres()
    {
        char[] vector = new char[10];
        int vocales = 0, letras = 0;

        Console.WriteLine("\n--- Vector de Caracteres ---");
        try
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("Ingrese caracter para posición " + (i + 1) + ": ");
                vector[i] = Convert.ToChar(Console.ReadLine());

                if (char.IsLetter(vector[i]))
                {
                    letras++;
                    char c = char.ToLower(vector[i]);
                    if ("aeiou".Contains(c))
                        vocales++;
                }
            }

            Console.WriteLine("Total de letras: " + letras);
            Console.WriteLine("Total de vocales: " + vocales);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al ingresar caracteres: " + ex.Message);
        }
    }

    static void CadenaCaracteres01()
    {
        Console.WriteLine("\n--- Cadena de Caracteres 01 ---");

        try
        {
            Console.Write("Ingrese una cadena: ");
            string cadena = Console.ReadLine();

            Console.WriteLine("En mayúsculas: " + cadena.ToUpper());
            Console.WriteLine("En minúsculas: " + cadena.ToLower());
            Console.WriteLine("Cantidad de caracteres: " + cadena.Length);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al procesar la cadena: " + ex.Message);
        }
    }

    static void CadenaCaracteres02()
    {
        Console.WriteLine("\n--- Cadenas de Caracteres 02 ---");

        try
        {
            Console.Write("Ingrese la primera cadena: ");
            string cadena1 = Console.ReadLine();

            Console.Write("Ingrese la segunda cadena: ");
            string cadena2 = Console.ReadLine();

            int comparacion = string.Compare(cadena1, cadena2);

            if (comparacion == 0)
                Console.WriteLine("Ambas cadenas son iguales.");
            else if (comparacion < 0)
                Console.WriteLine("La primera cadena es menor alfabéticamente.");
            else
                Console.WriteLine("La primera cadena es mayor alfabéticamente.");

            Console.WriteLine("Cadenas concatenadas: " + cadena1 + cadena2);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al comparar cadenas: " + ex.Message);
        }
    }

    static void MostrarNumeros500a1000()
    {
        Console.WriteLine("\n--- Números del 500 al 1000 ---");

        int num = 500;
        while (num <= 1000)
        {
            Console.Write(num + " ");
            num++;
        }
    }

    static void MatrizDeDatos()
    {
        string[,] jugadores = new string[3, 3];

        Console.WriteLine("\n--- Matriz de Datos de Jugadores ---");

        try
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nJugador {i + 1}:");
                Console.Write("Nombre: ");
                jugadores[i, 0] = Console.ReadLine();

                Console.Write("Equipo: ");
                jugadores[i, 1] = Console.ReadLine();

                Console.Write("País: ");
                jugadores[i, 2] = Console.ReadLine();
            }

            Console.WriteLine("\n--- Datos ingresados ---");
            Console.WriteLine("Nombre\t\tEquipo\t\tPaís");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{jugadores[i, 0]}\t\t{jugadores[i, 1]}\t\t{jugadores[i, 2]}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al ingresar datos: " + ex.Message);
        }
    }

    static void MostrarFechaSistema()
    {
        Console.WriteLine("\n--- Fecha del sistema ---");
        Console.WriteLine("Fecha y hora actual: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
    }
}
