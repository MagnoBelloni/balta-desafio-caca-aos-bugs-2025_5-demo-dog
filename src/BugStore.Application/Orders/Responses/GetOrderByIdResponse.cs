using BugStore.Domain.Entities;

namespace BugStore.Application.Orders.Responses;

public class GetOrderByIdResponse
{
    public Customer Customer { get; private set; }
    public List<OrderLine> Lines { get; private set; } = [];
    public decimal TotalAmount { get; private set; }

    public static GetOrderByIdResponse FromOrder(Order order)
    {
        return new GetOrderByIdResponse
        {
            Customer = order.Customer,
            Lines = order.Lines,
            TotalAmount = order.TotalAmount
        };
    }
}