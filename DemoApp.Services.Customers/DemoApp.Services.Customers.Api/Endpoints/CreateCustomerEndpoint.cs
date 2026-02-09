namespace DemoApp.Services.Customers.Api.Endpoints;
using Models;

public class CreateCustomerEndpoint : IMinimalEndpoint
{
    public void MapEndpoint(WebApplication app) =>
        app.MapPost(
            "customer",
            async (
                [FromBody] CreateCustomerModel newCustomer
            ) =>
            {

            }
        );
}
