using System;
using System.Collections.Generic;

namespace Models
{
    public class Customer
    {
        private int _customerId;
        private string _name;
        private string _address;
        private string _email;
        private int _phoneNumber;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        public int PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
            }
        }
        public int CustomerId
        {
            get
            {
                return _customerId;
            }
            set
            {
                _customerId = value;
            }
        }
        
        private List<Order> _orders = new List<Order>();
        public List<Order> Orders { get {return _orders;} set {_orders = value;} }


    }
}
