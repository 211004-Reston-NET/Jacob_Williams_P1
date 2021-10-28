using System;
using System.Collections.Generic;

namespace Models
{
    public class ItemsInOrder
    {
        public int _itemsInOrderId;
        public int _lineItemId;
        public int _ordersId;

        public int ItemsInOrderId
        {
            get
            {
                return _itemsInOrderId;
            }
            set
            {
                _itemsInOrderId = value;
            }
        }
        public int LineItemId
        {
            get
            {
                return _lineItemId;
            }
            set
            {
                _lineItemId = value;
            }
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
    }
}