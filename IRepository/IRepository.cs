using DDD.Foundations;
using WebShop.Purchase.Model.BasketAggregate;

namespace IRepository;

public abstract class IRepository<TId, T> where TId : EntityId where T : IAggregateRoot
{
    public abstract T? Get(TId id);
    //bool Add(T aggregate);
    //bool Update(T aggregate);
    //bool Delete(TId id);
}


public class MyRepo : IRepository<BasketId, Basket>
{
    public override Basket? Get(BasketId id)
    {
        throw new NotImplementedException();
    }
}
