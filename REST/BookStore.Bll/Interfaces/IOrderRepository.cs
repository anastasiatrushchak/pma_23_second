using BookStore.Common.Dtos;
using BookStore.Dal.Models;

namespace BookStore.Bll.Interfaces;

public interface IOrderRepository
{
    Task<Order?> CreateOrder(OrderDto orderModel); // need a datetime?
    Task<List<Order?>> GetOrders();
    Task<Order?> GetOrderById(int orderId);
    Task<Order?> UpdateOrder( int orderId, OrderDto orderModel);
    Task DeleteOrder(int orderId);
}