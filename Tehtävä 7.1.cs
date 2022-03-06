using System;

namespace Tehtävä_7._1_Lukujen_tulostus_Vladislav_Jeskin
{
    class Program
    {
        static void Main(string[] args)
        {
            int Luku;
            Console.WriteLine("Tehtävä 7.1 ");
            Console.WriteLine("");

            Console.WriteLine("-------------------");

            Console.Write("Anna aloituskuku? ");
            Luku = int.Parse(Console.ReadLine());
            for (int i = Luku; i >= 0; i-- )
            {
                Console.WriteLine($"{i}");
            }

        }
    }
}
