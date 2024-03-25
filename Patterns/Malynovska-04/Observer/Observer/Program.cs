using Observer.Subject;
using Observer.Observer;


namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book {Title = "The city of girls", Author = "Elizabeth Gilbert", Price = 250, Year = 2021 };
            Publisher publisher = new Publisher { Name = "FascinatingBooks" };
            Publisher publisher2 = new Publisher { Name = "CriticsIvents" };
            book.Attach(publisher);
            book.Attach(publisher2);
            book.Price = 300;

            Book book2 = new Book { Title = "Eat.Pray.Love", Author = "Elizabeth Gilbert", Price = 199, Year = 2017 };
            book2.Attach(publisher);
            book2.Price = 230;
           
            
        }
    }
}
