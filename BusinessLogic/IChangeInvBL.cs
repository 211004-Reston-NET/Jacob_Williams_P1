using System;
using Models;

namespace BusinessLogic
{
    public interface IChangeInvBL
    {
        LineItems GetLineItemById(int p_id);

        LineItems UpdateInventory(LineItems p_upd, int p_howMuchAdded);
    };
}