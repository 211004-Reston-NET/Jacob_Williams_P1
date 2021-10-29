using System;
using System.Collections.Generic;
using Models;

namespace BusinessLogic
{
    public class OrderBL : IOrderBL
    {
        public Order GetOrderByProductAndStoreFrontId(int p_productId, int p_storeId)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders()
        {
            throw new NotImplementedException();
        }

        public Order PlaceOrder(int p_productId, int p_storeId)
        {
            throw new NotImplementedException();
        }
    }
}