using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogViewComponent.Core.Models
{
    public class CartTotalsModel
    {
        public decimal Subtotal { get; set; }
        public decimal Tax { get; set; }
        public decimal ShippingAmount { get; set; }
    }
}
