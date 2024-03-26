using System;
using System.Collections.Generic;


class Book
{
    public string Title { get; set; }
    public int Year { get; set; }
    public string Author { get; set; }

    public Book(string title, int year, string author)
    {
        Title = title;
        Year = year;
        Author = author;
    }

    public Book Clone()
    {
        return new Book(Title, Year, Author);
    }

    public override string ToString()
    {
        return $"{Title}, in {Year}. This book is written by {Author}";
    }
}

class Library
{
    private List<Book> books = new List<Book>();

    public void Adding(Book book)
    {
        books.Add(book);
    }

    public void PrintBooks()
    {
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }
}

class Program
{
    static void Main()
    {
        Book firstBook = new Book("TIMS", 2012, "Seno Petro");
        Library library = new Library();
        library.Adding(firstBook);

        Book clonedFirst = firstBook.Clone();
        clonedFirst.Year = 2017;
        library.Adding(clonedFirst);

        library.PrintBooks();
    }
}
