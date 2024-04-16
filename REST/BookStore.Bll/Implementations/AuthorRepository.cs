using BookStore.Bll.Interfaces;
using BookStore.Common.Dtos;
using BookStore.Dal;
using BookStore.Dal.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Bll.Implementations;

public class AuthorRepository : IAuthorRepository
{
    private BookstoreContext context;

    public AuthorRepository(BookstoreContext context)
    {
        this.context = context;
    }
    
    public async Task<Author> CreateAuthor(AuthorDto authorModel)
    {
        Author author = new Author
        {
            AuthorName = authorModel.AuthorName,
        };
        await context.Authors.AddAsync(author);
        return author;
    }

    public async Task<List<Author?>> GetAuthors()
    {
        return await context.Authors.ToListAsync();
    }

    public async Task<List<Author?>> GetAuthorsByBook(string bookName)
    {
        IQueryable<Author?> authors = context.Authors.AsQueryable();
        authors = authors.Include(x => x.Books);
        authors = authors.Where(x => x.Books.Any(y => y.Title.Contains(bookName)));

        return await authors.ToListAsync();
    }

    public Task<Author?> GetAuthorById(int authorId)
    {
         return Task.FromResult(context.Authors.AsNoTracking().First(x => x.AuthorId == authorId));
    }
    
    public async Task<Author> UpdateAuthor( int authorId, AuthorDto authorModel)
    {
        var author = context.Authors.AsNoTracking().First(x => x.AuthorId == authorId);
        author.AuthorName = authorModel.AuthorName;
        context.Update(author);
        context.SaveChanges();
        return author;
    }

    public async Task DeleteAuthor(int authorId)
    {
        var author = await GetAuthorById(authorId);
        context.Authors.Remove(author);
        context.SaveChanges();
    }
}