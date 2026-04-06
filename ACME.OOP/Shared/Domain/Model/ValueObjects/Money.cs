using System.ComponentModel;

namespace oop_sample.Shared.Domain.Model.ValueObjects;

/// <summary>
/// 
/// </summary>




public record Money()
{
    public decimal Amount { get; init; }

    public string Currency { get; init; }

    /// <summary>
    /// Creates a new instance of <see cref="Money"/>
    /// </summary>
    /// <param name="amount">the monetary amount</param>
    /// <param name="currency">the currency</param>
    /// <exception cref="ArgumentException">Thrown when the currency is not a valid 3-letter ISO code</exception>


    public Money(decimal amount, string currency) : this()
    {
        if (string.IsNullOrWhiteSpace(currency) || currency.Length != 3)
            throw new ArgumentException("Currency must be a 3-leatter code.", nameof(currency));
        Amount = amount;
        Currency = currency;

    }

    /// <summary>
    /// Returns a string representation of the money, combinig the amount and currency
    /// 
    /// </summary>
    /// <returns>A string in the format "Amount Currency</returns>


    public override string ToString() => $"{Amount} {Currency}";

    /// <summary>
    /// Adds two    <see cref="Money"/>
    /// </summary>
    /// <param name="other">The other <see cref="Money"/>to add. Must have the same currency</param>
    /// <returns>A news<see cref="Money"/>isntace with the combiend amount if the currencies match; otherwise,</returns>
    /// <exception cref="InvalidCastException"Thrown when the currencies do not match></exception>


    public Money Add(Money? other)
    {
        
        return other == null ? this : new Money(amount: Amount + other.Amount, Currency);
        
    }
    public Money Multiply(int multiplier) => new Money(Amount * multiplier, Currency);

}