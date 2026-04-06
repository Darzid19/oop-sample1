using oop_sample.Procurement.Domain.Model.ValueObjects;
namespace oop_sample.Procurement.Domain.Model.Aggregates;
using oop_sample.Shared.Domain.Model.ValueObjects;

public class PurchaseOrderItem

    /// <summary>
    /// Represents a purchase order aggregate int the Procurement bounded context. This value object encapsulates the unique identifier for a product
    /// Encapsultes the details.
    /// It provides a factory method to create new instances with a new GUID and overrides the ToString method for easy representation.
    /// </summary>




{   
    public ProductId ProductId { get; }
    
    public int Quantity { get; }
    
    public Money UnitPrice { get; }

    /// <summary>
    /// Creates a new instance of<see cref="PurchaseOrdenItem"/>
    /// </summary>
    /// <param name="productId">The <see cref="ProductId"/>identifier</param>
    /// <param name="quantity">The product quantity to purchase</param>
    /// <param name="unitPrice"> The unit price for the product</param>
    /// <exception cref="ArgumentNullException"> Thrown when a required attribute is null</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when a numer attribute is out of the expected </exception>
    
    
    internal PurchaseOrderItem(ProductId productId, int quantity, Money unitPrice)
    {
        ProductId = productId ?? throw new ArgumentNullException(nameof(productId));
        Quantity = quantity > 0 ? quantity : throw new ArgumentOutOfRangeException(nameof(quantity));
        UnitPrice = unitPrice ?? throw new ArgumentNullException(nameof(unitPrice));
        
    }
    
    public Money CalculateItemTotal() => UnitPrice.Multiply(Quantity);
}