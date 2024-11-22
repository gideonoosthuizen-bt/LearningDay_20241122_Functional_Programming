namespace C06_01_Functional_Control_Flow.Functions;

public static class Expiration
{
    public delegate bool CheckExpiry(DateOnly validUntil, DateOnly referenceDate);
    public static CheckExpiry IsExpired() =>
        (validUntil, referenceDate) => validUntil < referenceDate;
}