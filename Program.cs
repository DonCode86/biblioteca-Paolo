// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
Console.WriteLine("biblioteca Ciccarelli");



//List<Libro> libri = new List<Libro>();

//List<Dvd> dvd = new List<Dvd>();

//libri.Add(new Libro("libro",100));
//libri.Add(new Libro("bello",200));
//libri.Add(new Libro("mare",10));


//dvd.Add(new Dvd("matrix",120));
//dvd.Add(new Dvd("matrix 2",100));
//dvd.Add(new Dvd("matrix 3", 80));

Biblioteca biblio = new Biblioteca();

List<Dvd> ricerca = biblio.RicercaFilm ("ma");
foreach (Dvd dvd in ricerca)
{
    Console.WriteLine(dvd.Titolo);
}

//foreach(Libro libro in libri)
//{
//    if(libro.Titolo.Contains(titoloUtente))
//    {
//        Console.WriteLine(libro.Titolo);
//    }
//}

//foreach (Dvd DVD in dvd)
//{
//    if (DVD.Titolo.Contains(titoloUtente))
//    {
//        Console.WriteLine(DVD.Titolo);
//    }
//}



public class Biblioteca
{
    List<Documento> documenti = new List<Documento>();

    public Biblioteca()
    {
        documenti.Add(new Libro("libro", 100));
        documenti.Add(new Libro("bello", 200));
        documenti.Add(new Libro("mare", 10));


        documenti.Add(new Dvd("matrix", 120));
        documenti.Add(new Dvd("matrix 2", 100));
        documenti.Add(new Dvd("matrix 3", 80));
    }

    public List<Documento> RicercaDocumenti(string query)
    {
        List<Documento> res = new List<Documento>();
        foreach (Documento doc in documenti)
        {
            if (doc.Titolo.Contains(query))
            {
               res.Add(doc);
            }
        }

        return res;
    }

    public List<Dvd> RicercaFilm(string query)
    {
        List<Dvd> res = new List<Dvd>();
        foreach (Documento doc in documenti)
        {
            if (doc.GetType() == typeof(Dvd) && doc.Titolo.Contains(query))
            {
                res.Add((Dvd)doc);
            }
        }

        return res;
    }
}