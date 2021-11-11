using System;
using System.Collections.Generic;

namespace Models

{
    public class Product
    {
        public int _productId;
        public string _productName;
        public string _productDescription;
        public double _productPrice;

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
        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                _productName = value;
            }
        }
        public string ProductDescription
        {
            get
            {
                return _productDescription;
            }
            set
            {
                _productDescription = value;
            }
        }
        public double ProductPrice
        {
            get
            {
                return _productPrice;
            }
            set
            {
                _productPrice = value;
            }
        }

        public List<LineItems> LineItems { get; set; }
        public override string ToString(){
            return $"Name: {ProductName} \nPrice: {ProductPrice} \nDescription: {ProductDescription}";
        }

    }
}