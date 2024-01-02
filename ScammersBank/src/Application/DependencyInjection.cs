using Application.Services;
using Domain.MapperProfiles;
using Microsoft.Extensions.DependencyInjection;

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
