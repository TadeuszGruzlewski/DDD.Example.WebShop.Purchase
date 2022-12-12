using DDD.Foundations;

namespace WebShop.Identities;

public record class PurchaseOrderId(int Year, long Number) : EntityId
{
    public override bool IsValid()
    {
        throw new NotImplementedException();
    }
}
