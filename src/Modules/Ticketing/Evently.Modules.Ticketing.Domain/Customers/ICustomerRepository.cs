using System.Threading.Tasks;
using System.Threading;
using System;

namespace Evently.Modules.Ticketing.Domain.Customers;

public interface ICustomerRepository
{
    Task<Customer?> GetAsync(Guid id, CancellationToken cancellationToken = default);

    void Insert(Customer customer);
}
