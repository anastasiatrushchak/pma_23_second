using BookStore.Bll.Interfaces;
using BookStore.Common.Dtos;
using BookStore.Dal;
using BookStore.Dal.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Bll.Implementations;

public class PublisherRepository : IPublisherRepository
{
    private BookstoreContext context;

    public PublisherRepository(BookstoreContext context)
    {
        this.context = context;
    }
    
    public async Task<Publisher?> CreatePublisher(PublisherDto publisherModel)
    {
        Publisher? publisher = new Publisher
        {
            PublisherName = publisherModel.PublisherName
        };
        await context.Publishers.AddAsync(publisher);
        return publisher;
    }

    public async Task<List<Publisher?>> GetPublishers()
    {
        return await context.Publishers.ToListAsync();
    }

    public async Task<Publisher?> GetPublisherById(int publisherId)
    {
        return await context.Publishers.FindAsync(publisherId);
    }

    public async Task<Publisher?> UpdatePublisher(int publisherId, PublisherDto publisherModel)
    {
        var publisher = await GetPublisherById(publisherId);
        publisher.PublisherName = publisherModel.PublisherName;
        return publisher;
    }
    
    public async Task DeletePublisher(int publisherId)
    {
        var publisher = await GetPublisherById(publisherId);
        context.Publishers.Remove(publisher);
    }
}