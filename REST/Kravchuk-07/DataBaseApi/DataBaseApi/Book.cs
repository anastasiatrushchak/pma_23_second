namespace DataBaseApi
{
    public class Book
    {
        public int book_id { get; set;}
        public string? book_name { get; set; }
        public string? author { get; set; }

        public int year_of_publishing { get; set;}
        public BookInShop? Book_in_shop { get; set;}
        

    }
}
