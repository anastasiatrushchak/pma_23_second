using BookStore.Dal.Models;

namespace BookStore.Bll.Interfaces;

public interface IGenreRepository
{
    Task<List<Genre>> GetGenres();
}