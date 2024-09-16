using System.Threading.Tasks;
using System.Threading;
using System;

namespace Evently.Modules.Ticketing.PublicApi;

public interface ITicketingApi
{
    Task CreateCustomerAsync(
        Guid customerId,
        string email,
        string firstName,
        string lastName,
        CancellationToken cancellationToken = default);
}
