using System;

namespace Cwiczenie5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 5\n");

            int[] tab = new int[5];
            string input;

            bool isError = false;

            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write("Podaj {0} wartość tablicy: ", i + 1);
                input = Console.ReadLine();

                if (!int.TryParse(input, out tab[i]))
                {
                    Console.WriteLine("To nie int :(");
                    isError = true;
                    break;
                }
                else if(tab[i] < 0)
                {
                    Console.WriteLine("Wartość jest mniejsza niż 0 :(");
                    isError = true;
                    break;
                }
            }

            if(isError)
            {
                return;
            }

            int liczby_powt_sie = 0;
            int[] sprawdzone = new int[] { -1, -1, -1, -1, -1 };
            int[] powtarzajace_sie = new int[] { -1, -1, -1, -1, -1 };
            int[] liczba_powtorzen = new int[] { -1, -1, -1, -1, -1 };
            int count;

            for (int i = 0; i < tab.Length; i++)
            {
                count = 0;

                // Sprawdzenie czy wartość była już sprawdzana
                for (int j = 0; j < powtarzajace_sie.Length; j++)
                {
                    if (tab[i] == powtarzajace_sie[j])
                    {
                        count++;
                    }
                }

                if(count > 0)
                {
                    continue;
                }

                // Zliczanie ile razy dana wartość występuje
                count = 1;
                for (int j = i + 1; j < tab.Length; j++)
                {
                    if (tab[i] == tab[j])
                    {
                        count++;
                    }
                }

                // Dodanie wartości do już sprawdzonych i zapisanie wyniku, jesli wartość występuje więcej niż 1 raz
                if (count > 1)
                {
                    powtarzajace_sie[liczby_powt_sie] = tab[i];
                    liczba_powtorzen[liczby_powt_sie] = count;
                    liczby_powt_sie++;
                }
            }

            Console.WriteLine("\n\nLiczby powtarzające się:");
            for(int i = 0; i < liczby_powt_sie; i++)
            {
                Console.WriteLine("\nWartość: {0}\nPowtórzenia: {1}", powtarzajace_sie[i], liczba_powtorzen[i]);
            }
        }
    }
}
