namespace Catch_Up_Platform.net.Shared.Domain.Repositories;

public interface IUnitOfWork
{
   Task CompleteAsync(CancellationToken cancellationToken = default);
}