namespace Olio1
{
    class Kirjasto
    {
        //kentät
        private int erapaiva;
        private int sivumäärä;
        private string nimi;
        //= määrittelemäsi tyypit(mm.kirjan nimi, sivumäärä, kirjailija jne.)

        //metodit
        public int Erapaiva()
        {
            Console.WriteLine("Erapaiva metodia käytetty");
            return erapaiva;
        }
        public int Sivumäärä()
        {
            Console.WriteLine("Sivumäärä metodia käytetty");
            return sivumäärä;
        }
        public string Nimi()
        {
            Console.WriteLine("Nimi metodia käytetty");
            return nimi;
        }
        public string PalautaTeoksenNimi()
        {
          Console.WriteLine("PalautaTeoksenNimi metodia käytetty");
          
          return nimi;
        }
        //oletuskonstruktio
        public Kirjasto()
        {
            erapaiva = 0; //oletetaan, että tässä on lainausaika, esim. 30 päivää.
                          //ei koko päiväystä, joka vaatisi useamman eri muuttujan
            sivumäärä = 0;
            nimi = ""; //kaksi lainausmerkkiä alustaa merkkijonon arvoksi null

        }
        //Ylikuormitettu konstruktori
        public Kirjasto(int u_erapaiva, int u_sivumäärä, string u_nimi)
        {
            erapaiva = u_erapaiva;
            tyyppi = u_sivumäärä;
            nimi = u_nimi;

        }

    }
    class Olio1
    {
        static void Main(string[] args)
        {
            Kirjasto tallenne;
            tallenne = new Kirjasto();
            int uusi_erapaiva=tallenne.Erapaiva();
            int tyyppi=tallenne.Sivumäärä();
            string nimi=tallenne.Nimi();
            double u_sivumäärä,u_nimi,u_erapaiva;
            try
            {
                Console.WriteLine("Anna kirjan Sivunmäärä: ");
                u_sivumäärä = double.Parse(Console.ReadLine());
                Console.WriteLine("Anna kirjan erapaiva: ");
                u_erapaiva = double.Parse(Console.ReadLine());
                Console.WriteLine("Anna kirjan nimi: ");
                u_nimi = double.Parse(Console.ReadLine());

                Kirjasto kirjasto = new Kirjasto();
                kirjasto.Erapaiva = u_erapaiva; 
                kirjasto.Sivumäärä =

            }
            catch
            {
                Console.WriteLine("palauta");
            }
            Console.Writeline("\n\npaina jotain näppäitä jatkaaksesi...");
            Console.ReadKey(true);
        }
    }
  }
