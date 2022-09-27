using System;

namespace Tehtävä_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna jokin merkki : ");
            char merkki = char.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(merkki);
            Console.WriteLine();


            if (char.IsLower(merkki))
            {
                Console.WriteLine("On pieni kirjain");
                Console.WriteLine("");
            }
            else if (char.IsUpper(merkki))
            {
                Console.WriteLine("On ISO kirjain");
                Console.WriteLine("");
            }

            else if (char.IsNumber(merkki))
            {
                Console.WriteLine("On numero " + merkki);
            }

            else if (char.IsSeparator(merkki))
            {
                Console.WriteLine("Annoit tyhjän merkin");
            }

            else
            {
                Console.WriteLine("Annoit jonkin erikoismerkin !");
            }
        }
    }
}
