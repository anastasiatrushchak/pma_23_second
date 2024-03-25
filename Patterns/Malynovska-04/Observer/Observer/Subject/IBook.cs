using Observer.Observer;

namespace Observer.Subject
{
    public interface IBook
    {
        void Attach(IPublisher publisher);
        void Detach(IPublisher publisher);
        void Notify(double oldPrice, double newPrice);
        
    }
}
