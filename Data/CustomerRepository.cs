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

    public async Task<List<CustomerDto>> FindByCountry(string country) {
        string query = @"select 
                            c.id,
                            c.name, 
                            c.email,
                            a.id as addressId,
                            a.street, 
                            a.city, 
                            a.state, 
                            a.postalCode,
                            a.country
                        from customers c
                        inner join addresses a
                        on c.id = a.customerId
                        where a.country = @Country";

       var customersByCountry = await _db.QueryAsync<CustomerDto>(query, new { Country = country });
       return customersByCountry.ToList();
    }

    public async Task<List<CustomerDto>> FindAll() {
            string query = @"select 
                                c.id,
                                c.name, 
                                c.email,
                                a.id as addressId,
                                a.street, 
                                a.city, 
                                a.state, 
                                a.postalCode,
                                a.country
                            from customers c
                            inner join addresses a
                            on c.id = a.customerId";

            var customers = await _db.QueryAsync<CustomerDto>(query);
            return customers.ToList();
    }
}