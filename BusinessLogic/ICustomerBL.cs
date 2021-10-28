using System.Collections.Generic;
using Models;

namespace BusinessLogic
{
    public interface ICustomerBL
    {
        //List for all the customer
        List<Customer> GetAllCustomer();
        //adding a customer to the list
        Customer AddCustomer(Customer p_rest);
        Customer GetCustomer(string p_name, string p_address);

        
    }


}