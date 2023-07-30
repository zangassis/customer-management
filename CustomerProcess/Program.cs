using RestSharp;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CustomerProcess.Models;
using Humanizer;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IRestClient, RestClient>();
var app = builder.Build();

//1 - Formatting numbers
int number = 1000;
string formattedNumber = number.ToWords();
Console.WriteLine(formattedNumber);

//2 - Formatting dates
DateTime date = DateTime.Now;
string humanizedDate = date.Humanize();
Console.WriteLine(humanizedDate);

DateTime pastDate = DateTime.Now.AddHours(-2);
string humanizedPastDate = pastDate.Humanize();
Console.WriteLine(humanizedPastDate);

DateTime futureDate = DateTime.Now.AddDays(1);
string humanizedFutureDate = futureDate.Humanize();
Console.WriteLine(humanizedFutureDate);

//3 - Formatting timespan
var secondSize = TimeSpan.FromMilliseconds(2).Humanize();
Console.WriteLine(secondSize);

var daySize = TimeSpan.FromDays(1).Humanize();
Console.WriteLine(daySize);

var weekSize = TimeSpan.FromDays(16).Humanize();
Console.WriteLine(weekSize);

//4 - Formatting data size
long sizeInBytes = 1024;
var KBSize = sizeInBytes.Bytes().Humanize();
Console.WriteLine(KBSize);

sizeInBytes = 2097152;
var MBSize = sizeInBytes.Bytes().Humanize();
Console.WriteLine(MBSize);

sizeInBytes = 3221225472;
var GBSize = sizeInBytes.Bytes().Humanize();
Console.WriteLine(GBSize);

sizeInBytes = 5497558138880;
string TBBytes = sizeInBytes.Bytes().Humanize();
Console.WriteLine(TBBytes);

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
