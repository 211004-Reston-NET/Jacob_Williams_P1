using System;
using System.Collections.Generic;
using DataLogic;
using Models;

namespace BusinessLogic
{
    public class ReplenishInventoryBL : IReplenishInventoryBL
    {
        private IRepository _repo;
        public ReplenishInventoryBL(IRepository p_repo)
        {
            _repo = p_repo;
        }
        // public StoreFront RepInventory(Product p_productId, StoreFront p_storeId)
        // {
        //     return _repo.RepInventory(p_productId, p_storeId);
        // }

        public StoreFront RepInventory(Models.LineItems p_lineItem, Models.StoreFront p_storeFront) //This is the one right here
        {
            throw new NotImplementedException();
        }

        public StoreFront RepInventory(int p_lineItemId, int p_lineItemQuantity)
        {
            throw new NotImplementedException();
        }


        // List<StoreFront> IReplenishInventoryBL.ReplenishInventory()
        // {
        //     throw new NotImplementedException();
        // }
    }
}