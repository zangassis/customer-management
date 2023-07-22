using CustomerManagement.Models;

public interface ICustomerRepository
{
    Task<IEnumerable<Customer>> FindAll();
    Task<Customer> FindById(Guid id);
}