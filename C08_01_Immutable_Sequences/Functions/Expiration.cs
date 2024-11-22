namespace C08_01_Immutable_Sequences.Functions;

public static class Expiration
{
    public delegate bool CheckExpiry(DateOnly validUntil, DateOnly referenceDate);
    public static CheckExpiry IsExpired() =>
        (validUntil, referenceDate) => validUntil < referenceDate;
}