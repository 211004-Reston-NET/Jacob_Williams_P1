using System;
using System.Collections.Generic;

#nullable disable

namespace DataLogic.Entities
{
    public partial class Product
    {
        public Product()
        {
            Stocks = new HashSet<Stock>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int? ProductPrice { get; set; }

        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
