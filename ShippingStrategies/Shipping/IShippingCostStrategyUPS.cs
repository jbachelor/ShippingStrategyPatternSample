namespace ShippingStrategies.Shipping
{
    public interface IShippingCostStrategy
    {
        /// <summary>
        /// Algorithm for determining shipping cost of an order.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        decimal Calculate(Order order);
    }
}