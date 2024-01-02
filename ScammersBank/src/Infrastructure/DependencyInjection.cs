namespace Infrastructure;

using DbUp;
using Domain.Interfaces;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using System.Data;
using System.Reflection;

public static class DependencyInjection
{
    public static void AddInfrastructure(this IServiceCollection services, string connection)
    {
        EnsureDatabase.For.PostgresqlDatabase(connection);
        var result = DeployChanges.To
            .PostgresqlDatabase(connection)
            .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
            .LogToConsole()
            .Build()
            .PerformUpgrade();

        if (!result.Successful)
        {
            throw new InvalidOperationException("Error initializing Postgre database");
        }

        services.AddScoped<IDbConnection>(sp => new NpgsqlConnection(connection));

        services.AddScoped<IAccountRepository, AccountRepository>();
        services.AddScoped<ITransactionRepository, TransactionRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
    }
}
