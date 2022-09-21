// See https://aka.ms/new-console-template for more information
public class Libro : Documento {
    int numeroPagine;

    public Libro(string titolo, int numeroPagine) : base(titolo)
    {
        this.numeroPagine = numeroPagine;
    }
}
