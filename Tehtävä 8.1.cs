using System;

namespace Tehtävä_8._1_Hedelmät_Vladislav_jeskin
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,x;
            Console.WriteLine("Tehtävä 8.1! ");
            Console.WriteLine("");

            Console.WriteLine("------------------");
            Console.WriteLine("");

            Console.Write("Montako hedelmää halut nähdä ?");
            //number of fruits!
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            string[] nimet = { "Omena", "Banaani","Luumu" };

            Console.WriteLine("");

            for (i=0;i<x;i++)
            {
                Console.WriteLine($"{nimet[i]}");
            }
        }
    }
}
