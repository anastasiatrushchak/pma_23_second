using BookStore.Common.Dtos;
using BookStore.Dal.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BookStore.Bll.Interfaces;

public interface IBookRepository
{   
    Task<Book?> CreateBook(BookDto bookModel);

    Task<List<Book?>> GetBooks();

    Task<Book?> GetBookById(int bookId);

    Task<Book> UpdateBook(int bookId, BookDto bookModel);

    Task DeleteBook(int bookId);
}
