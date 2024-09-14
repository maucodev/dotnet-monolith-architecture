using Evently.Modules.Events.Application.Abstractions.Messaging;
using System;

namespace Evently.Modules.Events.Application.Categories.CreateCategory;

public sealed record CreateCategoryCommand(string Name) : ICommand<Guid>;
