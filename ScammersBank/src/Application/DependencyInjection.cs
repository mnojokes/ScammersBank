using Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<AccountService>();
        services.AddScoped<UserService>();

        // TODO: add remaining services
    }
}
