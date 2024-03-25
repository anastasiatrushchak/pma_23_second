using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    public class Book
    {
        private string title;
        private string author;
        private int year;

        public string Title
        {
            get => title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Enter the title!");
                }
                title = value;
            }
        }

        public string Author
        {
            get => author;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Enter the author's name!");
                }
                author = value;
            }
        }

        public int Year
        {
            get => year;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Year cannot be negative.");
                }
                else if (value > 2024)
                {
                    throw new ArgumentException("Year cannot be bigger than current.");
                }
                year = value;
            }
        }

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, Year: {Year}";
        }
    }
}
