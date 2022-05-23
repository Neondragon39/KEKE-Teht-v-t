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
            
            //Kaikki int ja stringit
            int aika = 0;            
            int x = 0;
            string nimi = "";


            Console.WriteLine("Tervetuloa ohjelmaan. Siirry valikossa valitsemalla numero.");
            
            for (int i=0; i <= 5; i++)
            {
                Console.WriteLine("1. Syötä nimesi ");
                Console.WriteLine("2. Syötä ikäsi ");
                Console.WriteLine("3. Näytä nimesi ");
                Console.WriteLine("4. Näytä ikäsi ");
                Console.WriteLine("5. poistu ohjelmasta ");
                Console.WriteLine("");
                Console.Write(">");
                x = int.Parse(Console.ReadLine());

                switch (x)
                {
                    case (int)Case.Name:
                        Console.Write("Syötä Nimesi ");
                        nimi = Console.ReadLine();
                        Console.WriteLine("");
                        break;
                    case (int)Case.Age:
                        Console.Write("Syötä ikäsi ");
                        aika = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        break;
                    case (int)Case.showname:
                        Console.Write("Nimesi on : " + nimi);
                        Console.WriteLine("");
                        break;
                    case (int)Case.showage:
                        Console.Write("ikäsi on : " + aika);
                        Console.WriteLine("");
                        break;
                    case (int)Case.quit:


                        break;
                }
               
            }
        }  
    }
}
