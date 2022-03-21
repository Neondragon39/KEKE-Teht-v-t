using System;

namespace Tehtävä_10._2_Luvun_arvaus_Vladislav_jeskin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tehtävä 10 vaihe 2");
            Console.WriteLine("---------------------");
            Console.WriteLine("");

            Console.WriteLine("Arvaa arvottu luku väliltä 1-12 (Lopetus L-merkillä)");
            Console.WriteLine("");
            int x=0;
            Random satluku = new Random();
            int arvottuluku = satluku.Next(1, 13); //arvotaan luku 1-12 väliltä 
            int arvo=0;//käyttäjän arvaama luku
            string L="";// vastaa lopetus painikkeesta
            while (arvo < arvottuluku && L!="l")
            {
                x++;
                Console.Write(x+". yritys: Arvaa luku? ");
                
                L = Console.ReadLine();
                if (L=="l"||L=="L")//jos käyttäjä painaa L, niin simulaatio loppuu
                {
                    Console.WriteLine("Lopetetaan...");
                    Console.WriteLine("");
                    Console.WriteLine("Halusit lopettaa LUUSERI!!");
                    Console.WriteLine("Oikea vastaus on {0}",arvottuluku);//Tulostaa oikean vastauksen
                    break;
                }
                else//jos ei paineta L niin luvun arvaus jatkuu
                {
                    arvo = int.Parse(L);//
                    if(arvo==arvottuluku)//kun käyttäjä arvaa oikein
                    {
                        Console.WriteLine("Onneksi olkoon, arvasit oikein!!!");
                        break;//koodin lopetus
                    }
                    
                }
            }
        }
    }
}
