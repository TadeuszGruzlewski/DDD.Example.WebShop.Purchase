//using Domain.Model.Foundations;
//using WebShop.Purchase.Model.BasketAggregate;

//namespace WebShop.Purchase.Model.ShopperAggregate;

//public class Shopper : Entity<ShopperId>, IAggregateRoot
//{
//    public Basket Basket { get; private set; }

//    private Shopper(ShopperId id) : base(id)
//    {
//        Basket = Basket.Create(new BasketId(id.EmailAddress));
//    }

//    public static Shopper Create(ShopperId id)
//    {   
//        return new Shopper(id);
//    }
//}
