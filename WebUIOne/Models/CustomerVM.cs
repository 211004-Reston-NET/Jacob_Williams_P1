using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUIOne.Models
{
    public class CustomerVM
    {
        public CustomerVM()
        {

        }
        public CustomerVM(Customer p_cust)
        {
            this.CustomerID = p_cust.CustomerId;
            this.Name = p_cust.Name;
            this.Address = p_cust.Address;
            this.Email = p_cust.Email;
            this.PhoneNumber = p_cust.PhoneNumber;
        }

        public int CustomerID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }

    }
}
