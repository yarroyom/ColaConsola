using System;
using System.Collections.Generic;

class Program
{
    static Queue<string> musicQueue = new Queue<string>();

    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al reproductor de música");

        while (true)
        {
            Console.WriteLine("1. Agregar una canción a la cola");
            Console.WriteLine("2. Reproducir la siguiente canción de la cola");
            Console.WriteLine("3. Salir");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Ingrese el nombre de la canción: ");
                    string songName = Console.ReadLine();
                    musicQueue.Enqueue(songName);
                    Console.WriteLine("Canción agregada a la cola");
                    break;

                case "2":
                    if (musicQueue.Count == 0)
                    {
                        Console.WriteLine("No hay canciones en la cola");
                    }
                    else
                    {
                        string nextSong = musicQueue.Dequeue();
                        Console.WriteLine("Reproduciendo: " + nextSong + "*****CHA CHA CHA*****");
                    }
                    break;

                case "3":
                    Console.WriteLine("Adiós");
                    return;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }
    }
}


