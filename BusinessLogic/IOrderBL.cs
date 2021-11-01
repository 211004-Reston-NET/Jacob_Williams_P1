using System;
using System.Collections.Generic;
using Models;

namespace BusinessLogic
{
    public interface IOrderBL
    {
        List<Models.Order> GetOrders();
        Order GetOrderByProductAndStoreFrontId(int p_productId, int p_storeId);
        Order PlaceOrder();



    }
}