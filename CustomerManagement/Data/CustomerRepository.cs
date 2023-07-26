using System.Data;
using CustomerManagement.Models;
using Dapper;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;

namespace CustomerManagement.Data;

public class CustomerRepository : ICustomerRepository
{
    private readonly IDbConnection _db;
    public CustomerRepository(IOptions<ConnectionString> connectionString)
    {
        _db = new MySqlConnection(connectionString.Value.ProjectConnection);
    }

    public async Task<List<CustomersByCountryDto>> FindByCountry(string country)
    {
        string query = @"select 
                            c.id,
                            c.name,
                            c.email
                        from customers c
                        inner join addresses a
                        on c.id = a.customerId
                        where a.country = @Country";

        var customersByCountry = await _db.QueryAsync<CustomersByCountryDto>(query, new { Country = country });
        return customersByCountry.ToList();
    }
}