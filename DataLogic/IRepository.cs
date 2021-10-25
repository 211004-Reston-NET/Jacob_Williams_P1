using System.Collections.Generic;
using Models;

namespace DataLogic
{
    public interface IRepository
    {
        Customer AddCustomer(Customer p_rest);

        List<Customer> GetAllCustomer();
    }
}