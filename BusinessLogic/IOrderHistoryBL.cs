using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IOrderHistoryBL
    {
        List<Models.Order> OrderHistoryBL();
    }
}