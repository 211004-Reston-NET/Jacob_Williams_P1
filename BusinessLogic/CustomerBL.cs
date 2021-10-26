using System;
using System.Collections.Generic;
using System.Linq;
using DataLogic;
using Models;

namespace BusinessLogic
{
    public class CustomerBL : ICustomerBL
    {
        private IRepository _repo;
        public CustomerBL(IRepository p_repo)
        {
            _repo = p_repo;
        }
        public Customer AddCustomer(Customer p_customer)
        {
            if (p_customer.Name == null || p_customer.Address == null || p_customer.Email == null || p_customer.PhoneNumber == null)
            {
                throw new Exception("You must have a value in all of the properties");
            }
            return _repo.AddCustomer(p_customer);
        }

        public List<Customer> GetAllCustomer()
        {
            List<Customer> listOfCustomer = _repo.GetAllCustomer();
            for (int i =0; i < listOfCustomer.Count; i++)
            {
                listOfCustomer[i].Name = listOfCustomer[i].Name.ToLower();
            }
            return listOfCustomer;
        }

        public List<Customer> GetCustomer(string p_name)
        {
            List<Customer> listOfCustomer = _repo.GetAllCustomer();
            //return listOfCustomer.Where(cust => cust.Name.ToLower().Contains(p_name.ToLower()));
            return listOfCustomer;
        }
    }
}
