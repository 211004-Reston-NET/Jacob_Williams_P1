using System.Collections.Generic;

namespace Models
{
    public class Order
    {
      
        public int _ordersId;
        public int _customerId;
        public int _storeFrontId;
        public string _address;
        public decimal _totalPrice;
        private List<LineItems> _lineItems = new List<LineItems>();
        public List<LineItems> LineItems
        {
            get { return _lineItems; }
            set { _lineItems = value; }
        }
        
        public int OrdersId
        {
            get
            {
                return _ordersId;
            }
            set
            {
                _ordersId = value;
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
        public int StoreFrontId
        {
            get
            {
                return _storeFrontId;
            }
            set
            {
                _storeFrontId = value;
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
        public decimal TotalPrice
        {
            get
            {
                return _totalPrice;
            }
            set
            {
                _totalPrice = value;
            }
        }
    }
    
}