namespace Catch_Up_Platform.net.Shared.Domain.Repositories;

public class IUnitOfWork
{
   Task CompleteAsync(CancellationToken cancellationToken = default);
}