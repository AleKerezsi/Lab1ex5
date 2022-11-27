using System;

namespace Lab1ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se citesc doua numere de la tastatura, x,y. Scrieti un program care va afisa cele doua valori in ordine crescatoare */

            Console.WriteLine("Introduceti numarul x: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti numarul y: ");
            int y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine(y + " " + x);
            }

            if (y > x)
            {
                Console.WriteLine(x + " " + y);
            }

            if (x == y)
            {
                Console.WriteLine("Numerele sunt identice");
            }
        
        }
    }
}
