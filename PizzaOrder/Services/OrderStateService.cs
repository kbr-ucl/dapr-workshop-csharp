using PizzaOrder.Models;
using System.Text.Json;

namespace PizzaOrder.Services;

public interface IOrderStateService
{
    Task<Order> UpdateOrderStateAsync(Order order);
    Task<Order?> GetOrderAsync(string orderId);
    Task<string?> DeleteOrderAsync(string orderId);
}

public class OrderStateService : IOrderStateService
{
    private readonly ILogger<OrderStateService> _logger;

    public OrderStateService(ILogger<OrderStateService> logger)
{
    _logger = logger;
}

    public async Task<Order> UpdateOrderStateAsync(Order order)
    {
        // TODO: Implement this method

        return order;
    }

    public async Task<Order?> GetOrderAsync(string orderId)
    {
        // TODO: Implement this method

        return null;
    }

    public async Task<string> DeleteOrderAsync(string orderId)
    {
        // TODO: Implement this method
        
        return orderId;
    }

    private Order MergeOrderStates(Order existing, Order update)
    {
        // Preserve important fields from existing state
        update.Customer = update.Customer ?? existing.Customer;
        update.PizzaType = update.PizzaType ?? existing.PizzaType;
        update.Size = update.Size ?? existing.Size;
        
        return update;
    }
}