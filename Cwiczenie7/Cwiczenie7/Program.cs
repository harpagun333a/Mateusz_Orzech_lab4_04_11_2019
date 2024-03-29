﻿using System;

namespace Cwiczenie7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 7\n");

            int[,] tab = new int[,]
            {
                {1, 0, -1},
                {0, 0, 1},
                {-1, -1, 0}
            };

            int to_add = tab[0, 0] * tab[1, 1] * tab[2, 2] + tab[0, 1] * tab[1, 2] * tab[2, 0] + tab[0, 2] * tab[1, 0] * tab[2, 1];
            int to_sub = tab[0, 2] * tab[1, 1] * tab[0, 2] + tab[1, 2] * tab[2, 1] * tab[0, 0] + tab[2, 2] * tab[0, 1] * tab[1, 0];

            int det = to_add - to_sub;

            Console.WriteLine("\ntab");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[{0,2}]", tab[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\ndet = {0}", det);
        }
    }
}
