namespace DemoApp.Services.Customers.Dependencies;
using Databases.Customers;
using Databases.Customers.Context;
using Microsoft.EntityFrameworkCore;

public static class DependencyInjection
{
    public static IServiceCollection InitialiseDependencies(
        this IServiceCollection services
    )
    {
        services.AddScoped<ICustomerData, CustomerData>();

        services.AddDbContext<CustomerContext>(options =>
        {
            options.UseSqlServer("conn-string");
        });

        return services;
    }
}