using System;

namespace Tehtävä_10._1_Lukujen_summa_Vladislav_jeskin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tehtävä 10.1! ");
            Console.WriteLine("----------------------------");
            Console.WriteLine("");
            int Luku = 0 ;
            int x = 0;
            int Vastaus=0;

            Console.WriteLine("Anna kokonaislukuja, niin lasken summan reaaliajassa ");
            while ( Vastaus < 100)
            {

                x++;
                Console.Write("Anna "+ (x) + ". luku? ");
                Luku  = int.Parse(Console.ReadLine());
                Vastaus += Luku;
                Console.WriteLine("Summa on nyt "+ Vastaus);

            }
            Console.WriteLine("Raja on saavutettu!!!!");
        }
    }
}
