using RestSharp;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IRestClient, RestClient>();
var app = builder.Build();

app.MapGet("/v1/get_customersc_by_country/{country}", async ([FromServices] IRestClient restClient, string country) =>
{
    var request = new RestRequest($"http://localhost:5000/v1/customers/by_country/{country}", Method.Get);
    var response = await restClient.ExecuteAsync(request);

    if (response.IsSuccessful)
        return Results.Ok(response.Content);
    else
        return Results.BadRequest($"Error: {response.StatusCode}");
});

app.Run();
