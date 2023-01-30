using System;

namespace GitApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public static void MatrixB(int width, int height)
        {
            Random rnd = new Random();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write(rnd.Next(0, 2) + " ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
