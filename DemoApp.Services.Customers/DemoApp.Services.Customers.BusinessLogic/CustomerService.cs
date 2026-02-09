namespace DemoApp.Services.Customers.BusinessLogic;

internal class CustomerService(
    ICustomerData _customerData
) : ICustomerService
{
    public async Task<Guid> CreateCustomer(
        string firstName,
        string surname
    ) => await _customerData.CreateCustomer(
        firstName,
        surname
    );
}