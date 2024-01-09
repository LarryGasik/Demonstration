namespace FactoryMethod;

public abstract class DiscountFactory
{
    public abstract DiscountService CreateDiscountService();
}

//Note: Concrete Creator
public class CountryDiscountFactory(string countryIdentifier): DiscountFactory
{
    private readonly string _countryIdentifier = countryIdentifier;
    public override DiscountService CreateDiscountService()
    {
        return new CountryDiscountService(_countryIdentifier);
    }
}

//Note: Concrete Creator
public class CodeDiscountFactory(Guid guid) : DiscountFactory
{
    private readonly Guid _codeIdentifier = guid;
    public override DiscountService CreateDiscountService()
    {
        return new CodeDiscountService(_codeIdentifier);
    }
}