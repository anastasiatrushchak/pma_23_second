using BookStore.Dal.Models;

namespace BookStore.Common.Dtos;

public class OrderDto
{
    public int OrderId { get; set; }
    public int? CustomerId { get; set; }
   
    public decimal? TotalAmount { get; set; }
}