namespace NexBank.Domain.Account.Utilities;

public static class Generator
{
    private static Random random = new Random();
    public static string AccountNumber() => $"{random.Next(100000, 999999)}{random.Next(100000, 999999)}";

    public static string AgencyNumber() => random.Next(1000, 9999).ToString();


}
