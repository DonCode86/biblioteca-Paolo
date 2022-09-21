// See https://aka.ms/new-console-template for more information
public class Dvd : Documento
{
    int durata;

    public Dvd(string titolo, int durata) : base(titolo)
    {
        this.durata = durata;
    }
}
