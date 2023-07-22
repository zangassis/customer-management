using CustomerManagement.Data;
using CustomerManagement.Models;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IRestClient, RestClient>();
builder.Services.AddTransient<ICustomerRepository, CustomerRepository>();

builder.Services.Configure<ConnectionString>(builder.Configuration.GetSection("ConnectionStrings"));

var app = builder.Build();

app.MapGet("/v1/customers", async ([FromServices] ICustomerRepository repository) =>
{
    var customers = await repository.FindAll();
    return customers.Any() ? Results.Ok(customers) : Results.NotFound("No records found");
})
.WithName("FindAllCustomers");


//TODO: EXCLUIR
app.MapGet("/v1/customers/CAT", async ([FromServices] IRestClient restClient) =>
{
    var request = new RestRequest("https://catfact.ninja/fact", Method.Get);
    var response = await restClient.ExecuteAsync(request);

    if (response.IsSuccessful)
        return Results.Ok(response.Content);
    else
        return Results.BadRequest($"Error: {response.StatusCode}");
});

app.Run();