using System;

namespace Tehtävä_3_pituusmuunnin_Vladislav_jeskin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Otsikko
            Console.WriteLine("Valuuttalaskuri");
            Console.WriteLine("----------------");
            Console.WriteLine("");

            Console.Write("Anna summa euroina");
            Euro = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            //Laskee eurot dollareiksi ja puntiksi
            string dol = string.Format("{0:0.00}", Euro*1.13);
            string pun = string.Format("{0:0.00}", Euro * 0.84);
            Console.WriteLine($"{dol} $");
            Console.WriteLine($"{pun} £");
        }
    }
}
