using System;

namespace Cwiczenie6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 6\n");

            int[,] tab1 = new int[,] { {1, 2, 3, 4, 5 },
                                       {6, 7, 8, 9, 10},
                                       {11, 12, 13, 14, 15},
                                       {16, 17, 18, 19, 20},
                                       {21, 22, 23, 24, 25} };
            int[,] tab2 = new int[,] { {1, 2, 3, 4, 5 },
                                       {6, 7, 8, 9, 10},
                                       {11, 12, 13, 14, 15},
                                       {16, 17, 18, 19, 20},
                                       {21, 22, 23, 24, 25} };
            int[,] tab3 = new int[5, 5];

            // Sumowanie po komórkach
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    tab3[i, j] = tab2[i, j] + tab1[i, j];
                }
            }

            // Wypisywanie tablic
            Console.WriteLine("tab1");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("[{0,2}]", tab1[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\ntab2");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("[{0,2}]", tab2[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\ntab3");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("[{0,2}]", tab3[i, j]);
                }
                Console.WriteLine();
            }

            // Wypisanie parametrów
            Console.WriteLine("\nLength: {0}", tab3.Length);
            Console.WriteLine("LongLength: {0}", tab3.LongLength);
            Console.WriteLine("Rank: {0}", tab3.Rank);
        }
    }
}
