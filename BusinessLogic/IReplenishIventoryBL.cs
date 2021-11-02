using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IReplenishInventoryBL
    {
        List<Models.StoreFront> ReplenishInventory();
        Models.StoreFront RepInventoryWithProductIdAndStoreId(int p_productId, int p_storeId);
        Models.StoreFront RepInventory(IReplenishInventoryBL p_customer, IReplenishInventoryBL p_order);
    }
}