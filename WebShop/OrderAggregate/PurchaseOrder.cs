using DDD.Foundations;
using WebShop.Identities;

namespace WebShop.Purchase.Model.OrderAggregate;

public class PurchaseOrder : Entity<PurchaseOrderId>, IAggregateRoot
{
    private readonly List<OrderItem> items;
    public IReadOnlyList<OrderItem> Items => items;

    private PurchaseOrder(PurchaseOrderId id) : base(id)
    { 
        items = new List<OrderItem>();
    }

    public static PurchaseOrder Create(PurchaseOrderId id)
    {
        return new PurchaseOrder(id);
    }
}
