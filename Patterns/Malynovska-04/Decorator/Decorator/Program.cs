using Decorator;
using System;


class Program
{
    static void Main(string[] args)
    {
        
        IBook basicBook = new BasicBook("City of girls", "Elizabeth Gilbert");
       
        basicBook = new HardcoverDecorator(basicBook);
        basicBook = new AdditionalDecorator(basicBook, "Bonus Chapter");
        basicBook = new BookMarkDecorator(basicBook, 1);

        Console.WriteLine("Book Author: " + basicBook.GetAuthor());
        Console.WriteLine("Book Title: " + basicBook.GetTitle());
   

        IBook anotherBook = new BasicBook("Eat. Love. Pray.", "Elizabeth Gilbert");
        anotherBook = new BookMarkDecorator(anotherBook, 120);

        Console.WriteLine("\nBook Author: " + anotherBook.GetAuthor());
        Console.WriteLine("Book Title: " + anotherBook.GetTitle());
        
    }
}

