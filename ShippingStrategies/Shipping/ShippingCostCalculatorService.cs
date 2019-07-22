using System;
namespace ShippingStrategies.Shipping
{
    public class ShippingCostCalculatorService
    {
        public decimal CalculateShippingCost(Order order)
        {
            switch (order.ShippingMethod)
            {
                case ShippingOptions.FedEx:
                    return CalculateForFedEx(order);
                case ShippingOptions.UPS:
                    return CalculateForUps(order);
                case ShippingOptions.USPS:
                    return CalculateForUsps(order);
                default:
                    throw new ApplicationException($"Unknown shipping method: {order.ShippingMethod}");
            }
        }

        private decimal CalculateForFedEx(Order order)
        {
            return 5.10m;
        }

        private decimal CalculateForUps(Order order)
        {
            return 4.25m;
        }

        private decimal CalculateForUsps(Order order)
        {
            return 3.05m;
        }
    }
}
