using System;
using System.Collections.Generic;
using Models;
using DataLogic;

namespace BusinessLogic
{
    public class OrderBL : IOrderBL
    {
        private IRepository _repo;
        public OrderBL(IRepository p_repo)
        {
            _repo = p_repo;
        }
        public Order GetOrderByProductAndStoreFrontId(int p_productId, int p_storeId)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders()
        {
            throw new NotImplementedException();
        }

        public void PlaceOrder(Customer p_customer, Order p_order)
        {
             _repo.PlaceOrder(p_customer, p_order);
        }
    }
}