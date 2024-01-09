namespace FactoryMethod;

public class CountryDiscountService : DiscountService
{
    /// <summary>
    /// We don't want the identifier to be changed after being constructed
    /// </summary>
    private readonly string _identifier;

    public CountryDiscountService(string identifier)
    {
        _identifier = identifier;
    }

    public override int DiscountPercentage
    {
        get
        {
            switch (_identifier)
            {
                case "USA": return 17;
                default : return 10;
            }
        }
    }
}