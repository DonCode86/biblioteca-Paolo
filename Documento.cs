// See https://aka.ms/new-console-template for more information
public class Documento
{
    string ISBN;
    string seriale;

    public string Titolo { get; }
    int anno;
    string settore;
    bool stato;
    int telefono;
    string scaffale;

    Autore autore;
    public Documento(string titolo)
    {
        this.Titolo = titolo;
    }

    

    
   
}
