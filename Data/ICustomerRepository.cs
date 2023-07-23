using CustomerManagement.Models;

public interface ICustomerRepository
{
    Task<List<CustomerDto>> FindAll();
    Task<List<CustomerDto>> FindByCountry(string country);
}