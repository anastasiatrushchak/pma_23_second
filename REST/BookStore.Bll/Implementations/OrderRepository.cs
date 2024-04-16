using BookStore.Bll.Interfaces;
using BookStore.Common.Dtos;
using BookStore.Dal;
using BookStore.Dal.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Bll.Implementations;

public class OrderRepository : IOrderRepository
{
    private BookstoreContext context;

    public OrderRepository(BookstoreContext context)
    {
        this.context = context;
    }
    
    public async Task<Order?> CreateOrder(OrderDto orderModel)
    {
        Order? order = new Order
        {
            CustomerId = orderModel.CustomerId,
            TotalAmount = orderModel.TotalAmount
        };
        await context.Orders.AddAsync(order);
        return order;
    }
    
    public  async Task<List<Order?>> GetOrders()
    {
        return await context.Orders.ToListAsync();
    }

    public async Task<Order?> GetOrderById(int orderId)
    {
        return await context.Orders.FindAsync(orderId);
    }
    
    public async Task<Order?> UpdateOrder( int orderID, OrderDto orderModel)
    {
        var order = await GetOrderById(orderID);
        order.CustomerId = orderModel.CustomerId;
        order.TotalAmount = orderModel.TotalAmount;
        return order;
    }

    public async Task DeleteOrder(int orderId)
    {
        var order = await GetOrderById(orderId);
        context.Orders.Remove(order);
    }
}