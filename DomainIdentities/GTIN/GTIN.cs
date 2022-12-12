namespace WebShop.Identities;

public enum GTINType
{
    EAN,    // European Article Number
    JAN,    // Japaneze Article Number
    ISSN,   // International Standard Serial Number
    ISMN,   // International Standard Music Number
    ISBN,   // International Standard Book Number
    GTIN8,  // Global Trade Item Number, length 8
    GTIN12, // Global Trade Item Number, length 12
    // etc
}

public abstract record class GTIN(string Code) : ProductId(Code)
{
    public static (GTIN?, string?) Create(GTINType gtinType, string code)
    {
        try
        {
            GTIN? id = gtinType switch
            {
                GTINType.EAN => new EAN(code),
                GTINType.JAN => new JAN(code),
                _ => throw new NotImplementedException()
            };
            return (id, null);
        }
        catch (Exception ex)
        {
            return (null, ex.Message);
        }
    }
}

public record class EAN(string Code) : GTIN(Code)
{
    public override bool IsValid()
    {
        // TODO full validation
        var valid = Code.Length == 8;
        if (!valid)
            ErrorMsg = $"{GetType().Name}.Code must be 8 characters long.";
        return valid;
    }
}

public record class JAN(string Code) : GTIN(Code)
{
    public override bool IsValid()
    {
        throw new NotImplementedException();
    }
}

//public record class GTIN8(string Code) : GTIN(Code)
//{
//    public override bool IsValid() 
//    {
//        // TODO full validation
//        var valid = Code.Length == 8;
//        if (!valid)
//            errorMsg = $"{GetType().Name}.Code must be 8 characters long.";
//        return valid;
//    }
//}

//public record class GTIN12(string Code) : GTIN(Code)
//{
//    public override bool IsValid()
//    {
//        // TODO full validation
//        var valid = Code.Length == 12;
//        if (!valid)
//            errorMsg = $"{GetType().Name}.Code must be 12 characters long.";
//        return valid;
//    }
//}
