namespace DDD.Foundations;

public abstract class Entity<TId> where TId : EntityId
{
    public readonly TId Id;
    protected Entity(TId id) => Id = id;
}
