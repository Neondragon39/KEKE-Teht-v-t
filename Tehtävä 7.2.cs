using System;

namespace Tehtävä_7._2_Lukujen_laskenta_Vladislav_Jeskin
{
    class Program
    {
        static void Main(string[] args)
        {
            int Luku;
            int Vastaus1;
            int Vastaus2;
            int Vastaus3;
            Console.Write("Anna luku 1 ja 10 väliltä ? ");
            Luku = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            for(int i=1; i<=5; i++)
            {
                Vastaus1 = i * Luku; Vastaus2 = i / Luku; Vastaus3 = i % Luku;
                Console.WriteLine($"{i}*{Luku}={Vastaus1}  {i}/{Luku}={Vastaus2}  {i}%{Luku}={Vastaus3} ");

            }
        }
    }
}
