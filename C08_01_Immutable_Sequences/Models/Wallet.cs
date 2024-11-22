using C08_01_Immutable_Sequences.Common;
using C08_01_Immutable_Sequences.Markers;

namespace C08_01_Immutable_Sequences.Models;

public class Wallet
{
    public Currency BaseCurrency { get; }
    public IEnumerable<IMoney> Monies { get; }

    public Wallet(Currency baseCurrency, Reiterable<IMoney> monies)
    {
        ArgumentNullException.ThrowIfNull(baseCurrency, nameof(baseCurrency));
        ArgumentNullException.ThrowIfNull(monies, nameof(monies));
        
        BaseCurrency = baseCurrency;
        Monies = monies;
    }
}