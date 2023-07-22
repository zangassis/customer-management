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

    //FAZER UMA ROTA PRA RETORNAR PELO PAIS
    public async Task<Customer> FindById(Guid id) =>
        await _db.QuerySingleOrDefaultAsync<Customer>("select * from customers where id = @Id", new { Id = id });

    public async Task<IEnumerable<Customer>> FindAll() =>
        await _db.QueryAsync<Customer>("select * from customers");
}