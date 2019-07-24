using System;
namespace ShippingStrategies.Shipping
{
    public class ShippingCostCalculatorService
    {
        private readonly IShippingCostStrategy _shippingCostStrategy;

        public ShippingCostCalculatorService(IShippingCostStrategy shippingCostStrategy)
        {
            _shippingCostStrategy = shippingCostStrategy
                ?? throw new ArgumentNullException(
                    $"{nameof(shippingCostStrategy)} can not be null.");
        }

        public decimal CalculateShippingCost(Order order)
        {
            return _shippingCostStrategy.Calculate(order);
        }
    }
}
