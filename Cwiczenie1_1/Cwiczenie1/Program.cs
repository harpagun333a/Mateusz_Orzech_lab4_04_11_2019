using System;

namespace Cwiczenie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 1");

            int int_n = 0;
            int short_n = 0;

            // Dla inta
            Console.WriteLine("\n\n<<<<< Dla zmiennej typu int >>>>>");
            Console.WriteLine("\nPrzed korzystaniem z funkcji:");
            Console.WriteLine(int_n);

            Console.WriteLine("Po skorzystaniu z Fun2:");
            Fun2(out int_n);
            Console.WriteLine(int_n);

            Console.WriteLine("Po skorzystaniu z Fun3:");
            Fun3(ref int_n);
            Console.WriteLine(int_n);

            Console.WriteLine("Po skorzystaniu z Fun4:");
            Fun4(int_n);
            Console.WriteLine(int_n);

            Console.WriteLine("\n\n<<<<< Dla zmiennej typu short >>>>>");
            Console.WriteLine("\nPrzed korzystaniem z funkcji:");
            Console.WriteLine(short_n);

            Console.WriteLine("Po skorzystaniu z Fun2:");
            Fun2(out short_n);
            Console.WriteLine(short_n);

            Console.WriteLine("Po skorzystaniu z Fun3:");
            Fun3(ref short_n);
            Console.WriteLine(short_n);

            Console.WriteLine("Po skorzystaniu z Fun4:");
            Fun4(short_n);
            Console.WriteLine(short_n);
        }

        static void Fun1(in int i)
        {
            //i = 1;  //nie da się
        }

        static void Fun2(out int i)
        {
            i = 2;
        }

        //static void Fun2(in int i)    // Nie da się
        //{
        //    i = 5;
        //}

        static void Fun3(ref int i)
        {
            i = 3;
        }

        //static void Fun3(out int i)   // Nie da się
        //{
        //    i = 6;
        //}

        static void Fun4(int i)
        {
            i = 4;
        }
    }
}
