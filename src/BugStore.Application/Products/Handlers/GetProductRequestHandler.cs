using BugStore.Application.Products.Requests;
using BugStore.Application.Products.Responses;
using BugStore.Domain.Interfaces.Repositories;
using MediatR;

namespace BugStore.Application.Products.Handlers
{
    public class GetProductRequestHandler(IProductRepository productRepository) : IRequestHandler<GetProductRequest, GetProductResponse>
    {
        public async Task<GetProductResponse> Handle(GetProductRequest request, CancellationToken cancellationToken)
        {
            var products = await productRepository.GetAllAsync(cancellationToken);

            return GetProductResponse.FromProduct(products);
        }
    }
}
