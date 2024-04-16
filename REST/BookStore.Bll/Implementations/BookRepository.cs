using BookStore.Bll.Interfaces;
using BookStore.Common.Dtos;
using BookStore.Dal;
using BookStore.Dal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BookStore.Bll.Implementations;

public class BookRepository : IBookRepository 
{
    private BookstoreContext context;

    public BookRepository(BookstoreContext context)
    {
        this.context = context;
    }
    
    public async Task<Book?> CreateBook(BookDto bookModel)
    {
        Book? book = new Book //need to transfers  Genre and Publisher IDs?
        {
            Title = bookModel.Title,
            Isbn = bookModel.Isbn,
            Price = bookModel.Price,
            StockQuantity = bookModel.StockQuantity,
        };
         await context.Books.AddAsync(book);
         return book;
    }

    public async Task<List<Book?>> GetBooks()
    {
        return await context.Books.ToListAsync();
    }

    public async Task<Book?> GetBookById(int bookId)
    {
        return await context.Books.FindAsync(bookId);
    }

    public async Task<Book> UpdateBook(int bookId, BookDto bookModel)
    {
        var book = await context.Books.FindAsync(bookId);
        book.Title = bookModel.Title;
        book.Isbn = bookModel.Isbn;
        book.Price = bookModel.Price;
        book.StockQuantity = bookModel.StockQuantity;
        return book;
    }

    public async Task DeleteBook(int bookId)
    {
        var book =  await GetBookById(bookId);
        context.Books.Remove(book);
    }
}