using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class LineItems
    {
        public int _lineItemId;
        public int _lineItemQuantity;
        public int _productId;
        public int _storeFrontId;

        
        
        [Key]
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
        public int LineItemQuantity
        {
            get
            {
                return _lineItemQuantity;
            }
            set
            {
                _lineItemQuantity = value;
            }
        }
        public int ProductId
        {
            get
            {
                return _productId;
            }
            set
            {
                _productId = value;
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
        public virtual StoreFront StoreFront { get; set; }
        public virtual ICollection<ItemsInOrder> ItemsInOrders { get; set; }
        public Product Product { get; set; }
    }
    
}