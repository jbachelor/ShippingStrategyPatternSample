using System;
namespace ShippingStrategies.Shipping
{
    public class ShippingCostStrategyUPS : IShippingCostStrategy
    {
        public decimal Calculate(Order order)
        {
            return 4.25m;
        }
    }
}
