using BookStore.Common.Dtos;
using BookStore.Dal.Models;

namespace BookStore.Bll.Interfaces;

public interface IPublisherRepository
{
    Task<Publisher?> CreatePublisher(PublisherDto publisherModel);
    Task<List<Publisher?>> GetPublishers();

    Task<Publisher?> GetPublisherById(int publisherId);

    Task<Publisher?> UpdatePublisher(int publisherId, PublisherDto publisherModel);

    Task DeletePublisher(int publisherId);
}