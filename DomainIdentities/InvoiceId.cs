using DDD.Foundations;

namespace WebShop.Identities;

public record class InvoiceId(int Year, long Number) : EntityId
{
    public override bool IsValid()
    {
        throw new NotImplementedException();
    }
}
