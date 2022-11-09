class Kirjasto//kirjastoluokka
{   //kenttä ja ovat yksityiset
    private string otsikko;
    private string kirjailija;
    private int sivumaara;



    private int erapaiva;
    private int tyyppi;
    private string nimi;



    //metodi jotka muutettu julkiseksi
    public string Otsikko
    { //otsikko pitää olla isolla kirjaimella muuten ei toimi
        get { return otsikko; }//päästäkseen käsiksi yksityiskenttään
        set { otsikko = value; }//sitten kohteeseen, jonka olen asettanut tallentamaan yksityiseen kenttään.                         
    }

    public string Kirjailija
    {
        get { return kirjailija; }
        set { kirjailija = value; }
    }

    public int Sivumaara//tämä ei anna muuttaa sivumäärää kirja1 sestä program puolella.
    {
        get { return sivumaara; }
        set
        {
            if (value >= 200)
            {
                sivumaara = 200;
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Kirjasto Kirja = new Kirjasto(); // 
        Kirja.Kirjailija = "Arthur Snowger";
        Kirja.Otsikko = "Benjamin";
        Kirja.Sivumaara = 750;
           
        Kirjasto uusi_erapaiva = new Kirjasto();
        Kirjasto uusi_tyyppi = new Kirjasto();
        Kirjasto uusi_nimi = new Kirjasto();



        Console.WriteLine(+Kirja.Sivumaara + " Kirjailijan " + Kirja.Kirjailija);

        Console.ReadLine();
    }
}
