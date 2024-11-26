namespace C08_02_Immutable_Collections.Functions;

public static class Expiration
{
    public delegate bool CheckExpiry(DateOnly validUntil, DateOnly referenceDate);
    public static CheckExpiry IsExpired() =>
        (validUntil, referenceDate) => validUntil < referenceDate;
}