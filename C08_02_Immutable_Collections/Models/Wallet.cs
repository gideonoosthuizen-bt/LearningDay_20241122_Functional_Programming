using System.Collections.Immutable;
using C08_02_Immutable_Collections.Common;
using C08_02_Immutable_Collections.Markers;

namespace C08_02_Immutable_Collections.Models;

public class Wallet
{
    public Currency BaseCurrency { get; }
    public ImmutableList<IMoney> Monies { get; }

    public Wallet(Currency baseCurrency, ImmutableList<IMoney> monies)
    {
        ArgumentNullException.ThrowIfNull(baseCurrency, nameof(baseCurrency));
        ArgumentNullException.ThrowIfNull(monies, nameof(monies));
        
        BaseCurrency = baseCurrency;
        Monies = monies;
    }
}