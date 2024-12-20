using Business.Helpers;

namespace Business.Tests.Helpers;

public class UniqueIdGenerator_Tests
{
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
