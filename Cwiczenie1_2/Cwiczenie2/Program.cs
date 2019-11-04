using System;

namespace Cwiczenie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 2");

            Point punkt = new Point(0, 0);

            Console.WriteLine("\nPrzed wywołaniem funkcji");
            punkt.print();

            Console.WriteLine("\nPo wywołaniu Fun5");
            Fun5(punkt);
            punkt.print();

            Console.WriteLine("\nPo wywołaniu Fun6");
            Fun6(ref punkt);
            punkt.print();

            Console.WriteLine("\n\n<<<<< Przypisuję null >>>>>");
            punkt = null;
            Console.WriteLine("\nPunkt: " + punkt);

            Console.WriteLine("\nPo wywołaniu Fun5");
            Fun5(punkt);
            Console.WriteLine("\nPunkt: " + punkt);

            Console.WriteLine("\nPo wywołaniu Fun6");
            Fun6(ref punkt);
            punkt.print();

        }

        public class Point
        {
            public int x, y;

            public Point(int p1, int p2)
            {
                x = p1;
                y = p2;
            }

            public void print()
            {
                Console.WriteLine("X: " + x.ToString());
                Console.WriteLine("Y: " + y.ToString());
            }
        }

        static void Fun5(Point p)
        {
            p = new Point(1, 1);
        }

        static void Fun6(ref Point p)
        {
            p = new Point(2, 2);
        }
    }
}
