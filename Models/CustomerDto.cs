namespace CustomerManagement.Models;

public class CustomerDto
{
    public CustomerDto(Guid id, string name, string email, Guid addressId, string street, string city, string state, string postalCode, string country)
    {
        Id = id;
        Name = name;
        Email = email;
        this.addressId = addressId;
        Street = street;
        City = city;
        State = state;
        PostalCode = postalCode;
        Country = country;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public Guid addressId { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
}
