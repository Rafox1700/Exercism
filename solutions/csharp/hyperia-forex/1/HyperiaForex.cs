using System;

public struct CurrencyAmount
{
    private decimal amount;
    private string currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }

    // Égalité
    public static bool operator ==(CurrencyAmount a, CurrencyAmount b)
    {
        if (a.currency != b.currency) throw new ArgumentException("Les devises doivent être identiques");
        return a.amount == b.amount;
    }

    public static bool operator !=(CurrencyAmount a, CurrencyAmount b)
    {
        return !(a == b);
    }

    // Comparaison
    public static bool operator >(CurrencyAmount a, CurrencyAmount b)
    {
        if (a.currency != b.currency) throw new ArgumentException("Les devises doivent être identiques");
        return a.amount > b.amount;
    }

    public static bool operator <(CurrencyAmount a, CurrencyAmount b)
    {
        if (a.currency != b.currency) throw new ArgumentException("Les devises doivent être identiques");
        return a.amount < b.amount;
    }

    // Opérations arithmétiques
    public static CurrencyAmount operator +(CurrencyAmount a, CurrencyAmount b)
    {
        if (a.currency != b.currency) throw new ArgumentException("Les devises doivent être identiques");
        return new CurrencyAmount(a.amount + b.amount, a.currency);
    }

    public static CurrencyAmount operator -(CurrencyAmount a, CurrencyAmount b)
    {
        if (a.currency != b.currency) throw new ArgumentException("Les devises doivent être identiques");
        return new CurrencyAmount(a.amount - b.amount, a.currency);
    }

    public static CurrencyAmount operator *(CurrencyAmount a, decimal factor)
    {
        return new CurrencyAmount(a.amount * factor, a.currency);
    }

    // ✅ Correction : Permet la multiplication `decimal * CurrencyAmount`
    public static CurrencyAmount operator *(decimal factor, CurrencyAmount a)
    {
        return new CurrencyAmount(a.amount * factor, a.currency);
    }

    public static CurrencyAmount operator /(CurrencyAmount a, decimal divisor)
    {
        if (divisor == 0) throw new DivideByZeroException("Division par zéro interdite.");
        return new CurrencyAmount(a.amount / divisor, a.currency);
    }

    // Surcharge de Equals et GetHashCode
    public override bool Equals(object obj)
    {
        if (obj is CurrencyAmount other)
        {
            return this == other;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(amount, currency);
    }

    // ✅ Correction : Conversion implicite vers decimal
    public static implicit operator decimal(CurrencyAmount a) => a.amount;

    // ✅ Correction : Conversion explicite vers double
    public static explicit operator double(CurrencyAmount a) => (double)a.amount;
}
