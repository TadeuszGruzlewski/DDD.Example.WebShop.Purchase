using DDD.Foundations;
using DDD.Primitives.Quantities;
using WebShop.Identities;

namespace WebShop.Purchase.Model.BasketAggregate;

public class BasketItem : Entity<ProductId>
{
    internal BasketItem(ProductId productId, Quantity quantity) : 
        base(productId) => Quantity = quantity;

    public Quantity Quantity { get; private set; }

    internal void IncreaseQuantity(Quantity quantity) => Quantity += quantity;
    internal void DecreaseQuantity(Quantity quantity) => Quantity -= quantity;
}
