using System;

class Program
{
    static void Main()
    {
        string opcion;
        do
        {
            Console.ResetColor();
            Console.Clear();
            Console.Title = "*******Rockola_UDB_:P*******";

            Console.WriteLine("*******Rockola_UDB_:P*******");
            Console.WriteLine("1. Cumbias.");
            Console.WriteLine("2. Folklore.");
            Console.WriteLine("3. Rock Inglés.");
            Console.WriteLine("4. Rock Español.");
            Console.WriteLine("5. Románticas.");
            Console.WriteLine("6. Instrumentales.");
            Console.WriteLine("7. Salir.");
            Console.WriteLine("****************************");
            Console.Write("Elija una opción: ");

            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("***** CUMBIAS *****");
                    Console.WriteLine("1. La Colegiala");
                    Console.WriteLine("2. Cumbia sobre el río");
                    Console.WriteLine("3. Juana la cubana");
                    Console.WriteLine("4. La Cumbia del Garrote");
                    Console.WriteLine("5. El Santo Cachón");
                    Console.WriteLine("6. Caballo viejo");
                    Console.WriteLine("7. El Baile del Perrito");
                    Console.WriteLine("8. La Cumbia Sampuesana");
                    Console.WriteLine("9. La Cumbia de los Pajaritos");
                    Console.WriteLine("10. La Pollera Colorá");
                    Console.WriteLine("\nPresione una tecla para regresar al menú...");
                    Console.ReadKey();
                    break;

                case "2":
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.WriteLine("***** FOLKLORE *****");
                    Console.WriteLine("1. El Carbonero");
                    Console.WriteLine("2. Adentro Cojutepeque");
                    Console.WriteLine("3. El Barreño");
                    Console.WriteLine("4. Casamiento Pipil");
                    Console.WriteLine("5. El Xuc");
                    Console.WriteLine("6. Fiesta de San Andrés");
                    Console.WriteLine("7. El Torito Pinto");
                    Console.WriteLine("8. La Llorona Loca");
                    Console.WriteLine("9. El Sombrerón");
                    Console.WriteLine("10. El Candil");
                    Console.WriteLine("\nPresione una tecla para regresar al menú...");
                    Console.ReadKey();
                    break;

                case "3":
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Clear();
                    Console.WriteLine("***** ROCK INGLÉS *****");
                    Console.WriteLine("1. Bohemian Rhapsody - Queen");
                    Console.WriteLine("2. Stairway to Heaven - Led Zeppelin");
                    Console.WriteLine("3. Hotel California - Eagles");
                    Console.WriteLine("4. Another Brick in the Wall - Pink Floyd");
                    Console.WriteLine("5. Smells Like Teen Spirit - Nirvana");
                    Console.WriteLine("6. Imagine - John Lennon");
                    Console.WriteLine("7. Sweet Child O' Mine - Guns N' Roses");
                    Console.WriteLine("8. Hey Jude - The Beatles");
                    Console.WriteLine("9. Wonderwall - Oasis");
                    Console.WriteLine("10. Don't Stop Me Now - Queen");
                    Console.WriteLine("\nPresione una tecla para regresar al menú...");
                    Console.ReadKey();
                    break;

                case "4":
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("***** ROCK ESPAÑOL *****");
                    Console.WriteLine("1. Persiana Americana - Soda Stereo");
                    Console.WriteLine("2. De Música Ligera - Soda Stereo");
                    Console.WriteLine("3. Lamento Boliviano - Enanitos Verdes");
                    Console.WriteLine("4. Matador - Los Fabulosos Cadillacs");
                    Console.WriteLine("5. Rayando el Sol - Maná");
                    Console.WriteLine("6. Me Vale - Maná");
                    Console.WriteLine("7. Ingrata - Café Tacuba");
                    Console.WriteLine("8. Eres - Café Tacuba");
                    Console.WriteLine("9. A las Nueve - No Te Va Gustar");
                    Console.WriteLine("10. Cuando pase el temblor - Soda Stereo");
                    Console.WriteLine("\nPresione una tecla para regresar al menú...");
                    Console.ReadKey();
                    break;

                case "5":
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    Console.WriteLine("***** ROMÁNTICAS *****");
                    Console.WriteLine("1. Burbujas de Amor - Juan Luis Guerra");
                    Console.WriteLine("2. A Puro Dolor - Son by Four");
                    Console.WriteLine("3. Te Amo - Franco de Vita");
                    Console.WriteLine("4. Mi Historia Entre Tus Dedos - Gianluca Grignani");
                    Console.WriteLine("5. Tú - Shakira");
                    Console.WriteLine("6. Por Amarte Así - Cristian Castro");
                    Console.WriteLine("7. El Amor de Mi Vida - Ricky Martin");
                    Console.WriteLine("8. Me Dediqué a Perderte - Alejandro Fernández");
                    Console.WriteLine("9. Duele el Corazón - Enrique Iglesias");
                    Console.WriteLine("10. El Sol No Regresa - La Quinta Estación");
                    Console.WriteLine("\nPresione una tecla para regresar al menú...");
                    Console.ReadKey();
                    break;

                case "6":
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Clear();
                    Console.WriteLine("***** INSTRUMENTALES *****");
                    Console.WriteLine("1. River Flows in You - Yiruma");
                    Console.WriteLine("2. Canon in D - Pachelbel");
                    Console.WriteLine("3. Fur Elise - Beethoven");
                    Console.WriteLine("4. Por Una Cabeza - Carlos Gardel");
                    Console.WriteLine("5. Libertango - Astor Piazzolla");
                    Console.WriteLine("6. Ballade pour Adeline - Richard Clayderman");
                    Console.WriteLine("7. Interstellar Main Theme - Hans Zimmer");
                    Console.WriteLine("8. Moonlight Sonata - Beethoven");
                    Console.WriteLine("9. The Godfather Theme");
                    Console.WriteLine("10. Comptine d’un autre été - Yann Tiersen");
                    Console.WriteLine("\nPresione una tecla para regresar al menú...");
                    Console.ReadKey();
                    break;

                case "7":
                    Console.Clear();
                    Console.WriteLine("Gracias por usar la Rockola UDB :D");
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opción no válida. Presione una tecla para intentar de nuevo...");
                    Console.ReadKey();
                    break;
            }

        } while (opcion != "7");

        Console.ResetColor();
    }
}
