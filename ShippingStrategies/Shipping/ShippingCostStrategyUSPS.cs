using System;
namespace ShippingStrategies.Shipping
{
    public class ShippingCostStrategyUSPS : IShippingCostStrategy
    {
        public decimal Calculate(Order order)
        {
            return 3.05m;
        }
    }
}
