namespace WebShop.Identities;

public record class NullGTIN() : GTIN(string.Empty)
{
    public override bool IsValid() => true;
}
