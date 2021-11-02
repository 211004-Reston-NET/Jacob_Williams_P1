using System;
using System.Collections.Generic;
using Models;
using DataLogic;

namespace BusinessLogic
{
    public class OrderHistoryBL : IOrderHistoryBL
    {
        private IRepository _repo;
        public OrderHistoryBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        public List<Order> OrderHistory()
        {
            List<Order> listOfOrder = _repo.OrderHistory();
            // for (int i =0; i < listOfOrder.Count; i++)
            // {
            //     listOfOrder[i].OrdersId; //= listOfOrder[i].CustomerId;
            // }
            return listOfOrder;
        }

        List<Order> IOrderHistoryBL.OrderHistoryBL()
        {
            throw new NotImplementedException();
        }

        // List<Order> IOrderHistoryBL.OrderHistoryBL()
        // {
        //     List<Order> listOfOrder = _repo.OrderHistoryBL();
        //     for (int i =0; i < listOfOrder.Count; i++)
        // }
        // return listOfOrder;
    }
}