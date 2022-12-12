using DDD.Foundations;
using DDD.Primitives.Finance;
using DDD.Primitives.UoMs;
using DDD.Primitives.Quantities;
using WebShop.Identities;

namespace WebShop.Purchase.Model.BasketAggregate;

public class Basket : Entity<BasketId>, IAggregateRoot
{
    #region ctor
    private Basket(BasketId id) : base(id)
    {
        items = new();
    }

    public static Basket CreateEmpty(BasketId id) => new(id);

    public static Basket CreateWithIncentive(BasketId id, ProductId incentiveId, Quantity quantity)
    {
        var basket = new Basket(id);
        basket.AddItem(incentiveId, quantity);
        return basket;
    }

    public static Basket CreateWithSpendingLimit(BasketId id, Money limit)
    {
        var basket = new Basket(id);
        // TODO check if limit is positive
        // basket.Limit = limit;
        return basket;
    }
    #endregion

    public void Empty() => items.Clear();

    private readonly List<BasketItem> items;
    public IReadOnlyList<BasketItem> Items => items;

    private BasketItem? FindItem(ProductId id, UoM uom) => 
        items.Find(i => i.Id == id & i.Quantity.UoM == uom);

    public Result AddItem(ProductId id, Quantity quantity)
    {
        var basketItem = FindItem(id, quantity.UoM!);
        if (basketItem is null)
            items.Add(new BasketItem(id, quantity));
        else
            basketItem.IncreaseQuantity(quantity);
        return new Success();
    }

    public Result RemoveItem(ProductId id, Quantity quantity)
    {
        var basketItem = FindItem(id, quantity.UoM!);
        if (basketItem is null)
            return new Error(ErrorCode.Custom, $"No product {id} in the basket.");

        basketItem.DecreaseQuantity(quantity);
        if (basketItem.Quantity.IsZero)
            items.Remove(basketItem);
        return new Success();
    }
}
