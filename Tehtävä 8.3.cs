using System;

namespace Tehtävä_8._3_Tuotteet_ja_yhteishinnat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Esitellään muuttujat
            int tuotemaara;
            //int raha;
            Console.Write("Kuinka monta tuotetta lisätään? ");
            tuotemaara = int.Parse(Console.ReadLine());
            string[] nimi = new string[tuotemaara];
            int[] hinta = new int[tuotemaara];
            int[] lkm = new int[tuotemaara];
            for (int i = 0; i < tuotemaara; i++)
            {
                Console.Write("Anna " + (i + 1)+". tuotteen nimi? ");
                nimi[i] = Console.ReadLine();
                Console.Write("Anna " + (i + 1) + ". hinta? ");
                hinta[i] = int.Parse(Console.ReadLine());
                Console.Write("Anna " + (i + 1) + ". Lukumäärä ? ");
                lkm[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("");

            }
            for (int j = 0; j < tuotemaara; j++)
            {
                Console.WriteLine(nimi[j] + " " + (hinta[j] * lkm[j]) + " Euroa");
                                
            }
        }
    }
}
