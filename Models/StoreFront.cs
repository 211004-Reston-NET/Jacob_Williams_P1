using System;
using System.Collections.Generic;

namespace Models
{
    public class StoreFront
    {
        public int _storeFrontId;
        public string _storeFrontName;
        public string _storeFrontAddress;

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
        public string StoreFrontName
        {
            get
            {
                return _storeFrontName;
            }
            set
            {
                _storeFrontName = value;
            }
        }
        public string StoreFrontAddress
        {
            get
            {
                return _storeFrontAddress;
            }
            set
            {
                _storeFrontAddress = value;
            }
        }
        public override string ToString()
        {
            return $"Name: {StoreFrontName} \nAddress: {StoreFrontAddress}";
        }
    }
}