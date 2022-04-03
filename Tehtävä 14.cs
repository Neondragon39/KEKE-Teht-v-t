using System;

namespace Tehtävä_14_syötteen_tarkistus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tehtävä 14 ");
            Console.WriteLine("-------------------");
            Console.WriteLine("");

            int num = 0;

            Console.WriteLine("Anna kokonaisluku? ");
            string numInput = Console.ReadLine();

            bool success = Int32.TryParse(numInput, out num);

            if (success)
            {
                Console.WriteLine("convert '"+numInput+"' to "+numInput+". NIICE!!" );
            }
            else 
            {
                Console.WriteLine($"Attempted conversion of '{numInput}' failed. SORRY! ");
            }

        }
    }
}
