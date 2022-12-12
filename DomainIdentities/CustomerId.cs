using DDD.Foundations;
using DDD.Primitives.Addresses;

namespace WebShop.Identities;

public record class CustomerId(EmailAddress EmailAddress) : EntityId
{
    public override bool IsValid()
    {
        // TODO implement validation
        return true;
    }
}
