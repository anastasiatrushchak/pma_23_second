using BookStore.Common.Dtos;
using BookStore.Dal.Models;

namespace BookStore.Bll.Interfaces;

public interface IOrderItemRepository
{
    Task<Orderitem?> CreateOrderItem(OrderItemDto orderItemModel); // need instance Order and Book?
    Task<Orderitem?> GetOrderItemById(int orderItemId);
    Task<Orderitem> UpdateOrderItem( int orderItemId, OrderItemDto orderItemModel);
    Task DeleteOrderItem(int orderItemId);
}