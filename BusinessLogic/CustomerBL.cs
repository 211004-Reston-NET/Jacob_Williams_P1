using System;
using DataLogic;
using Models;

namespace BusinessLogic
{
    public class CustomerBL
    {
        private Repository _repo;
        public CustomerBL(Repository p_repo)
        {
            _repo = p_repo;
        }
        public Customer AddCustomer(Customer p_customer)
        {
            return _repo.AddCustomer(p_customer);
        }
    }
}
