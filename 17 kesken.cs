using System;

namespace Tehtävä_17_Vakioluettelo_Vladislav_jeskin
{
    class Program
    {
        enum Case
        {
            Name = 1,
            Age = 2,
            showname = 3,
            showage = 4,
            quit = 5,

        }
        static void Main(string[] args)
        {
            int lisaaNimi =0,lisaaika =0;
            String nimi
            

            Console.WriteLine("Tervetuloa ohjelmaan. Siirry valikossa valitsemalla numero.");
            for (int i=1; i <= 5; i++)
            {
                switch (i)
                {
                    case (int)Case.Name:
                        Console.Write("Syötä Nimesi ");
                        lisaaNimi = int.Parse(Console.ReadLine());
                        break;
                    case (int)Case.Age:
                        Console.Write("Syötä ikäsi ");
                        lisaaika = int.Parse(Console.ReadLine());
                        break;
                    case (int)Case.showname:
                        Console.Write("Nimesi on  " + nautaNimi);
                        break;
                    case (int)Case.showage:
                        Console.Write("ikäsi on " + naytaika);
                        break;
                    case (int)Case.quit:

                        break;
                }
            }
        }  
    }
}
