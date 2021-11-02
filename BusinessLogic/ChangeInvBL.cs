using System;
using Models;
using DataLogic;

namespace BusinessLogic
{
    public class ChangeInvBL : IChangeInvBL
    {
        private IRepository _repo;

        public ChangeInvBL(IRepository p_repo)
        {
            _repo = p_repo;
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
    // int.Parse
}