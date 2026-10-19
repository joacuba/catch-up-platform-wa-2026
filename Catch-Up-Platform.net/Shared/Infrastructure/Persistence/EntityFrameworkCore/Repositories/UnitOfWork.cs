using Catch_Up_Platform.net.Shared.Domain.Repositories;
using Catch_Up_Platform.net.Shared.Infrastructure.Persistence.EntityFrameworkCore.Configuration;

namespace Catch_Up_Platform.net.Shared.Infrastructure.Persistence.EntityFrameworkCore.Repositories;

public class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    public async Task CompleteAsync(CancellationToken cancellationToken = default)
    {
        await context.SaveChangesAsync(cancellationToken);
    }
}