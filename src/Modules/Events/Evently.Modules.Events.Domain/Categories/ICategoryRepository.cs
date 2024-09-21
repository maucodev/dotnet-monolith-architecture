using System.Threading.Tasks;
using System.Threading;
using System;

namespace Evently.Modules.Events.Domain.Categories;

public interface ICategoryRepository
{
    Task<Category?> GetAsync(Guid id, CancellationToken cancellationToken = default);

    void Insert(Category category);
}
