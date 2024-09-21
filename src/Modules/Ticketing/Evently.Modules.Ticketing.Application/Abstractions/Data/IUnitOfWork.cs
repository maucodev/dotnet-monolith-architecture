using System.Data.Common;
using System.Threading.Tasks;
using System.Threading;

namespace Evently.Modules.Ticketing.Application.Abstractions.Data;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    Task<DbTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default);
}
