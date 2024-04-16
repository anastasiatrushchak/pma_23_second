using BookStore.Bll.Interfaces;
using BookStore.Common.Dtos;
using BookStore.Dal;
using BookStore.Dal.Models;

namespace BookStore.Bll.Implementations;

public class OrderItemRepository : IOrderItemRepository
{
    private BookstoreContext context;

    public OrderItemRepository(BookstoreContext context)
    {
        this.context = context;
    }
    
    public async Task<Orderitem?> CreateOrderItem(OrderItemDto orderItemModel)
    {
        Orderitem? orderItem = new Orderitem
        {
            Quantity = orderItemModel.Quantity,
            PricePerUnit = orderItemModel.PricePerUnit
        };
        await context.Orderitems.AddAsync(orderItem);
        return orderItem;
    }

    public async Task<Orderitem?> GetOrderItemById(int orderItemId)
    {
        return await context.Orderitems.FindAsync(orderItemId);
    }

    public async Task<Orderitem> UpdateOrderItem(int orderItemId, OrderItemDto orderItemModel)
    {
        var orderItem = await context.Orderitems.FindAsync(orderItemId);

        orderItem.Quantity = orderItemModel.Quantity;
        orderItem.PricePerUnit = orderItemModel.PricePerUnit;
        return orderItem;
    }

    public async Task DeleteOrderItem(int orderItemId)
    {
        var orderItem = await context.Orderitems.FindAsync(orderItemId);
        context.Orderitems.Remove(orderItem);
    }
}