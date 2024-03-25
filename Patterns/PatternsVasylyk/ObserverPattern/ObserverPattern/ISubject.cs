namespace MyNamespace;


    interface ISubject
    {
        void Attach(IObserver observer);
        void Notify();
        void Detach(IObserver observer);
    }

