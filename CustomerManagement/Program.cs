using CustomerManagement.Data;
using CustomerManagement.Models;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<ICustomerRepository, CustomerRepository>();
builder.Services.Configure<ConnectionString>(builder.Configuration.GetSection("ConnectionStrings"));

var app = builder.Build();
app.UseHttpsRedirection();

app.MapGet("/v1/customers/by_country/{country}", async ([FromServices] ICustomerRepository repository, string country) =>
{
    var customers = await repository.FindByCountry(country);
    return customers.Any() ? Results.Ok(customers) : Results.NotFound("No records found");
})
.WithName("FindCustomersByCountry");

app.Run();
