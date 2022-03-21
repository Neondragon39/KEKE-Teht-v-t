using System;

namespace Tehtävä_12_Aliohjelma_1_Vladislav_Jeskin
{
    class Program
    {
        public class Neliöitä
        {


            public static int NelionAla(int luku)// aliohjelma
            {
                
                int tulos = luku * luku;// kanta * korkeus
                return tulos;
            }

            public static void Main()//main ohjelma
            {

                Console.WriteLine("Tehtävä 12.1!");
                Console.WriteLine("-------------------");
                Console.WriteLine("");
                // tallennetut lyhenteet
                int luku;
                int ala;
                Console.Write("Anna luku, jonka neliön haluat tietää ");
                luku = int.Parse(Console.ReadLine());//käyttäjän tuoma neliön pinta alan alku
                
                
                    
                 
                 ala = NelionAla(luku);// aliohjelma laskee

                Console.WriteLine("Ala on {0:0.00}", ala);// tulostus


            }

        }
    }
}

