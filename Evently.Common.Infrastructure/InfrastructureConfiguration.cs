using Evently.Common.Application.Clock;
using Evently.Common.Application.Data;
using Evently.Common.Infrastructure.Clock;
using Evently.Common.Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Npgsql;

namespace Evently.Common.Infrastructure;

public static class InfrastructureConfiguration
{
    public static void AddInfrastructure(this IServiceCollection services, string dbConnectionString)
    {
        NpgsqlDataSource dataSource = new NpgsqlDataSourceBuilder(dbConnectionString).Build();

        services.TryAddSingleton(dataSource);

        services.AddScoped<IDbConnectionFactory, DbConnectionFactory>();

        services.TryAddSingleton<IDateTimeProvider, DateTimeProvider>();
    }
}
