namespace ConsoleApplication7
{
    public class Request
    {
        public RequestType Type { get; }

        public Request(RequestType type)
        {
            Type = type;
        }
    }

    public enum RequestType
    {
        Type1,
        Type2
    }
}