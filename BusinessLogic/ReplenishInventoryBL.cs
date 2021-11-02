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
        public StoreFront RepInventory(Product p_productId, StoreFront p_storeId) //This is the one right here
        {
            return _repo.RepInventory(p_productId, p_storeId);
        }

        public StoreFront RepInventory(IReplenishInventoryBL p_customer, IReplenishInventoryBL p_order)
        {
            throw new NotImplementedException();
        }

        public StoreFront RepInventoryWithProductIdAndStoreId(int p_productId, int p_storeId)
        {
            throw new NotImplementedException();
        }

        List<StoreFront> IReplenishInventoryBL.ReplenishInventory()
        {
            throw new NotImplementedException();
        }
    }
}