using Business.Factories;
using Business.Models;

namespace Business.Tests.Factories;

public class ContactFactory_Tests
{
    // This test checks if the CreateNewContact method returns a new instance of the Contact class when called
    // And checks if the result is (not null) and is of type Contact
    [Fact]
    public void CreateNewContact_ShouldReturnContact()
    {
        // Arrange

        // Act
        var result = ContactFactory.CreateNewContact();

        // Assert
        // Check if the result is not null and is of type Contact
        Assert.NotNull(result);
        Assert.IsType<Contact>(result);
    }
}
