using System;
namespace ShippingStrategies.Shipping
{
    public class ShippingCostStrategyFedEx : IShippingCostStrategy
    {
        public decimal Calculate(Order order)
        {
            return 5.10m;
        }
    }
}
