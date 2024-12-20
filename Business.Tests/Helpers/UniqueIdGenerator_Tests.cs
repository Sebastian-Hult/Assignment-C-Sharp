using Business.Helpers;

namespace Business.Tests.Helpers;

public class UniqueIdGenerator_Tests
{
    // This test checks if the GenerateUniqueId method returns a string that is not null or empty
    // And checks if the result is a valid Guid string
    [Fact]
    public void GenerateUniqueId_ShouldReturnGuidAsString()
    {
        // Arrange

        // Act
        var result = UniqueIdGenerator.GenerateUniqueId();

        // Assert
        Assert.False(string.IsNullOrEmpty(result));

        Assert.True(Guid.TryParse(result, out _));
    }
}
