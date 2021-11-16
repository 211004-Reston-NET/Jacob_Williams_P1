using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUIOne.Models
{
    public class ReplenishInventoryVM
    {
        public ReplenishInventoryVM()
        {

        }

        public ReplenishInventoryVM (LineItems p_lineItemQuantity)
        {
            this.LineItemId = p_lineItemQuantity.LineItemId;
            this.LineItemQuantity = p_lineItemQuantity.LineItemId;
            this.StoreFrontId = p_lineItemQuantity.StoreFrontId;
            this.ProductId = p_lineItemQuantity.ProductId;
        }

        public int LineItemId { get; set; }
        public int LineItemQuantity { get; set; }
        public int StoreFrontId { get; set; }
        public int ProductId { get; set; }

    }
}
