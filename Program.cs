using System;
using System.Collections.Generic;

namespace Kotikirjasto
{

    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }

        public Book(string name, string author, int year, string genre)
        {
            Name = name;
            Author = author;
            Year = year;
            Genre = genre;
        }
    }


    class Program
    {

        static List<Book> books = new List<Book>();


        static void Main(string[] args)
        {

            bool run = true;


            while (run)
            {
                Console.WriteLine("Kotikirjasto");
                Console.WriteLine("1. Lisaa kirja");   // teen nää viel
                Console.WriteLine("2. Nayta kirjat");
                Console.WriteLine("3. Lopeta");
                Console.Write("Valitse: ");

                string choice = Console.ReadLine();


                if (choice == "1")
                {
                    AddBook();   // ei valmis viel
                }
                else if (choice == "2")
                {
                    ShowBooks();  // ei valmis
                }
                else if (choice == "3")
                {
                    run = false;
                }
                else
                {
                    Console.WriteLine("Virhe valinnassa");
                }

                Console.WriteLine(""); 
            }

        }


    static void AddBook()
    {
        Console.Write("Kirjan nimi: ");
        string name = Console.ReadLine();

        Console.Write("Kirjoittaja: ");
        string author = Console.ReadLine();

        Console.Write("Julkaisuvuosi: ");
        int year = int.Parse(Console.ReadLine());

        Console.Write("Genre: ");
        string genre = Console.ReadLine();

        Book uusi = new Book(name, author, year, genre);
        books.Add(uusi);

        Console.WriteLine("Kirja lisatty!");
    }


    static void ShowBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("Ei kirjoja listalla.");
            return;
        }

        Console.WriteLine("Kaikki kirjat:");

        foreach (Book b in books)
        {
            Console.WriteLine(b.Name + " - " + b.Author + " (" + b.Year + ") " + b.Genre);
        }
    }
   


    }

}

