using DDD.Foundations;

namespace WebShop.Purchase.Model.ProductAggregate;

public record class ProductImage(string FilePath) : ValueObject
{
    public override bool AssertInvariants(List<InvariantError> errors)
    {
        throw new NotImplementedException();
    }
}
