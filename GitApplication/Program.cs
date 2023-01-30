using System;

namespace GitApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixA(10, 10);
        }

        public static void MatrixA(int width, int height) 
        {
            Random rnd = new Random();
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write(rnd.Next(0, 2) +  " ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
