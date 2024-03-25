using Observer.Observer;
using System;
using System.Collections.Generic;

namespace Observer.Subject
{
    public class Book : IBook
    {
        public string title;
        public string author;
        public int year;
        private double price;
        public string Title 
        {
            get => title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Title cannot be null or empty.");
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
                    throw new ArgumentException("Author cannot be null or empty.");
                }
                author = value;
            }
        }
        public int Year
        {
            get => year;
            set
            {
                if (value < 0 || value > 2025)
                {
                    throw new ArgumentOutOfRangeException("Year cannot be negative or bigger than 2024.");
                }
                year = value;
            }
        }
        
        public double Price 
        {
            get => price;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative.");
                }

                double oldPrice = price;
                price = value;
                Notify(oldPrice, price);
            }
        }
        private List<IPublisher> publishers = new List<IPublisher>();
        public void Attach(IPublisher publisher)
        {
            publishers.Add(publisher);
            Console.WriteLine("Observer is attached to subject!");
        }
        public void Detach(IPublisher publisher)
        {
            publishers.Remove(publisher);
            Console.WriteLine("Observer is dettached to subject!");
        }

        public void Notify(double oldPrice, double newPrice)
        {
            Console.WriteLine($"Old price:{oldPrice}, new price: {newPrice}");
            foreach (IPublisher publisher in publishers)
            {
                publisher.Update(this);
            }
        }

        public override string ToString()
        {
            return $"Title: {Title}, author: {Author}, year: {Year}, price: {Price}";
        }
    }
}
