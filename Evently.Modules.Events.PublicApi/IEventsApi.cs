using System;
using System.Threading;
using System.Threading.Tasks;

namespace Evently.Modules.Events.PublicApi;

public interface IEventsApi
{
    Task<TicketTypeResponse?> GetTicketTypeAsync(Guid ticketTypeId, CancellationToken cancellationToken = default);
}
