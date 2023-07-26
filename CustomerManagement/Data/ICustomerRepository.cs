using CustomerManagement.Models;

public interface ICustomerRepository
{
    Task<List<CustomersByCountryDto>> FindByCountry(string country);
}