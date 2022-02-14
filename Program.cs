using System;

namespace Tehtävä_3_pituusmuunnin_Vladislav_jeskin
{
    class Program
    {
        static void Main(string[] args)
        {

            
            
           
            
            double pituus;

            Console.WriteLine("Anna pituutesi senttimetreinä ?");
            pituus = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            
            
            
            string metri = string.Format("{0:0.00}", pituus / 100f);
            string maili = string.Format("{0:0.00}", pituus / 160934.4f );
            string jaardi = string.Format("{0:0.00}", pituus / 91.44f );
            string inchi = string.Format("{0:0.00}", pituus / 2.14f );
            
            
            
            Console.WriteLine($"metri on {metri}");
            Console.WriteLine($"maili on {maili}");
            Console.WriteLine($"jaardi on {jaardi}");
            Console.WriteLine($"inchi on {inchi}");
        }
    }
}
