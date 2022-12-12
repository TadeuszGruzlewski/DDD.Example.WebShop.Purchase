using DDD.Foundations;

namespace DDD.Primitives.Misc;

public record class EmailAddress(string Address) : Primitive
{
    public override bool IsValid()
    {
        // TODO regex validation
        throw new NotImplementedException();
    }
}
