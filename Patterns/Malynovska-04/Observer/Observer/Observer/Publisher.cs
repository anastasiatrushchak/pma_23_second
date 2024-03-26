using Observer.Subject;
using System;

namespace Observer.Observer
{
    public class Publisher : IPublisher
    {
        public string Name { get; set; }
        public void Update(IBook book)
        {
            Console.WriteLine($"Dear readers, {Name} announced that there is updated info about one book, more details below:");
            Console.WriteLine(book + "\n");
        }
    }
}
