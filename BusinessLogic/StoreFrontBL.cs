using System;
using System.Collections.Generic;
using System.Linq;
using DataLogic;
using Models;

namespace BusinessLogic
{
    public class StoreFrontBL : IStoreFrontBL
    {
        private IRepository _repo;
        public StoreFrontBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        public StoreFront GetStoreFrontById(int p_id)
        {
            return _repo.GetStoreFrontById(p_id);
        }



        public List<StoreFront> GetStoreFrontList()
        {
            return _repo.GetStoreFrontList();   
        }


        // public Customer GetCustomer(string p_name, string p_address)
        // {
        //     List<Customer> listOfCustomer = _repo.GetAllCustomer();
        //     return listOfCustomer.FirstOrDefault(cust => cust.Name.ToLower().Contains(p_name.ToLower()) && cust.Address.ToLower().Contains(p_address.ToLower()));
        // }
    }
}