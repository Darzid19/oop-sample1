namespace oop_sample.Procurement.Domain.Model.ValueObjects;

public record ProductId
{ 
    
    /// <summary>
    /// Represents a product identifier in the procurement bounded context. This value object encapsulates the unique identifier for a product, ensuring that it is valid and cannot
    /// be an empty GUID.
    /// It provides a factory method to create new instances with a new GUID and overrides the ToString method for easy representation.
    /// </summary>
    
    
    public Guid Id { get; init; }
    
    /// <summary>
    /// Creates a new instance of  <see cref="ProductId"/>
    /// </summary>
    /// <param name="id"></param>
    /// <exception cref="ArgumentException"></exception>
    
    public ProductId(Guid id)
    {
        if (id == Guid.Empty)
        throw new ArgumentException($"{nameof(id)} cannot be an empty guid");
        Id = id;
    }

    
    /// <summary>
    /// Creates a new instance of <see cref="ProducId"/> containing a Guid value.
    /// </summary>
    /// <returns> A new instance of <see cref="ProductId"/> with a new GUID value.</returns>
    
    public static ProductId New() => new (Guid.NewGuid());
    
    /// <summary>
    /// Returns a string representation of the product identifier.
    /// </summary>
    /// <returns>A string representation of the product identifier</returns>
    
    
    public override string ToString() => Id.ToString();
}

