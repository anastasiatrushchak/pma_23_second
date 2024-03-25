using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class BasicBook : IBook
    {
        private string title;
        private string author;

        public BasicBook(string title_of_book, string author_of_book)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(title_of_book))
                {
                    throw new ArgumentException("Title cannot be null or whitespace.", nameof(title_of_book));
                }

                if (string.IsNullOrWhiteSpace(author_of_book))
                {
                    throw new ArgumentException("Author cannot be null or whitespace.", nameof(author_of_book));
                }

                title = title_of_book;
                author = author_of_book;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }

        public string GetTitle()
        {
            return title;
        }

        public string GetAuthor()
        {
            return author;
        }
    }
}
