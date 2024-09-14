using Evently.Modules.Events.Application.Abstractions.Messaging;
using System;

namespace Evently.Modules.Events.Application.Categories.GetCategory;

public sealed record GetCategoryQuery(Guid CategoryId) : IQuery<CategoryResponse>;
