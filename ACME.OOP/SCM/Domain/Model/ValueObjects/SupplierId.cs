namespace oop_sample.SCM.Domain.Model.ValueObjects;

public record SupplierId()
{
   public string Identifier { get; init; }
   
   public SupplierId(string identifier) : this()
   {
          if (string.IsNullOrWhiteSpace(identifier))
          throw new ArgumentException("Supplier identifier should not be null or whitespace.", nameof(identifier));

          Identifier = identifier;
      }
   
   
}