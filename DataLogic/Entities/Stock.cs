using System;
using System.Collections.Generic;

#nullable disable

namespace DataLogic.Entities
{
    public partial class Stock
    {
        public int StockId { get; set; }
        public int? StockAmount { get; set; }
        public int? ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
