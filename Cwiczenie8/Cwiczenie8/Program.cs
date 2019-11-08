using System;

namespace Cwiczenie8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 8\n");

            // Pierwszy sposób
            int[][] tab1 = new int[][]
            {
                new int[] {1, 2, 3},
                new int[] {4, 5, 6, 7, 8, 9},
                new int[] {10, 11, 12, 13},
                new int[] {14, 15, 16, 17, 18},
                new int[] {19, 20, 21}
            };

            Console.WriteLine("tab1");
            for(int i = 0; i < tab1.Length; i++)
            {
                for(int j = 0; j < tab1[i].Length; j++)
                {
                    Console.Write("[{0,2}]", tab1[i][j]);
                }
                Console.WriteLine();
            }

            // Drugi sposób
            int[][] tab2 = new int[5][];
            tab2[0] = new int[] { 1, 2, 3 };
            tab2[1] = new int[] { 4, 5, 6, 7, 8, 9 };
            tab2[2] = new int[] { 10, 11, 12, 13 };
            tab2[3] = new int[] { 14, 15, 16, 17, 18 };
            tab2[4] = new int[] { 19, 20, 21 };

            Console.WriteLine("\ntab2");
            for (int i = 0; i < tab1.Length; i++)
            {
                for (int j = 0; j < tab2[i].Length; j++)
                {
                    Console.Write("[{0,2}]", tab2[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
