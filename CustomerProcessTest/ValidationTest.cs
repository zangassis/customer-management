using CustomerProcess.Models;
using CustomerProcess.Services;

namespace CustomerProcessTest
{
    public class ValidationTest
    {
        [Fact]
        public void ValidateCustomerValid()
        {
            //Arrange
            var customer = new Customer(Guid.NewGuid(), "John", "john@mail.com");
            var service = new CustomerService();

            //Act
            string errorMessage = service.ValidateCustomer(customer);

            //Assert
            Assert.Empty(errorMessage);
        }

        [Fact]
        public void ValidateCustomerInValid()
        {
            //Arrange
            var customer = new Customer(Guid.NewGuid(), string.Empty, string.Empty);
            var service = new CustomerService();

            //Act
            string errorMessage = service.ValidateCustomer(customer);

            //Assert
            Assert.NotEmpty(errorMessage);
            Assert.Contains("Customer name cannot be null or blank", errorMessage);
            Assert.Contains("Customer email cannot be null or blank", errorMessage);
        }
    }
}