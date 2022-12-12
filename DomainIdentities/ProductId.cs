using DDD.Foundations;

namespace WebShop.Identities;

public record class ProductId(string Code) : EntityId
{
    public override bool IsValid()
    {
        var valid = Code == string.Empty;
        if (!valid)
            ErrorMsg = $"{GetType().Name}.Code must not be empty.";
        return valid;
    }
}
