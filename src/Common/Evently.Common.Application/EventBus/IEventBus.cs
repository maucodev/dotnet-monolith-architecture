using System.Threading;
using System.Threading.Tasks;

namespace Evently.Common.Application.EventBus;

public interface IEventBus
{
    Task PublishAsync<T>(T integrationEvent, CancellationToken cancellationToken = default) where T : IIntegrationEvent;
}
