using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace WebUIOne.Models
{
    public class PlaceOrderVM
    {
        public PlaceOrderVM()
        {

        }
        public PlaceOrderVM(Order p_order)
        {
            this.OrdersId = p_order.OrdersId;
            this.TotalPrice = p_order.TotalPrice;
            this.StoreFrontId = p_order.StoreFrontId;
            this.CustomerId = p_order.StoreFrontId;
            this.Address = p_order.Address;
        }

        public int OrdersId { get; set; }
        public decimal TotalPrice { get; set; }
        public int StoreFrontId { get; set; }
        public int CustomerId { get; set; }
        public string Address { get; set; }
    }
}
