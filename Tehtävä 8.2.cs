using System;

namespace Tehtävä_8._2_Tuotteet_ja_hinnat_Vladislav_jeskin
{
    class Program
    {
        static void Main(string[] args)
        {
            int i ;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Tehtävä 8.2");
            Console.WriteLine("");

            Console.WriteLine("------------------");
            Console.WriteLine("");
            string[] Nimet = { "Vasara", "Saha", "Kirves" };
            int[] hinnat =  { 5 , 10, 15 };
            
            for (i=0;i<3;i++)
            {
                //Console.WriteLine($"{Nimet[i]} {hinnat[i]} € ");
                
                Console.WriteLine(Nimet[i] + " " + hinnat[i]+ " €");
                    
                
            }


        }
    }
}
