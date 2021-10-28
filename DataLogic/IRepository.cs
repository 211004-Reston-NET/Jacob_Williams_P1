using System.Collections.Generic;
using Models;

namespace DataLogic
{
    public interface IRepository
    {
        /// <summary>
        /// Adds a customer to the database
        /// </summary>
        /// <param name="p_cust"> Customer we defined in our Models folder, we pass it in. we're basically saying it has to match what we have in the models folder</param>
        /// <returns> Left most Customer </returns>
        Customer AddCustomer(Customer p_cust);

        /// <summary>
        /// Gives a list of customers from the database
        /// </summary>
        /// <returns>this returns a list of all the customers from the database </returns>
        List<Customer> GetAllCustomer();

        /// <summary>
        /// This is going to
        /// </summary>
        /// <returns>this returns a list of all the line items from the database</returns>
        
        List<LineItems> GetAllLineItems();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>This returns a list of all the line items from the database
        List<StoreFront> GetStoreFrontList();



    }
}