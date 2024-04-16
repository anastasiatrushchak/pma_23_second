using BookStore.Dal.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Dal;

public partial class BookstoreContext : DbContext
{
    public BookstoreContext()
    {
    }

    public BookstoreContext(DbContextOptions<BookstoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author?> Authors { get; set; }

    public virtual DbSet<Book?> Books { get; set; }

    public virtual DbSet<Customer?> Customers { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Order?> Orders { get; set; }

    public virtual DbSet<Orderitem?> Orderitems { get; set; }

    public virtual DbSet<Publisher?> Publishers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;port=3306;database=bookstore;uid=admin;pwd=x6D6Yt654i91488", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.3.0-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.AuthorId).HasName("PRIMARY");

            entity.ToTable("author");

            entity.Property(e => e.AuthorId).HasColumnName("author_id");
            entity.Property(e => e.AuthorName)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("author_name");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PRIMARY");

            entity.ToTable("book");

            entity.HasIndex(e => e.GenreId, "genre_id");

            entity.HasIndex(e => e.PublisherId, "publisher_id");

            entity.Property(e => e.BookId).HasColumnName("book_id");
            entity.Property(e => e.GenreId).HasColumnName("genre_id");
            entity.Property(e => e.Isbn)
                .HasMaxLength(20)
                .HasColumnName("isbn");
            entity.Property(e => e.Price)
                .HasPrecision(10, 2)
                .HasColumnName("price");
            entity.Property(e => e.PublicationDate).HasColumnName("publication_date");
            entity.Property(e => e.PublisherId).HasColumnName("publisher_id");
            entity.Property(e => e.StockQuantity).HasColumnName("stock_quantity");
            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("title");

            entity.HasOne(d => d.Genre).WithMany(p => p.Books)
                .HasForeignKey(d => d.GenreId)
                .HasConstraintName("book_ibfk_2");

            entity.HasOne(d => d.Publisher).WithMany(p => p.Books)
                .HasForeignKey(d => d.PublisherId)
                .HasConstraintName("book_ibfk_1");

            entity.HasMany(d => d.Authors).WithMany(p => p.Books)
                .UsingEntity<Dictionary<string, object>>(
                    "Bookauthor",
                    r => r.HasOne<Author>().WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("bookauthor_ibfk_2"),
                    l => l.HasOne<Book>().WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("bookauthor_ibfk_1"),
                    j =>
                    {
                        j.HasKey("BookId", "AuthorId")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("bookauthor");
                        j.HasIndex(new[] { "AuthorId" }, "author_id");
                        j.IndexerProperty<int>("BookId").HasColumnName("book_id");
                        j.IndexerProperty<int>("AuthorId").HasColumnName("author_id");
                    });
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PRIMARY");

            entity.ToTable("customer");

            entity.HasIndex(e => e.Email, "email").IsUnique();

            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .HasColumnName("phone_number");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.GenreId).HasName("PRIMARY");

            entity.ToTable("genre");

            entity.Property(e => e.GenreId).HasColumnName("genre_id");
            entity.Property(e => e.GenreName)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("genre_name");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PRIMARY");

            entity.ToTable("order");

            entity.HasIndex(e => e.CustomerId, "customer_id");

            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.OrderDate)
                .HasColumnType("datetime")
                .HasColumnName("order_date");
            entity.Property(e => e.TotalAmount)
                .HasPrecision(10, 2)
                .HasColumnName("total_amount");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("order_ibfk_1");
        });

        modelBuilder.Entity<Orderitem>(entity =>
        {
            entity.HasKey(e => e.OrderItemId).HasName("PRIMARY");

            entity.ToTable("orderitem");

            entity.HasIndex(e => e.BookId, "book_id");

            entity.HasIndex(e => e.OrderId, "order_id");

            entity.Property(e => e.OrderItemId).HasColumnName("order_item_id");
            entity.Property(e => e.BookId).HasColumnName("book_id");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.PricePerUnit)
                .HasPrecision(10, 2)
                .HasColumnName("price_per_unit");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.Book).WithMany(p => p.Orderitems)
                .HasForeignKey(d => d.BookId)
                .HasConstraintName("orderitem_ibfk_2");

            entity.HasOne(d => d.Order).WithMany(p => p.Orderitems)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("orderitem_ibfk_1");
        });

        modelBuilder.Entity<Publisher>(entity =>
        {
            entity.HasKey(e => e.PublisherId).HasName("PRIMARY");

            entity.ToTable("publisher");

            entity.Property(e => e.PublisherId).HasColumnName("publisher_id");
            entity.Property(e => e.PublisherName)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("publisher_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
