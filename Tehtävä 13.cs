using System;

namespace Tehtävä_13_Aliohjelma_2_Vladislav_jeskin
{
    public class Summa
    {
        public static int yhteenlasku(int luku1, int luku2, int luku3)
        {
            int tulos = luku1 + luku2 + luku3;
            return tulos;
        }
        public static void Main()
        {
            //int[] luku1, luku2, luku3 = new int[];
            Console.WriteLine("Tehtävä 13!");
            Console.WriteLine("-----------------------");
            Console.WriteLine("");
            int tulos;
            int[] luvut = { 1, 2, 3 };
            Console.WriteLine("Anna 3 lukua, niin lasken niiden summan...");
            for (int i = 0; i < 3; i++)
            {
                //int[] luvut = { 1, 2, 3 };

                Console.Write("Anna " + (i + 1) + ". luku? ");
                luvut[i] = int.Parse(Console.ReadLine());




            }
                tulos = yhteenlasku(luvut[0], luvut[1], luvut[2]);
            
                Console.WriteLine("Summa on on {0:00}", tulos);
            

        }
    }
}
