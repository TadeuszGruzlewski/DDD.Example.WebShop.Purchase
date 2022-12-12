using DDD.Foundations;
using DDD.Primitives.Finance;
using WebShop.Identities;

namespace WebShop.Purchase.Model.ProductAggregate;

public record class Product(ProductId Id, Price UnitPrice, List<ProductImage> Images) : IAggregateRoot;
