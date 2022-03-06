using System;

namespace Tehtävä_6_Säätilat_Vladislav_Jeskin
{
    class Program
    {
        static void Main(string[] args)
        {
            char A = 'K';
            char E = 'E';
            Char Paistaako;
            Char Sataako;

            char Lämpö;

            Console.Write("Paistaa aurinko (K/E) ? ");
            Paistaako = char.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (Paistaako == A)
            {
                Console.Write("Sataako Vettä (K/E)? ");
                Sataako = char.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (Sataako == A)
                {
                    Console.Write("Onko Lämpötila >0 (K/E)? ");
                    Lämpö = char.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    if (Lämpö == A)
                    {
                        Console.WriteLine("Aurinko paistaa ja vettä sataa, taitaa tulla kesä");

                    }
                    else if (Lämpö == E)
                    {
                        Console.WriteLine("Ompa erikoinen sää");
                    }
                }
            }
            else if (Paistaako == E)
            {

                Console.Write("Sataako Vettä (K/E)? ");
                Sataako = char.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (Sataako == A)
                {
                    Console.Write("Onko Lämpötila >0 (K/E)?");
                    Lämpö = char.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    if (Lämpö == A)
                    {
                        Console.WriteLine("Syksy saapui tuuli vei lehdet mennessään");
                    }
                }
                else if (Sataako == E)
                {
                    Console.Write("Onko Lämpötila >0 (K/E)?");
                    Lämpö = char.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    if (Lämpö == A)
                    {
                        Console.WriteLine("Jo joutui armas aika ja suvi suloinen");

                    }
                }
            }
        }
    }
}
