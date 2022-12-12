namespace WebShop.Identities;

public static class GTINFactory
{
    public static GTIN Create(GTINType gtinType, string code)
    {
        try
        {
            return
                gtinType switch
                {
                    GTINType.EAN => new EAN(code),
                    GTINType.JAN => new JAN(code),
                    _ => throw new NotImplementedException()
                };
        }
        catch (Exception ex)
        {
            return new NullGTIN() { ErrorMsg = ex.Message };
        }
    }
}
