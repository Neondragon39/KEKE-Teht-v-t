using System;
using System.Collections.Generic;

namespace Tehtävä_11_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tehtävä 11");
            Console.WriteLine();
            Console.WriteLine("--------------");
            Console.WriteLine();

            int luku = 0; //Alustetaan luku muuttuja
            List<int> lista = new List<int>();//Luodaan lista



            for (int i = 1; i < 6; i++)//Luodaan i joka esittää kysymyken 5 kertaa
            {
                Console.Write(i + ". listan luku ? "); //Esitetään kysymys
                luku = int.Parse(Console.ReadLine()); //Tallennetan käyttäjän vastaus luku muuttujaan
                lista.Add(luku); //Luku muuttujan arvot siirtyvät lista muuttujaan
                Console.WriteLine();
            }

            foreach (int i in lista)//i saa lista muuttujasta arvot yksi kerrallaan alusta loppuun asti
            {
                Console.WriteLine(i);//i näytetään
            }
        }
    }
}
