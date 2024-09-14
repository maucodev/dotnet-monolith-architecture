using Evently.Modules.Events.Application.Abstractions.Clock;
using System;

namespace Evently.Modules.Events.Infrastructure.Clock;

internal sealed class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
