using System;
using System.Collections.Generic;

namespace Kotikirjasto
{

    class Book
    {
        public string Name;
        public string Author;
        public int Year;
        public string Genre;
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
            // teen taman myohemmin
            Console.WriteLine("Tama ei toimi viela...");
        }



        static void ShowBooks()
        {
            // ei toimi viela
            Console.WriteLine("Kirjoja ei nayteta viela...");
        }


    }

}

