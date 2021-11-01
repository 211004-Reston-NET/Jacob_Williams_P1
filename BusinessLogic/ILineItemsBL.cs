using System;
using System.Collections.Generic;
using Models;

namespace BusinessLogic

{
    public interface ILineItemsBL
    {
        List<Models.LineItems> GetAllLineItem(int StoreFrontId);
        Models.LineItems LineItem();
    }
}