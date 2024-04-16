using BookStore.Dal.Models;

namespace BookStore.Common.Dtos;

public class BookDto
{
    public string Title { get; set; }

    public string Isbn { get; set; }
    
    public decimal? Price { get; set; }

    public int? StockQuantity { get; set; }
}