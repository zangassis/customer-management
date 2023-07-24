using CustomerManagement.Models;

public interface ICustomerRepository
{
    Task<List<CustomerDto>> FindAll();
    Task<List<CustomersByCountryDto>> FindByCountry(string country);
}