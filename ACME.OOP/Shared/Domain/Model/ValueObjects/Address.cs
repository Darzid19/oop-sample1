namespace oop_sample.Shared.Domain.Model.ValueObjects;



public record Address
    
    
{
   public string Street;
    public string City;
    public string Number;
    public string PostalCode;
    public string Country;
    public string? StateOrRegion;

    /// <summary>
    /// Creates a new instance of see cref= "Address"/
    /// </summary>
    /// <param name="street">the address street, which must not be null or blank</param>
    /// <param name="city">the address city, which must not be null of blank</param>
    /// <param name="number">the address number, which must not be null of blank </param>
    /// <param name="postalCode">the address postal code, which must not be null of blank</param>
    /// <param name="country">the address country, which must not be null of blank</param>
    /// <param name="stateOrRegion">the state or region</param>
    /// <exception cref="ArgumentException">throw when any  required paramete is nul of blank</exception>
    
    
    
    
    public Address(string street, string city, string number, string postalCode, string country, string stateOrRegion)
    {
        if (string.IsNullOrWhiteSpace(street)) throw new ArgumentException("Street cannot be null or empty");
        if (string.IsNullOrWhiteSpace(city)) throw new ArgumentException("City cannot be null or empty");
        if (string.IsNullOrWhiteSpace(number)) throw new ArgumentException("Number cannot be null or empty");
        if (string.IsNullOrWhiteSpace(postalCode)) throw new ArgumentException("Postal code cannot be null or empty");
        if (string.IsNullOrWhiteSpace(country)) throw new ArgumentException("Country cannot be null or empty");

        Street = street;
        Number = number;
        City = city;
        StateOrRegion = stateOrRegion;
        Country = country;
        PostalCode = postalCode;
        


    }
    /// <summary>
    /// Returns the string representation of address in the format :"Street, Number, City, StateOrRegion, PostalCode, Country"
    /// </summary>
    /// <returns>string
    /// </returns>
        
    
    public override string ToString() => $"{Street}, {City}, {Number}, {PostalCode}, {Country}, {StateOrRegion}";
    
};