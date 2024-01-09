namespace FactoryMethod;

/// <summary>
/// Abstract Product since we don't want to instantiate it on its own
/// </summary>
public abstract class DiscountService
{
    public abstract int DiscountPercentage { get; }
    public override string ToString() => GetType().Name;
}