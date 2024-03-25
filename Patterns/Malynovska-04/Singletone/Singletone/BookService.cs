using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    public class BookService
    {
        private static BookService _instance; 
        private List<Book> books;

        private BookService()
        {
            books = new List<Book>();
        }

        public static BookService getInstance()
        {
            if(_instance == null)
            {
                _instance = new BookService();  
            }
            return _instance;
        }

        public void AddBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book), "Book cannot be null.");
            }
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book), "Book cannot be null.");
            }
            books.Remove(book);
        }

        public void PrintBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
