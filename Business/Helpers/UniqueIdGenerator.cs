namespace Business.Helpers;

// This class is responsible for generating unique identifiers
public static class UniqueIdGenerator
{
    // This method generates a new unique identifier using Guid and returns it as a string
    public static string GenerateUniqueId() => Guid.NewGuid().ToString();
}
