using System;
using System.Collections.Generic;

#nullable disable

namespace DataLogic.Entities
{
    public partial class ItemsInOrder
    {
        public int ItemsInOrderId { get; set; }
        public int LineItemId { get; set; }
        public int OrdersId { get; set; }

        public virtual LineItem LineItem { get; set; }
        public virtual Order Orders { get; set; }
    }
}
