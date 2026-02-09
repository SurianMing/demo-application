namespace DemoApp.Services.Customers.BusinessLogic;
using Dependencies;

public static class DependencyInjection
{
    public static IServiceCollection InitialiseBusinessLogic(
        this IServiceCollection services
    )
    {
        services.AddScoped<ICustomerService, CustomerService>();

        services.InitialiseDependencies();

        return services;
    }
}