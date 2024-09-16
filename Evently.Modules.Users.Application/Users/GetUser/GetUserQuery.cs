using Evently.Common.Application.Messaging;
using System;

namespace Evently.Modules.Users.Application.Users.GetUser;

public sealed record GetUserQuery(Guid UserId) : IQuery<UserResponse>;
