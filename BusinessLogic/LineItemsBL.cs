using System;
using System.Collections.Generic;
using DataLogic;
using Models;

namespace BusinessLogic
{
    public class LineItemsBL : ILineItemsBL
    {
        private IRepository _repo;
        public LineItemsBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        public LineItems LineItem()
        {
            throw new NotImplementedException();
        }
        public List<LineItems> GetAllLineItem(int StoreFrontId)
        {
            List<LineItems> listOfLineItems = _repo.GetLineItems(StoreFrontId);
            return listOfLineItems;
        }

        public static implicit operator LineItemsBL(int v)
        {
            throw new NotImplementedException();
        }
        public StoreFront RepInventory(int p_lineItemId, int p_lineItemQuantity)
        {
            throw new NotImplementedException();
        }

        public LineItems GetLineItemById(int p_id)
        {
            return _repo.GetLineItemById(p_id);
        }
        public LineItems UpdateInventory(LineItems p_upd, int p_howMuchAdded)
        {
            p_upd.LineItemQuantity += p_howMuchAdded;

            return _repo.UpdateInventory(p_upd);
        }
    }
}