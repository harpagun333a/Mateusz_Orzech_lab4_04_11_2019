using System;

namespace Cwiczenie2
{
    class Program
    {
        public unsafe static void Main(string[] args)   // Bez unsafe będą same błędy
        {
            Console.WriteLine("Cwiczenie 2\n");

            int[] list = { 10, 100, 200 };
            fixed (int *ptr = list)

            for (int i=0; i < 3; i++)
            {
                Console.WriteLine("Adres [{0}] = {1}", i, (int)(ptr + i));
                Console.WriteLine("Wartość [{0}] = {1}", i, *(ptr + i));
            }

            Console.WriteLine("\n<<<<< Po swapie indeksów 0 i 2 >>>>>\n");
            fixed (int *ptr = list)
            swap(ptr, ptr + 2);

            fixed (int* ptr = list)
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Adres [{0}] = {1}", i, (int)(ptr + i));
                Console.WriteLine("Wartość [{0}] = {1}", i, *(ptr + i));
            }

            Console.WriteLine("\n\n<<<<< Wprowadzenie bufforu >>>>>\n");

            int[] buffor = new int[1024];
            fixed(int *ptr = buffor)
            {
                for (int i=0; i<1024; i++)
                {
                    *(ptr + i) = i;
                }

                for(int i=0; i<10; i++)
                {
                    Console.WriteLine("Adres [{0}] = {1}", i, (int)(ptr + i));
                    Console.WriteLine("Wartość [{0}] = {1}", i, *(ptr + i));
                }

                for (int i = 500; i < 506; i++)
                {
                    Console.WriteLine("Adres [{0}] = {1}", i, (int)(ptr + i));
                    Console.WriteLine("Wartość [{0}] = {1}", i, *(ptr + i));
                }

                for (int i = 898; i < 903; i++)
                {
                    Console.WriteLine("Adres [{0}] = {1}", i, (int)(ptr + i));
                    Console.WriteLine("Wartość [{0}] = {1}", i, *(ptr + i));
                }

                for (int i = 1018; i < 1024; i++)
                {
                    Console.WriteLine("Adres [{0}] = {1}", i, (int)(ptr + i));
                    Console.WriteLine("Wartość [{0}] = {1}", i, *(ptr + i));
                }
            }

        }

        public unsafe static void swap(int* p, int* q)
        {
            int temp = *p;
            *p = *q;
            *q = temp;
        }
    }
}
