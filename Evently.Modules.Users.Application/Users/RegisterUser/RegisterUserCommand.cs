using Evently.Common.Application.Messaging;
using System;

namespace Evently.Modules.Users.Application.Users.RegisterUser;

public sealed record RegisterUserCommand(
    string Email, 
    string Password, 
    string FirstName, 
    string LastName)
    : ICommand<Guid>;
