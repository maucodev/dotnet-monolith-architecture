using System;
using System.Threading;
using System.Threading.Tasks;
using Evently.Common.Domain;
using Evently.Modules.Users.Application.Users.GetUser;
using Evently.Modules.Users.PublicApi;
using MediatR;
using UserResponse = Evently.Modules.Users.PublicApi.UserResponse;

namespace Evently.Modules.Users.Infrastructure.PublicAPI;

internal sealed class UsersApi(ISender sender) : IUsersApi
{
    public async Task<UserResponse?> GetAsync(Guid userId, CancellationToken cancellationToken = default)
    {
        var query = new GetUserQuery(userId);

        Result<Application.Users.GetUser.UserResponse> result = await sender.Send(query, cancellationToken);

        if (result.IsFailure)
        {
            return null;
        }

        return new UserResponse(
            result.Value.Id,
            result.Value.Email,
            result.Value.FirstName,
            result.Value.LastName);
    }
}
