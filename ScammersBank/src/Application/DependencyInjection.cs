using Application.Services;
using Microsoft.Extensions.DependencyInjection;
using Domain.MapperProfiles;

namespace Application;

public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<AccountService>();
        services.AddScoped<TransactionService>();
        services.AddScoped<UserService>();
        services.AddAutoMapper(typeof(UserProfile));
    }
}
