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
    }
}