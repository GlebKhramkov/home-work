using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random((int)DateTime.Now.Ticks);
            int[,] matrix = new int[n, n];
            int[,] transpMatrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(0, 10);
                    transpMatrix[j, i] = matrix[i, j];
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(transpMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
 
        }       
    }
}