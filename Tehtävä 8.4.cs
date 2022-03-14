using System;

namespace Tehtävä_8._4_HEROt_Vladislav_jeskin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tehtävä 8.4 ");
            Console.WriteLine("---------------------");
            Console.WriteLine("");
            

            string[,] arvot = new string[4,5]
               {{ "Heroes", "Ana", "Bastion", "Brigette", "D.Va(Mech)" },
                { "ROLE", "Support", "Defence", "Support", "Tank" },
                { "HEALTH", "200", "200", "200", "400" },
                { "ARMOR", "0", "100", "50", "200"} };
            Console.WriteLine("");

            Console.WriteLine("Herot ovat seuraavat" );

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("(" + (i) + ") " + arvot[0, i]);

            }
            Console.WriteLine("");

            Console.Write("Valitse minkä Heron tiedot haluat nähdä? ");
            int sankari = int.Parse(Console.ReadLine());
            for (int j=0;j<4;j++)
            {
                    Console.Write(arvot[j, sankari] + " ");
                    Console.Write("");
            }

            Console.WriteLine("");
            return;
        }
    }
}
 /*string[] arvot = new string[]
               { { "Heroes", "Ana", "Bastion", "Brigette", "D.Va(Mech)" };
                { "ROLE", "Support", "Defence", "Support", "Tank" };
                { "HEALTH", "200", "200", "200", "400" };
                { "ARMOR", "0", "100", "50", "200"};
/*string[] Heroes = { "Ana", "Bastion", "Brigette", "D.Va(Mech)" };
            string[] Role = { "Support", "Defence", "Support", "Tank" };
            string[] Healt = { "200", "200", "200", "400" };
            string[] ARMOR = {"0", "100"}*/
// Muuten hyvä idea, mutta pääsee paljon helpomalla