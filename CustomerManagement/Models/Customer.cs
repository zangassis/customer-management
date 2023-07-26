namespace CustomerManagement.Models;

public class Customer
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public Address Address { get; set; }

    public Customer(Guid id, string name, string email, Address address)
    {
        Id = id;
        Name = name;
        Email = email;
        Address = address;
    }
}
