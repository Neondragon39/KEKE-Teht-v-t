namespace Olio1
{
    class kirjasto
    {
        //kentät
        private int erapaiva;
        private int tyyppi;
        private int sivumäärä;
        private string nimi;
        //= määrittelemäsi tyypit(mm.kirjan nimi, sivumäärä, kirjailija jne.)

        //metodit
        public int Erapaiva()
        {
            Console.WriteLine("Erapaiva metodia käytetty");
            return erapaiva;
        }
        public int Sivummäärä()
        {
            Console.WriteLine("Sivumäärä metodia käytetty");
            return sivumäärä;
        }
        public string Nimi()
        {
            Console.WriteLine("Nimi metodia käytetty");
            return nimi;    
        }



        //oletuskonstruktio
        public kirjasto()
        {
            erapaiva = 0; //oletetaan, että tässä on lainausaika, esim. 30 päivää.
                          //ei koko päiväystä, joka vaatisi useamman eri muuttujan 
            sivumäärä = 0;
            nimi = ""; //kaksi lainausmerkkiä alustaa merkkijonon arvoksi null

        }
        //Ylikuormitettu konstruktori
        public kirjasto(int u_erapaiva, int u_sivumäärä, string u_nimi)
        {
            erapaiva = u_erapaiva;
            tyyppi = u_sivumäärä;
            nimi = u_nimi;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            double u_sivumäärä,u_nimi,u_erapaiva;
            Console.WriteLine("Anna kirjan Sivunmäärä: ");
            u_sivumäärä = double.Parse(Console.ReadLine());
            Console.WriteLine("Anna kirjan erapaiva: ");
            u_erapaiva = double.Parse(Console.ReadLine());
            Console.WriteLine("Anna kirjan nimi: ");
            u_nimi = double.Parse(Console.ReadLine());
        }
    }
}