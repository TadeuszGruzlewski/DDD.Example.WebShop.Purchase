using DDD.Foundations;
using WebShop.Identities;

namespace WebShop.Purchase.Model.BasketAggregate;

public record class BasketId(CustomerId CustomerId, string Name) : EntityId
{
    public override bool IsValid()
    {
        // TODO implement validation
        return true;
    }
}
