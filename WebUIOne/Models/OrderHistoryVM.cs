using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUIOne.Models
{
    public class OrderHistoryVM
    {
        public OrderHistoryVM()
        {

        }
        public OrderHistoryVM(Order p_order)
        {
            this.OrdersId = p_order.OrdersId;
            this.TotalPrice = p_order.TotalPrice;
            this.StoreFrontId = p_order.StoreFrontId;
            this.CustomerId = p_order.CustomerId;
            this.Address = p_order.Address;
        }

        public int OrdersId { get; set; }
        public decimal TotalPrice { get; set; }
        public int StoreFrontId { get; set; }
        public int CustomerId { get; set; }
        public string Address { get; set; }
    }
}
