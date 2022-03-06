using System;

namespace Tehtävä_5._2_Käyttäjän_iän_määritys_Vladislav_jeskin
{
    class Program
    {
        static void Main(string[] args)
        {
            //int vastaa luvuista
            int ikä;
            // Char vastaa yhdestä kirjaimesta
            Char A = 'M';
            Char F = 'N' ;
            Char Gender;
            Console.Write("Minkä ikäinen olet? ");
            ikä = int.Parse(Console.ReadLine());

            Console.Write("Oletko nainen vai mies (N/M) ? ");
            Gender = Char.Parse(Console.ReadLine());

            if (Gender == A)
            {
                if (ikä < 14 )
                {
                    Console.WriteLine("Mitäs poitsu");                  
                }
                else if (ikä >= 14 && ikä <= 24  )
                {
                    Console.WriteLine(" Mitäs nuori mies");
                }
                else if (ikä >= 26 && ikä <=56)
                {
                    Console.WriteLine("Olet mies parhaassa iässä!");
                }
                else if (ikä > 56)
                {
                    Console.WriteLine("Mitäs vanha ukko");
                }
            }
            else if (Gender == F)
            {
                if (ikä < 14)
                {
                    Console.WriteLine("Mitäs tyttö?");
                }
                else if (ikä >= 14 && ikä <= 24)
                {
                    Console.WriteLine("Mitäs nuori nainen");
                }
                else if (ikä >= 26 && ikä <= 56)
                {
                    Console.WriteLine("Olet nainen parhaassa iässä!");
                }
                else if (ikä > 56)
                {
                    Console.WriteLine("Mitäs vanha akka ?");
                }
            }
            /*else ()
              {
                return;
               }*/
            /*mies, alle 14v --> Mitäs poitsu ?

            mies, 14 - 25v-- > Mitäs nuori mies ?

            mies, 26 - 56v-- > Olet mies parhaassa iässä!

            mies, yli 56v-- > Mitäs vanha ukko ?

            nainen, alle 14v-- > Mitäs tyttö?

            nainen, 14 - 25v-- > Mitäs nuori nainen ?

            nainen, 26 - 56v-- > Olet nainen parhaassa iässä!

            nainen, yli 56v-- > Mitäs vanha akka ?*/
        }
    }
}
