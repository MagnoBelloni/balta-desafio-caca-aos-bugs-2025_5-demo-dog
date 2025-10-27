using BugStore.Domain.Entities;

namespace BugStore.Application.Products.Responses;

public class GetProductByIdResponse
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Slug { get; set; }
    public decimal Price { get; set; }

    public static GetProductByIdResponse FromProduct(Product product)
    {
        return new GetProductByIdResponse()
        {
            Id = product.Id,
            Title = product.Title,
            Description = product.Description,
            Slug = product.Slug,
            Price = product.Price
        };
    }
}