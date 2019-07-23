namespace ShippingStrategies.Shipping
{
    public interface IShippingCostStrategy
    {
        decimal Calculate(Order order);
    }
}