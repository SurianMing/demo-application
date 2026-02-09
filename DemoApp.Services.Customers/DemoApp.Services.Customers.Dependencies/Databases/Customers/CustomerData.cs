namespace DemoApp.Services.Customers.Dependencies.Databases.Customers;

internal class CustomerData : ICustomerData
{
    public Task<Guid> CreateCustomer(string firstName, string surname)
    {
        throw new NotImplementedException();
    }
}