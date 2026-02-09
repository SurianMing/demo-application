namespace DemoApp.Services.Customers.Domain.Dependencies;

public interface ICustomerData
{
    Task<Guid> CreateCustomer(
        string firstName,
        string surname
    );
}