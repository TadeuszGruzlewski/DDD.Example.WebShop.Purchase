namespace DDD.Foundations;

public abstract record class ValueObject { };
//{
//    protected string errorMsg = string.Empty;
//    protected abstract bool IsValid();

//    protected EntityId() : base()
//    {
//        if (!IsValid())
//            throw new ArgumentException(errorMsg);
//    }

//    protected EntityId(EntityId? _)
//    {
//        throw new InvalidOperationException("Copy constructor or 'with' operator is not allowed for EntityId objects.");
//    }
//}
