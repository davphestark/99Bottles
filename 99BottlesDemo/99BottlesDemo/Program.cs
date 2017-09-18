using System;

namespace _99BottlesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var song = new Song();
            song.InitSong();
            Console.WriteLine(song.PrintSong());
            Console.ReadKey();
        }
    }
}
