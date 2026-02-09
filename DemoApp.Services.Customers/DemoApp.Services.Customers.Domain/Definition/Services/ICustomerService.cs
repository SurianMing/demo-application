namespace DemoApp.Services.Customers.Domain.Definition.Services;

public interface ICustomerService
{
    Task<Guid> CreateCustomer(
        string firstName,
        string surname
    );
}