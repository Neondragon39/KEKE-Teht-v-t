using System;

namespace Tehtävä_9_lukujen_keskiarvo_Vladislav_jeskin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tehtävä 9 ");
            Console.WriteLine("-------------------");
            Console.WriteLine("");
            int[] taulukko = new int[5];
            double vastaus=0;

            Console.WriteLine("Anna viisi lukua niin lasken niiden keskiarvon ");
            for (int i=0;i<5;i++)
            {
                Console.Write("Anna " + (i+1) + ". luku ? " );
                taulukko[i] = int.Parse(Console.ReadLine()); 
            }
            foreach (double KA in taulukko)
            {
                vastaus += KA;
            }
            Console.Write("Keskiarvo on " + vastaus / 5);
        }
    }
}
