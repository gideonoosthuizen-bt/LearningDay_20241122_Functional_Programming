namespace C02_01_Until_Discriminated_Unions_Arrive
{
    // This is called a "marker interface" as it only indicates the shared
    // behavior of the classes that implement it.
    interface IMoney { }

    record Currency
    {
        public string Symbol { get; }
        
        public Currency(string symbol)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(symbol, nameof(symbol));
            
            Symbol = symbol;
        }
    }

    record Amount
    {
        public decimal Value { get; }
        public Currency Currency { get; }
        
        public Amount(decimal value, Currency currency)
        {
            ArgumentNullException.ThrowIfNull(currency, nameof(currency));
            
            Value = value;
            Currency = currency;
        }
    }

    // This is where the difference between subclasses and discriminated unions
    // becomes apparent. In this case, Cash does not derive from Balance, nor does
    // Balance derive from Cash. They are separate classes that share a common behavior
    // but must be able to evolve separately.
    record Cash : IMoney
    {
        public decimal Value { get; }
        public Currency Currency { get; }
        
        public Cash(decimal value, Currency currency)
        {
            ArgumentNullException.ThrowIfNull(currency, nameof(currency));
            
            Value = value;
            Currency = currency;
        }
    }

    // GiftCard is another implementation of IMoney, but it has different properties.
    // Cash and GiftCard are not related to each other, except for both being types of money.
    // Balance and Currency do not derive from IMoney, but they are used in the context of money.
    record GiftCard : IMoney
    {
        public decimal Value { get; }
        public Currency Currency { get; }
        public DateOnly ValidUntil { get; }

        public GiftCard(decimal value, Currency currency, DateOnly validUntil)
        {
            ArgumentNullException.ThrowIfNull(currency, nameof(currency));
            
            Value = value;
            Currency = currency;
            ValidUntil = validUntil;
        }
    }
    
    class Program
    {
        static (IMoney result, Amount diff) Add(IMoney money, Amount amount, DateOnly at)
        {
            return money switch
            {
                Cash cash when cash.Currency == amount.Currency => (new Cash(cash.Value + amount.Value, cash.Currency), amount),
                Cash => (money, new Amount(0, amount.Currency)),
                GiftCard giftCard when giftCard.Currency == amount.Currency && giftCard.ValidUntil >= at => (new GiftCard(giftCard.Value + amount.Value, giftCard.Currency, giftCard.ValidUntil), amount),
                GiftCard => (money, new Amount(0, amount.Currency)),
                
                _ => throw new ArgumentException("Unsupported money type", nameof(money))
            };
        }
        
        static void Main(string[] args)
        {
            var x = new Cash(100, new Currency("USD"));
            var y = new GiftCard(50, new Currency("USD"), new DateOnly(2022, 12, 31));
            
            var (result1, diff1) = Add(x, new Amount(25, new Currency("USD")), new DateOnly(2022, 12, 15));
            var (result2, diff2) = Add(y, new Amount(25, new Currency("USD")), new DateOnly(2022, 12, 15));
            var (result3, diff3) = Add(x, new Amount(25, new Currency("EUR")), new DateOnly(2022, 12, 15));

            var bp = "BP";
        }
    }
}