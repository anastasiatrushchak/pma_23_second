using BookStore.Common.Dtos;
using BookStore.Dal.Models;

namespace BookStore.Bll.Interfaces;

public interface IAuthorRepository
{
    Task<Author> CreateAuthor(AuthorDto authorModel);

    Task<List<Author?>> GetAuthors();

    Task<List<Author?>> GetAuthorsByBook(string bookName);

    Task<Author?> GetAuthorById(int authorId);

    Task<Author> UpdateAuthor(int authorId, AuthorDto authorModel);

    Task DeleteAuthor(int authorId);
}