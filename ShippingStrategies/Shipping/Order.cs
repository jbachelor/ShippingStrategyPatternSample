using System;
namespace ShippingStrategies.Shipping
{
    public class Order
    {
        public Address Destination { get; set; }
        public Address Origin { get; set; }
        public ShippingOptions ShippingMethod { get; set; }
    }
}
