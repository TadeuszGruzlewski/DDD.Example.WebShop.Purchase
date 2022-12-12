using DDD.Foundations;
using DDD.Primitives.Quantities;
using WebShop.Identities;

namespace WebShop.Purchase.Model.OrderAggregate;

public record class OrderItem(ProductId ProductId, Quantity Quantity) : ValueObject
{
    public override bool AssertInvariants(List<InvariantError> errors)
    {
        throw new NotImplementedException();
    }
}
