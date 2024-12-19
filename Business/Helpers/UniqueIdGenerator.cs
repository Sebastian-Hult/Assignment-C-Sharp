namespace Business.Helpers;

public static class UniqueIdGenerator
{
    public static string GenerateUniqueId() => Guid.NewGuid().ToString();
}
