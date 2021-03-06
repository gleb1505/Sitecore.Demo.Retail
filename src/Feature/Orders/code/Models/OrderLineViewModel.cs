using System.Collections;
using System.Collections.Generic;
using Sitecore.Commerce.Connect.CommerceServer.Orders.Models;
using Sitecore.Data.Items;
using Sitecore.Foundation.Commerce.Models;

namespace Sitecore.Feature.Commerce.Orders.Models
{
    public class OrderLineViewModel
    {
        public decimal? Savings { get; set; }
        public MediaItem Image { get; set; }
        public string ProductUrl { get; set; }
        public string Title { get; set; }
        public string ProductColor { get; set; }
        public string ShippingMethodName { get; set; }
        public IParty ShippingAddress { get; set; }
        public string ShippingEmail { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal Total { get; set; }
        public string Currency { get; set; }
        public uint Quantity { get; set; }
        public IEnumerable<string> Adjustments { get; set; }
        public decimal Discount { get; set; }
        public string OrderLineId { get; set; }
    }
}