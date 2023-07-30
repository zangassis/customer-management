using CustomerProcess.Models;
namespace CustomerProcess.Services;

public class CustomerService
{
    public string ValidateCustomer(Customer customer)
    {
        string errorMessage = string.Empty;
        if (string.IsNullOrEmpty(customer.Name))
            errorMessage += "Customer name cannot be null or blank";

        if (string.IsNullOrEmpty(customer.Email))
            errorMessage += "Customer email cannot be null or blank";

        return errorMessage;
    }
}
