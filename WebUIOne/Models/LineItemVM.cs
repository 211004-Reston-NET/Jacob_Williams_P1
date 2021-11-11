using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUIOne.Models
{
    public class LineItemVM
    {
        public LineItemVM()
        {

        }
        public LineItemVM(LineItems p_item)
        {
            this.ProductName = p_item.Product.ProductName;
            this.ProductId = p_item.ProductId;
            this.LineItemQuantity = p_item.LineItemQuantity;
            this.LineItemId = p_item.LineItemId;
            this.StoreFrontId = p_item.StoreFrontId;
        }

        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public int LineItemQuantity { get; set; }
        public int LineItemId { get; set; }
        public int StoreFrontId { get; set; }
    }
}
