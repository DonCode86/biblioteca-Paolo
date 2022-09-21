// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
Console.WriteLine("biblioteca Ciccarelli");

List<Documento> documenti = new List<Documento>();

List<Libro> libri = new List<Libro>();

List<Dvd> dvd = new List<Dvd>();

libri.Add(new Libro("libro",100));
libri.Add(new Libro("bello",200));
libri.Add(new Libro("mare",10));


dvd.Add(new Dvd("matrix",120));
dvd.Add(new Dvd("matrix 2",100));
dvd.Add(new Dvd("matrix 3", 80));

string titoloUtente = "ma";  

foreach(Libro libro in libri)
{
    if(libro.Titolo.Contains(titoloUtente))
    {
        Console.WriteLine(libro.Titolo);
    }
}

foreach (Dvd DVD in dvd)
{
    if (DVD.Titolo.Contains(titoloUtente))
    {
        Console.WriteLine(DVD.Titolo);
    }
}