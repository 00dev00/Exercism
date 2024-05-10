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

    public static bool operator ==(CurrencyAmount first, CurrencyAmount second) => 
        first.currency != second.currency ? throw new ArgumentException("Different currencies") : first.amount == second.amount;

    public static bool operator !=(CurrencyAmount first, CurrencyAmount second) => !(first == second);

    public static bool operator >(CurrencyAmount first, CurrencyAmount second) => 
        first.currency != second.currency ? throw new ArgumentException("Different currencies") : first.amount > second.amount;

    public static bool operator <(CurrencyAmount first, CurrencyAmount second) => !(first == second || first > second);

    public static CurrencyAmount operator +(CurrencyAmount first, CurrencyAmount second) => 
        first.currency != second.currency ? throw new ArgumentException("Different currencies") : new(first.amount + second.amount, first.currency);
    
    public static CurrencyAmount operator -(CurrencyAmount first, CurrencyAmount second) => 
        first.currency != second.currency ? throw new ArgumentException("Different currencies") : new(first.amount - second.amount, first.currency);
    
    public static CurrencyAmount operator *(decimal multiplier, CurrencyAmount ca) => new(ca.amount * multiplier, ca.currency);
    public static CurrencyAmount operator /(decimal divisor, CurrencyAmount ca) => new(ca.amount/divisor, ca.currency); 

    public static explicit operator double(CurrencyAmount ca) => (double)ca.amount;
    public static implicit operator decimal(CurrencyAmount ca) => ca.amount;


    override public bool Equals(object obj) => obj is CurrencyAmount ca && ca.amount == amount && ca.currency == currency;
    override public int GetHashCode() => HashCode.Combine(amount, currency);
}
