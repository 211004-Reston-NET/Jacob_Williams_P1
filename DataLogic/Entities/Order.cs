using System;
using System.Collections.Generic;

#nullable disable

namespace DataLogic.Entities
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int? OrderNumber { get; set; }
        public int? CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
