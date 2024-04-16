using System;
using System.Collections.Generic;

namespace BookStore.Dal.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; }

    public string Isbn { get; set; }

    public int? PublisherId { get; set; }

    public int? GenreId { get; set; }

    public DateOnly? PublicationDate { get; set; }

    public decimal? Price { get; set; }

    public int? StockQuantity { get; set; }

    public virtual Genre Genre { get; set; }

    public virtual ICollection<Orderitem> Orderitems { get; set; } = new List<Orderitem>();

    public virtual Publisher Publisher { get; set; }

    public virtual ICollection<Author> Authors { get; set; } = new List<Author>();
}
