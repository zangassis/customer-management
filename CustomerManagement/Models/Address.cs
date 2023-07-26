namespace CustomerManagement.Models;

public class Address
{
    public Guid Id { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public Guid CustomerId { get; set; }

    public Address(Guid id, string street, string city, string state, string postalCode, string country, Guid customerId)
    {
        Street = street;
        City = city;
        State = state;
        PostalCode = postalCode;
        Country = country;
        CustomerId = customerId;
    }
}