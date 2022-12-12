using WebShop.Identities;
using WebShop.Purchase.Model.ProductAggregate;
using WebShop.Purchase.Model.BasketAggregate;


Console.WriteLine();

//var basket = Basket.Create(new BasketId(new CustomerId(new EmailAddress("")), ""));
//basket.AddItem(new ProductId(""), new LogisticQuantity(LogisticUoM.Container, 4));



//var c = new CustomerId(new EmailAddress("blabla"));
//var bId = new BasketId(c, "First");
//var b = Basket.Create(bId);



////bool newShopper = true;
////var basketId = new BasketId("");
////var welcomeGift = new ProductItem(prodId!, 10);
////var basket = newShopper ?
////    Basket.CreateWithIncentive(basketId, welcomeGift) :
////    Basket.Create(basketId);

//var prodId1 = ProductGTIN.Create("12345", ProductGTINType.JAN);
//Console.WriteLine(prodId1 == null ? "NULL" : prodId1);

////var prodId2 = ProductGTINFactory.Create("0", ProductGTINType.EAN, out _);
//(var prodId2, var errorMsg1) = ProductGTINFactory1.Create("XYZ", ProductGTINType.EAN);
//Console.WriteLine(prodId2 == null ? errorMsg1 : prodId2);

////ShopperId shopperId = new("blabla");
////Console.WriteLine(shopperId.EmailAddress);

//Console.WriteLine(new ProductId(10) == new ProductId(10));


//public record class ProductId1(long Code) : EntityId;