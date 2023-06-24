using System;

namespace lab1ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Scrieti un program care va calcula media aritmetica a trei numere citite de la tastatura
            */

            Console.WriteLine("introduceti primul numar");
            int numar1 = int.Parse(Console.ReadLine());

            Console.WriteLine("introduceti al doilea numar");
            int numar2 = int.Parse(Console.ReadLine());

            Console.WriteLine("introduceti al treilea numar");
            int numar3 = int.Parse(Console.ReadLine());

            double mediaAritmetica;
            mediaAritmetica = ((double)numar1 + (double)numar2 + (double)numar3)/3;
            Console.WriteLine("mwdia aritmetica a " + numar1 + ",  " + numar2 + ",  " + numar3 + " este: " + mediaAritmetica);

        }
    }
}
