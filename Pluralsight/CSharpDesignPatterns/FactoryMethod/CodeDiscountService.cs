namespace FactoryMethod;

public class CodeDiscountService(Guid guid) : DiscountService
{
    private readonly Guid _guid = guid;

    public override int DiscountPercentage
    {
        get
        {
            //Note: if the first character in the guid is 1,
            //      they get a 1% discount
            if (_guid.ToString().ToCharArray(0, 1)[0] == '1')
            {
                return 1;
            }

            return 5;
        }
    }
}