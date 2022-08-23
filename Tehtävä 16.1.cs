
class Program
{
    static void Main(string[] args)
    {
        // See https://aka.ms/new-console-template for more information
        //talennetut viikonpäivät
        string Jatka = "K";
        
        int maanantai, tiistai, keskiviikko, torstai, perjantai, lauantai, sunnuntai;
        int viikonpäivä, Ohjelma;
        
        
        



        while (Jatka == "K")
        {
            //ohjelman alku
            Console.Write("Anna numero 1-7 väliltä, niin kerron mikä viikonpäivä on kyseessä   ?    ");
            Console.WriteLine("");
            //tallenetaan käyttäjän vastaus
            viikonpäivä = int.Parse(Console.ReadLine());
            switch (viikonpäivä)
            {
                case 1:
                    maanantai = 1;
                    Console.WriteLine("maannantai");
                    
                    break;
                case 2:
                    tiistai = 2;
                    Console.WriteLine("Tiistai");
                    
                    break;
                case 3:
                    keskiviikko = 3;
                    Console.WriteLine("keskiviikko");
                    ;
                    break; ;
                case 4:
                    torstai = 4;
                    Console.WriteLine("Torstai");
                    
                    break;
                case 5:
                    perjantai = 5;
                    Console.WriteLine("Perjantai");
                    
                    break;
                case 6:
                    lauantai = 6;
                    Console.WriteLine("Lauantai");
                    
                    break;
                case 7:
                    sunnuntai = 7;
                    Console.WriteLine("Sunnuntai");
                    
                    break;
                default:
                    Console.WriteLine("semmoinsta viikonpäivää ei ole :(");
                    break;
            }
            Console.WriteLine("Haluatko jatkaa?  K/E");
            Console.WriteLine("");
            Jatka = Console.ReadLine();
            
        }
        
    }
}