using BugStore.Domain.Entities;
using FluentAssertions;

namespace BugStore.Domain.Tests.Entities
{
    public class OrderLineTests
    {
        [Fact]
        public void Total_ShouldCalculateBasedOnQuantity()
        {
            var quantity = 5;
            var price = 5.99M;
            var product = new Product()
            {
                Price = price
            };

            var orderLine = new OrderLine(quantity, Guid.NewGuid(), product);
            orderLine.Total.Should().Be(quantity * price);
        }
    }
}
