using System;
using System.Collections.Generic;

#nullable disable

namespace DataLogic.Entities
{
    public partial class LineItem
    {
        public LineItem()
        {
            ItemsInOrders = new HashSet<ItemsInOrder>();
        }

        public int LineItemId { get; set; }
        public int LineItemQuantity { get; set; }
        public int ProductId { get; set; }
        public int StoreFrontId { get; set; }

        public virtual Product Product { get; set; }
        public virtual StoreFront StoreFront { get; set; }
        public virtual ICollection<ItemsInOrder> ItemsInOrders { get; set; }
    }
}
