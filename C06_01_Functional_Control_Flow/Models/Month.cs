namespace C06_01_Functional_Control_Flow.Models;

public record struct Month
{
    private readonly DateOnly _date;
    
    public Month(int year, int month)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(year, 1, nameof(year));
        ArgumentOutOfRangeException.ThrowIfGreaterThan(year, 9999, nameof(year));
        ArgumentOutOfRangeException.ThrowIfLessThan(month, 1, nameof(month));
        ArgumentOutOfRangeException.ThrowIfGreaterThan(month, 12, nameof(month));
        
        _date = new DateOnly(year, month, 1);
    }
    
    public override string ToString() => $"{_date:yyyy-MM}";
    public static implicit operator DateOnly(Month month) => month._date;
}