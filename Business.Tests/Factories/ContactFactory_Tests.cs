using Business.Factories;
using Business.Models;

namespace Business.Tests.Factories;

public class ContactFactory_Tests
{
    [Fact]
    public void CreateNewContact_ShouldReturnContact()
    {
        // Arrange

        // Act
        var result = ContactFactory.CreateNewContact();

        // Assert
        Assert.NotNull(result);
        Assert.IsType<Contact>(result);
    }
}
