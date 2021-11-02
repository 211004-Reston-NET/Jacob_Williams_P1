using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IReplenishInventoryBL
    {
        Models.StoreFront RepInventory(int p_lineItemId, int p_lineItemQuantity);
    }
}