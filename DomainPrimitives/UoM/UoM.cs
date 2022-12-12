using DDD.Foundations;

namespace DDD.Primitives.UoMs;

public abstract record class UoM : Enumeration
{
    public int Code => Id;
    public decimal Rate { get; init; }

    public UoM Base => GetBase();
    protected abstract UoM GetBase();

    public bool IsCompatibleTo(UoM u) => GetType() == u.GetType();

    public void TestCompatibilityTo(UoM u)
    {
        if (!IsCompatibleTo(u))
            throw new ArgumentException($"Incompatible Units of Measure: {GetType()} and {u.GetType()}.");
    }

    public decimal GetRateTo(UoM u)
    {
        TestCompatibilityTo(u);
        return Rate / u.Rate;
    }
}
