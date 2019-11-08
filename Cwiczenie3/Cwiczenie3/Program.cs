using System;

namespace Cwiczenie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 3");

            int[] tab = new int[10];
            string input;
            int n;

            Console.Write("\nPodaj liczbę typu int do wpisania do kolejki: ");

            while ((input = Console.ReadLine()) != "q")
            {

                if (!int.TryParse(input, out n))
                {
                    Console.WriteLine("To nie jest int :( ");
                    Console.Write("\nPodaj liczbę typu int do wpisania do kolejki: ");
                    continue;
                }

                for (int i=8; i>=0; i--)
                {
                    tab[i + 1] = tab[i];
                }

                tab[0] = n;

                for(int i=0; i<10; i++)
                {
                    Console.Write("[{0}]", tab[i]);
                }

                Console.WriteLine();
                Console.Write("\nPodaj liczbę typu int do wpisania do kolejki: ");
            }            
        }
    }
}
