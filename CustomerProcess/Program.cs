using RestSharp;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CustomerProcess.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IRestClient, RestClient>();
var app = builder.Build();

app.MapGet("/v1/get_customers_by_country/{country}", async ([FromServices] IRestClient restClient, string country) =>
{
    var request = new RestRequest($"http://localhost:5000/v1/customers/by_country/{country}", Method.Get);
    var response = await restClient.ExecuteAsync(request);
    var customers = JsonConvert.DeserializeObject<List<Customer>>(response.Content);

    if (response.IsSuccessful)
        return Results.Ok(customers);
    else
        return Results.BadRequest($"Error: {response.StatusCode}");
});

app.Run();
