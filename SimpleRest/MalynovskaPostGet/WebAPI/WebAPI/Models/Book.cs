using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Book
    {
        private string title;
        private int year;
        private string author;
        public string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Title cannot be null or empty");
                }
                title = value;
            }
        }
        public string Author
        {
            get { return author; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Author cannot be null or empty");
                }
                author = value;
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1800 || value > 2024 )
                {
                    throw new ArgumentOutOfRangeException("Year must be between 1800 and 2024");
                }
                year = value;
            }
        }


        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, Year: {Year}";
        }
    }
}
