using BugStore.Domain.Entities;
using BugStore.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BugStore.Infrastructure.Data.Repositories
{
    public class OrderRepository(AppDbContext context) : BaseRepository<Order>(context), IOrderRepository
    {
        public async Task<Order?> GetOrderByIdAsNoTrackingWithIncludesAsync(Guid id, CancellationToken cancellationToken)
            => await _dbSet
                .AsNoTracking()
                .Include(x => x.Customer)
                .Include(x => x.Lines)
                .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }
}
