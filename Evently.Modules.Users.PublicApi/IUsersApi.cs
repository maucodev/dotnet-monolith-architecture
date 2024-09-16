using System;
using System.Threading;
using System.Threading.Tasks;

namespace Evently.Modules.Users.PublicApi;

public interface IUsersApi
{
    Task<UserResponse?> GetAsync(Guid userId, CancellationToken cancellationToken = default);
}
