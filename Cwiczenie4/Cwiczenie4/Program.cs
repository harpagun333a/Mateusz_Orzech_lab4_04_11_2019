using System;

namespace Cwiczenie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 4\n");

            int[] tab = new int[5];
            string input;
            bool isError = false;

            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write("Podaj {0} liczbę typu int: ", i + 1);
                input = Console.ReadLine();

                if(!int.TryParse(input, out tab[i]))
                {
                    Console.WriteLine("To nie jest int :(");
                    isError = true;
                    break;
                }
            }

            if (!isError)
            {
                Console.WriteLine("Podane liczby:");
                for (int i = 4; i >= 0; i--)
                {
                    Console.WriteLine(tab[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
